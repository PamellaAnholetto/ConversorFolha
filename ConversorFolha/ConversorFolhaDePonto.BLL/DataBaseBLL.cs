using System.Collections.Generic;
using System.Linq;
using ConversorFolhaDePonto.DAL;
using ConversorFolhaDePonto.Modelo;

namespace ConversorFolhaDePonto.BLL
{
    public class DataBaseBLL
    {
        private static DAO objDAO = new DAO();

        public static void GravarLayout(Layout ObjLayout)
        {
            string strComando = "INSERT INTO layout(nome, inicioempresa, tamanhoempresa, inicioevento, tamanhoevento, iniciofuncionario, " +
                                                   "tamanhofuncionario, iniciohoras, tamanhohoras) " +
                                "VALUES(@nome, @inicioempresa, @tamanhoempresa, @inicioevento, @tamanhoevento, @iniciofuncionario, " +
                                       "@tamanhofuncionario, @iniciohoras, @tamanhohoras)";
            Dictionary<string, object> dicParametros = new Dictionary<string, object>()
            {
                {"@nome", ObjLayout.Nome },
                {"@inicioempresa", ObjLayout.InicioEmpresa },
                {"@tamanhoempresa", ObjLayout.TamanhoEmpresa },
                {"@inicioevento", ObjLayout.InicioEvento },
                {"@tamanhoevento", ObjLayout.TamanhoEvento},
                {"@iniciofuncionario", ObjLayout.InicioFuncionario },
                {"@tamanhofuncionario", ObjLayout.TamanhoFuncionario },
                {"@iniciohoras", ObjLayout.InicioHoras },
                {"@tamanhohoras", ObjLayout.TamanhoHoras }
            };
            objDAO.Execute(strComando, dicParametros);
        }

        public static void GravarEmpresa(Empresa ObjEmpresa)
        {
            string strComando = "INSERT INTO empresa(id, nome, inicioevento, tamanhoevento, iniciofuncionario, tamanhofuncionario, " +
                                                    "iniciohoras, tamanhohoras) " +
                                "VALUES(@id, @nome, @inicioevento, @tamanhoevento, @iniciofuncionario, @tamanhofuncionario, " +
                                       "@iniciohoras, @tamanhohoras)";
            Dictionary<string, object> dicParametros = new Dictionary<string, object>()
            {
                {"@id", ObjEmpresa.Id },
                {"@nome", ObjEmpresa.Nome },
                {"@inicioevento", ObjEmpresa.InicioEvento },
                {"@tamanhoevento", ObjEmpresa.TamanhoEvento },
                {"@iniciofuncionario", ObjEmpresa.InicioFuncionario },
                {"@tamanhofuncionario", ObjEmpresa.TamanhoFuncionario },
                {"@iniciohoras", ObjEmpresa.InicioHoras },
                {"@tamanhohoras", ObjEmpresa.TamanhoHoras }
            };
            objDAO.Execute(strComando, dicParametros);
        }

        public static void GravarEvento(Evento ObjEvento)
        {
            string strComando = "INSERT INTO evento(externo,idempresa,interno,transferivel,nomeempresa)" +
                                "VALUES(@externo,@idempresa,@interno,@transferivel,@nomeempresa)";
            Dictionary<string, object> dicParametros = new Dictionary<string, object>()
            {
                {"@externo", ObjEvento.Externo },
                {"@idempresa", ObjEvento.IdEmpresa },
                {"@interno", ObjEvento.Interno },
                {"@transferivel", ObjEvento.Transferivel },
                {"@nomeempresa", ObjEvento.NomeEmpresa}
            };
            objDAO.Execute(strComando, dicParametros);
        }

        public static void GravarFuncionario(Funcionario ObjFuncionario)
        {
            string strComando = "INSERT INTO funcionario (externo,idempresa,interno,nomeempresa)" +
                                "VALUES (@externo,@idempresa,@interno,@nomeempresa)";
            Dictionary<string, object> dicParametros = new Dictionary<string, object>()
            {
                {"@externo", ObjFuncionario.Externo },
                {"@idempresa", ObjFuncionario.IdEmpresa },
                {"@interno", ObjFuncionario.Interno },
                {"@nomeempresa", ObjFuncionario.NomeEmpresa}
            };
            objDAO.Execute(strComando, dicParametros);
        }

        public static void AlterarEmpresa(Empresa ObjEmpresa)
        {
            string strComando = ("UPDATE empresa SET  empresaid = @id, nome = @nome, inicioevento = @inicioevento, tamanhoevento = @tamanhoevento, iniciofuncionario = @iniciofuncionario, tamanhofuncionario = @tamanhofuncionario, " +
                                                    "iniciohoras = @iniciohoras, tamanhohoras = @tamanhohoras WHERE idempresa = @idempresa");



            Dictionary<string, object> dicParametros = new Dictionary<string, object>()
            {
                {"@id", ObjEmpresa.Id },
                {"@nome", ObjEmpresa.Nome },
                {"@inicioevento", ObjEmpresa.InicioEvento },
                {"@tamanhoevento", ObjEmpresa.TamanhoEvento },
                {"@iniciofuncionario", ObjEmpresa.InicioFuncionario },
                {"@tamanhofuncionario", ObjEmpresa.TamanhoFuncionario },
                {"@iniciohoras", ObjEmpresa.InicioHoras },
                {"@tamanhohoras", ObjEmpresa.TamanhoHoras }
            };
            objDAO.Execute(strComando, dicParametros);
        }

        public static void AlterarEvento(Evento ObjEvento, string strOldExterno)
        {
            string strComando = ("UPDATE evento SET externo = @newexterno, interno = @interno, transferivel = @transferivel WHERE idempresa = @idempresa AND externo = @oldexterno");

            Dictionary<string, object> dicParametros = new Dictionary<string, object>()
            {
                {"@newexterno", ObjEvento.Externo },
                {"@idempresa", ObjEvento.IdEmpresa },
                {"@interno", ObjEvento.Interno },
                {"@transferivel", ObjEvento.Transferivel },
                {"@nomeempresa", ObjEvento.NomeEmpresa},
                {"@oldexterno", strOldExterno}
            };
            objDAO.Execute(strComando, dicParametros);
        }

        public static void AlterarFuncionario(Funcionario ObjFuncionario, string strOldExterno)
        {
            string strComando = ("UPDATE funcionario SET externo = @newexterno, interno = @interno WHERE idempresa = @idempresa AND externo = @oldexterno");

            Dictionary<string, object> dicParametros = new Dictionary<string, object>()
            {
                {"@newexterno", ObjFuncionario.Externo },
                {"@idempresa", ObjFuncionario.IdEmpresa },
                {"@interno", ObjFuncionario.Interno },
                {"@nomeempresa", ObjFuncionario.NomeEmpresa},
                {"@oldexterno",strOldExterno }
            };
            objDAO.Execute(strComando, dicParametros);
        }

        public static List<Empresa> CarregarEmpresasComboBox()
        {
            string strComando = "SELECT id, nome FROM empresa ORDER BY id";
            var vLinhas = objDAO.Query(strComando, null);
            List<Empresa> lEmpresas = new List<Empresa> { new Empresa { Id = string.Empty, Nome = string.Empty } };
            foreach (var vLinha in vLinhas)
            {
                lEmpresas.Add(new Empresa
                {
                   Id = vLinha["id"],
                   Nome = vLinha["nome"],
                });
            }
            return lEmpresas;
        }

        public static List<Layout> CarregarLayoutComboBox()
        {
            string strComando = "SELECT nome FROM layout ORDER BY nome";
            var vLinhas = objDAO.Query(strComando, null);
            List<Layout> lLayouts = new List<Layout> { new Layout { Nome = string.Empty } };
            foreach (var vLinha in vLinhas)
            {
                lLayouts.Add(new Layout { Nome = vLinha["nome"] });
            }
            return lLayouts;
        }
        public static List<Layout> CarregarLayoutGrid(string strIdLayout)
        {
            string strComando = string.Empty;
            if (string.IsNullOrEmpty(strIdLayout))
            {      
                strComando = "SELECT nome, inicioempresa, tamanhoempresa, inicioevento, tamanhoevento, iniciofuncionario, tamanhofuncionario, iniciohoras, tamanhohoras  " +
                             "FROM layout";
            }
            else
            {
                strComando = "SELECT nome, inicioempresa, tamanhoempresa, inicioevento, tamanhoevento, iniciofuncionario, tamanhofuncionario, iniciohoras, tamanhohoras   " +
                             "FROM layout " +
                             "WHERE nome=@nome";
            }

            Dictionary<string, object> dicParametros = new Dictionary<string, object>() { { "@nome", strIdLayout } };
            var vLinhas = objDAO.Query(strComando, dicParametros);
            List<Layout> lLayouts = new List<Layout>();
            foreach (var vLinha in vLinhas)
            {
                lLayouts.Add(new Layout
                {
                    Nome = vLinha["nome"],
                    InicioEmpresa = int.Parse(vLinha["inicioempresa"]),
                    TamanhoEmpresa = int.Parse(vLinha["tamanhoempresa"]),
                    InicioEvento = int.Parse(vLinha["inicioevento"]),
                    TamanhoEvento = int.Parse(vLinha["tamanhoevento"]),
                    InicioFuncionario = int.Parse(vLinha["iniciofuncionario"]),
                    TamanhoFuncionario = int.Parse(vLinha["tamanhofuncionario"]),
                    InicioHoras = int.Parse(vLinha["iniciohoras"]),
                    TamanhoHoras = int.Parse(vLinha["tamanhohoras"])


                });
            }
            return lLayouts;
        }

        public static List<Empresa> CarregarEmpresaGrid(string strIdEmpresa)
        {
            string strComando = string.Empty;
            if (string.IsNullOrEmpty(strIdEmpresa)) strComando = "SELECT id, nome, inicioevento, tamanhoevento, iniciofuncionario, tamanhofuncionario, iniciohoras, tamanhohoras  FROM empresa";
            else strComando = "SELECT id, nome, inicioevento, tamanhoevento, iniciofuncionario, tamanhofuncionario, iniciohoras, tamanhohoras FROM empresa WHERE id=@id";

            Dictionary<string, object> dicParametros = new Dictionary<string, object>() { { "@id", strIdEmpresa } };
            var vLinhas = objDAO.Query(strComando, dicParametros);
            List<Empresa> lEmpresas = new List<Empresa>();
            foreach (var vLinha in vLinhas)
            {
                lEmpresas.Add(new Empresa
                {
                    Id = vLinha["id"],
                    Nome = vLinha["nome"],
                    InicioEvento = int.Parse(vLinha["inicioevento"]),
                    TamanhoEvento = int.Parse(vLinha["tamanhoevento"]),
                    InicioFuncionario = int.Parse(vLinha["iniciofuncionario"]),
                    TamanhoFuncionario = int.Parse(vLinha["tamanhofuncionario"]),
                    InicioHoras = int.Parse(vLinha["iniciohoras"]),
                    TamanhoHoras = int.Parse(vLinha["tamanhohoras"])
                });
            }
            return lEmpresas;
        }

        public static List<Evento> CarregarEventoGrid(string strIdEvento)
        {
            string strComando = string.Empty;
            if (string.IsNullOrEmpty(strIdEvento))
            {
                strComando = "SELECT  idempresa, nomeempresa, externo, interno, CAST(transferivel AS CHARACTER VARYING) " +
                             "FROM evento";
            }
            else
            {
                strComando = "SELECT idempresa, nomeempresa, externo, interno, CAST(transferivel AS CHARACTER VARYING) " +
                             "FROM evento " +
                             "WHERE idempresa=@idempresa";
            }

            Dictionary<string, object> dicParametros = new Dictionary<string, object>() { { "@idempresa", strIdEvento } };
            var vLinhas = objDAO.Query(strComando, dicParametros);
            List<Evento> lEvento = new List<Evento>();
            foreach (var vLinha in vLinhas)
            {
                lEvento.Add(new Evento
                {
                    IdEmpresa = vLinha["idempresa"],
                    NomeEmpresa = vLinha["nomeempresa"],
                    Externo = vLinha["externo"],
                    Interno = vLinha["interno"],
                    Transferivel = bool.Parse(vLinha["transferivel"])
                });
            }
            return lEvento;
        }

        public static List<Funcionario> CarregarFuncionarioGrid(string strIdFuncionario)
        {
            string strComando = string.Empty;
            if (string.IsNullOrEmpty(strIdFuncionario))
            {
                strComando = "SELECT idempresa, nomeempresa, externo, interno " +
                             "FROM funcionario";
            }
            else
            {
                strComando = "SELECT idempresa, nomeempresa, externo, interno " +
                             "FROM funcionario " +
                             "WHERE idempresa=@idempresa";
            }

            Dictionary<string, object> dicParametros = new Dictionary<string, object>() { { "@idempresa", strIdFuncionario } };
            var vLinhas = objDAO.Query(strComando, dicParametros);
            List<Funcionario> lFuncionario = new List<Funcionario>();
            foreach (var vLinha in vLinhas)
            {
                lFuncionario.Add(new Funcionario
                {
                    IdEmpresa = vLinha["idempresa"],
                    NomeEmpresa = vLinha["nomeempresa"],
                    Externo = vLinha["externo"],
                    Interno = vLinha["interno"]
                });
            }
            return lFuncionario;
        }

        public static Layout BuscarLayoutPorNome(string strNome)
        {
            string strComando = "SELECT nome, inicioempresa, tamanhoempresa, inicioevento, tamanhoevento, " +
                                       "iniciofuncionario, tamanhofuncionario, iniciohoras, tamanhohoras " +
                                "FROM layout " +
                                "WHERE nome = @nome";

            Dictionary<string, object> dicParametros = new Dictionary<string, object>() { { "@nome", strNome } };
            var vLinhas = objDAO.Query(strComando, dicParametros);
            if (vLinhas.Count() == 1)
            {
                var vLinha = vLinhas[0];
                return new Layout()
                {
                    Nome = vLinha["nome"],
                    InicioEmpresa = int.Parse(vLinha["inicioempresa"]),
                    TamanhoEmpresa = int.Parse(vLinha["tamanhoempresa"]),
                    InicioEvento = int.Parse(vLinha["inicioevento"]),
                    TamanhoEvento = int.Parse(vLinha["tamanhoevento"]),
                    InicioFuncionario = int.Parse(vLinha["iniciofuncionario"]),
                    TamanhoFuncionario = int.Parse(vLinha["tamanhofuncionario"]),
                    InicioHoras = int.Parse(vLinha["iniciohoras"]),
                    TamanhoHoras = int.Parse(vLinha["tamanhohoras"])
                };
            }
            return null;
        }

        public static Empresa BuscarEmpresaPorId(string strIdEmpresa)
        {
            string strComando = "SELECT id, nome, inicioevento, tamanhoevento, iniciofuncionario, tamanhofuncionario, " +
                                       "iniciohoras, tamanhohoras " +
                                "FROM empresa WHERE id=@id";
            Dictionary<string, object> dicParametros = new Dictionary<string, object>() { { "@id", strIdEmpresa } };
            var vLinhas = objDAO.Query(strComando, dicParametros);
            if (vLinhas.Count == 1)
            {
                var vLinha = vLinhas[0];
                return new Empresa()
                {
                    Id = vLinha["id"],
                    Nome = vLinha["nome"],
                    InicioEvento = int.Parse(vLinha["inicioevento"]),
                    TamanhoEvento = int.Parse(vLinha["tamanhoevento"]),
                    InicioFuncionario = int.Parse(vLinha["iniciofuncionario"]),
                    TamanhoFuncionario = int.Parse(vLinha["tamanhofuncionario"]),
                    InicioHoras = int.Parse(vLinha["iniciohoras"]),
                    TamanhoHoras = int.Parse(vLinha["tamanhohoras"])
                };
            }
            return null;
        }

        public static Evento BuscarEventoPorId(string strIdEvento)
        {
            string strComando = "SELECT idempresa, nomeempresa, externo, interno, CAST (transferivel AS CHARACTER VARYING) " +
                                "FROM evento " +
                                "WHERE externo = @externo";

            Dictionary<string, object> dicParametros = new Dictionary<string, object>() { { "@externo", strIdEvento } };
            var vLinhas = objDAO.Query(strComando, dicParametros);
            if (vLinhas.Count() == 1)
            {
                var vLinha = vLinhas[0];
                return new Evento()
                {
                    IdEmpresa = vLinha["idempresa"],
                    NomeEmpresa = vLinha["nomeempresa"],
                    Externo = vLinha["externo"],
                    Interno = vLinha["interno"],
                    Transferivel = bool.Parse(vLinha["transferivel"])
                };
            }
            return null;
        }

        public static Funcionario BuscarFuncionarioPorId(string strIdFuncionario)
        {
            string strComando = "SELECT codigoempresa, nomeempresa, externo, interno " +
                                "FROM funcionario " +
                                "WHERE externo = @externo";

            Dictionary<string, object> dicParametros = new Dictionary<string, object>() { { "@externo", strIdFuncionario } };
            var vLinhas = objDAO.Query(strComando, dicParametros);
            if (vLinhas.Count() == 1)
            {
                var vLinha = vLinhas[0];
                return new Funcionario()
                {
                    IdEmpresa = vLinha["idempresa"],
                    NomeEmpresa = vLinha["nomeempresa"],
                    Externo = vLinha["externo"],
                    Interno = vLinha["interno"]
                };
            }
            return null;
        }

        public static List<Dictionary<string, string>> BuscarFuncionarioEventoPorId(string strIdFuncionario, string strIdEvento)
        {
            string strComando = "SELECT FUN.idempresa, FUN.nomeempresa, FUN.externo, FUN.interno, EVT.externo, EVT.interno, CAST(EVT.transferivel AS CHARACTER VARYING) " +
                                "FROM funcionario FUN Join evento EVT on FUN.idempresa = EVT.idempresa " +
                                "WHERE FUN.externo = @FUN.externo and EVT.externo = @EVT.externo";
            Dictionary<string, object> dicParametros = new Dictionary<string, object>()
            {
                { "@FUN.externo", strIdFuncionario },
                { "@EVT.externo", strIdEvento }
            };
            return objDAO.Query(strComando, dicParametros);
        }

        public static List<Funcionario> ListarFuncionariosPorEmpresa(string strIdEmpresa)
        {
            string strComando = "SELECT FUN.idempresa, FUN.nomeempresa, FUN.externo, FUN.interno " +
                                "FROM funcionario FUN WHERE FUN.idempresa = @idempresa";
            Dictionary<string, object> dicParametros = new Dictionary<string, object>() { { "@idempresa", strIdEmpresa } };
            var vLinhas = objDAO.Query(strComando, dicParametros);
            if (vLinhas.Count > 0)
            {
                List<Funcionario> lFuncionario = new List<Funcionario>();
                foreach (var vLinha in vLinhas)
                {
                    lFuncionario.Add(new Funcionario()
                    {
                        IdEmpresa = vLinha["idempresa"],
                        NomeEmpresa = vLinha["nomeempresa"],
                        Externo = vLinha["externo"],
                        Interno = vLinha["interno"]
                    });
                }
                return lFuncionario;
            }
            return null;
        }

        public static List<Evento> ListarEventosPorEmpresa(string strIdEmpresa)
        {
            string strComando = "SELECT EVT.idempresa, EVT.nomeempresa, EVT.externo, " +
                                       "EVT.interno, CAST(EVT.transferivel AS CHARACTER VARYING) " +
                                "FROM evento EVT WHERE EVT.idempresa = @idempresa";
            Dictionary<string, object> dicParametros = new Dictionary<string, object>() { { "@idempresa", strIdEmpresa } };
            var vLinhas = objDAO.Query(strComando, dicParametros);
            if (vLinhas.Count > 0)
            {
                List<Evento> lEvento = new List<Evento>();
                foreach (var vLinha in vLinhas)
                {
                    lEvento.Add(new Evento()
                    {
                        IdEmpresa = vLinha["idempresa"],
                        NomeEmpresa = vLinha["nomeempresa"],
                        Externo = vLinha["externo"],
                        Interno = vLinha["interno"],
                        Transferivel = bool.Parse(vLinha["transferivel"])
                    });
                }
                return lEvento;
            }
            return null;
        }
    }
}
