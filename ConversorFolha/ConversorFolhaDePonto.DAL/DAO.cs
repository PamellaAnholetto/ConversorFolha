using System;
using Npgsql;
using System.Data;
using System.Threading;
using System.Collections.Generic;

namespace ConversorFolhaDePonto.DAL
{
    /// <summary>
    /// Classe encapsula conexões ao Postgres e operações CRUD. 
    /// </summary>
    public class DAO : IDisposable
    {
        private NpgsqlConnection npgslConnection;
        /// <summary>
        /// Construtor padrão com a connection string o arquivo web config.
        /// </summary>                        
        public DAO()
        {
            npgslConnection = new NpgsqlConnection("Server=localhost;Port=5432;UserId=postgres;Password=postgres;Database=ConversorFolha");
        }
        /// <summary>
        /// Abre a conexão caso já não esteja.
        /// </summary>
        public void AbrirConexao()
        {
            var vTentativas = 3;
            if (npgslConnection.State == ConnectionState.Open) return;
            else
            {
                while (vTentativas >= 0 && npgslConnection.State != ConnectionState.Open)
                {
                    npgslConnection.Open();
                    vTentativas--;
                    Thread.Sleep(30);
                }
            }
        }
        /// <summary>
        /// Fecha a conexão caso esteja aberta.
        /// </summary>
        public void FecharConexao()
        {
            if (npgslConnection.State == ConnectionState.Open) npgslConnection.Close();
        }
        /// <summary>
        /// Libera a memória utilizada na conexão com o Postgres.
        /// </summary>
        public void Dispose()
        {
            if (npgslConnection != null)
            {
                npgslConnection.Dispose();
                npgslConnection = null;
            }
        }

        /// <summary>
        /// Executa non-query Npgsql.
        /// </summary>
        /// <param name="strComando">Npgsql query a ser executada.</param>
        /// <param name="dicParametros">Parametros opcionais da query.</param>
        /// <returns>Quatidade de linhas afetadas pela query.</returns>
        public int Execute(string strComando, Dictionary<string, object> dicParametros)
        {
            int intResultado = 0;
            if (string.IsNullOrEmpty(strComando)) throw new ArgumentException("Comando não pode ser Null ou Branco.");
            try
            {
                AbrirConexao();
                var vComando = CreateCommand(strComando, dicParametros);
                intResultado = vComando.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                throw new Exception(ex.SqlState);
            }
            finally
            {
                FecharConexao();
            }
            return intResultado;
        }
        /// <summary>
        /// Executa Npgsql query retornando valor scalar único.
        /// </summary>
        /// <param name="strComando">Npgsql query a ser executada.</param>
        /// <param name="dicParametros">Parametros opcionais da query.</param>
        /// <returns></returns>
        public object QueryValue(string strComando, Dictionary<string, object> dicParametros)
        {
            object objResultado = null;
            if (string.IsNullOrEmpty(strComando)) throw new ArgumentException("Comando não pode ser Null ou Branco.");
            try
            {
                AbrirConexao();
                var vComando = CreateCommand(strComando, dicParametros);
                objResultado = vComando.ExecuteScalar();
            }
            finally
            {
                FecharConexao();
            }

            return objResultado;
        }

        /// <summary>
        /// Executa Npgsql query retornando lista de linhas.
        /// </summary>
        /// <param name="strComando">Npgsql query a ser executada.</param>
        /// <param name="dicParametros">Parametros opcionais da query.</param>
        /// <returns>Lista tipo Dictionary of Key, par de valores representando 
        /// nome da coluna e o valor correspondente.</returns>
        public List<Dictionary<string, string>> Query(string strComando, Dictionary<string, object> dicParametros)
        {
            List<Dictionary<string, string>> ldicLinhas = null;
            if (string.IsNullOrEmpty(strComando))
            {
                throw new ArgumentException("Comando não pode ser Null ou Branco.");
            }

            try
            {
                AbrirConexao();
                var vComando = CreateCommand(strComando, dicParametros);
                using (NpgsqlDataReader npgsqlReader = vComando.ExecuteReader())
                {
                    ldicLinhas = new List<Dictionary<string, string>>();
                    while (npgsqlReader.Read())
                    {
                        var vLinha = new Dictionary<string, string>();
                        for (var i = 0; i < npgsqlReader.FieldCount; i++)
                        {
                            var columnName = npgsqlReader.GetName(i);
                            var columnValue = npgsqlReader.IsDBNull(i) ? null : npgsqlReader.GetString(i);
                            vLinha.Add(columnName, columnValue);
                        }
                        ldicLinhas.Add(vLinha);
                    }
                }
            }
            finally
            {
                FecharConexao();
            }
            return ldicLinhas;
        }
        /// <summary>
        /// Creates a MySQLCommand with the given parameters
        /// Cria Comando Npgsql utilizando a Dictionary de parâmetros.
        /// </summary>
        /// <param name="strComando">Npgsql query a ser executada.</param>
        /// <param name="dicParametros">Parametros opcionais da query.</param>
        /// <returns></returns>
        private NpgsqlCommand CreateCommand(string strComando, Dictionary<string, object> dicParametros)
        {
            NpgsqlCommand npgsqlCommand = npgslConnection.CreateCommand();
            npgsqlCommand.CommandText = strComando;
            AddParameters(npgsqlCommand, dicParametros);

            return npgsqlCommand;
        }
        /// <summary>
        /// Adiciona os parâmetros ao Comando Npgsql.
        /// </summary>
        /// <param name="npgsqlCommand">Npgsql query a ser executada.</param>
        /// <param name="dicParametros">Parâmetros passados a query.</param>
        private static void AddParameters(NpgsqlCommand npgsqlCommand, Dictionary<string, object> dicParametros)
        {
            if (dicParametros == null)
            {
                return;
            }

            foreach (var parametro in dicParametros)
            {
                var vParametro = npgsqlCommand.CreateParameter();
                vParametro.ParameterName = parametro.Key;
                vParametro.Value = parametro.Value ?? DBNull.Value;
                npgsqlCommand.Parameters.Add(vParametro);
            }
        }
        /// <summary>
        /// Método Helper para retornar a string da query.
        /// </summary>
        /// <param name="strComando">Npgsql query a ser executada.</param>
        /// <param name="dicParametros">Parâmetros passados a query.</param>
        /// <returns>Valor string resultante da query.</returns>
        public string GetStrValue(string strComando, Dictionary<string, object> dicParametros)
        {
            return QueryValue(strComando, dicParametros) as string;
        }
    }
}