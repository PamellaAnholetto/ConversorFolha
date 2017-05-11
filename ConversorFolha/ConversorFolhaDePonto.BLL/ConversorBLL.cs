using ConversorFolhaDePonto.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConversorFolhaDePonto.BLL
{
    public static class ConversorBLL
    {
        public static List<string> ConverterArquivo(string[] AArquivoOriginal, Empresa ObjEmpresa, Layout ObjLayout)
        {
            List<string> strArquivoConvertido = new List<string>();
            List<Funcionario> lFuncionarios = DataBaseBLL.ListarFuncionariosPorEmpresa(ObjEmpresa.Id);
            List<Evento> lEventos = DataBaseBLL.ListarEventosPorEmpresa(ObjEmpresa.Id);
            string strFuncionario = string.Empty;
            string strEvento = string.Empty;
            string strHoras = string.Empty;
            string strErros = string.Empty;
            int contador = 0;
            Dictionary<string, int> OrdemLayout = DefinirOrdemLayout(ObjLayout);
            Dictionary<string, int> TamanhoLayout = new Dictionary<string, int>()
                            {
                                {"Empresa", ObjLayout.TamanhoEmpresa },
                                {"Evento", ObjLayout.TamanhoEvento },
                                {"Funcionario", ObjLayout.TamanhoFuncionario },
                                {"Horas", ObjLayout.TamanhoHoras }
                            };
            Dictionary<string, int> Brancos = CalcularEspacosBrancos(OrdemLayout, TamanhoLayout);
            string OrderLayout =
                OrdemLayout.Keys.ElementAt(0) + string.Empty.PadRight(Brancos[OrdemLayout.Keys.ElementAt(0)], ' ') +
                OrdemLayout.Keys.ElementAt(1) + string.Empty.PadRight(Brancos[OrdemLayout.Keys.ElementAt(1)], ' ') +
                OrdemLayout.Keys.ElementAt(2) + string.Empty.PadRight(Brancos[OrdemLayout.Keys.ElementAt(2)], ' ') +
                OrdemLayout.Keys.ElementAt(3);

            foreach (var linha in AArquivoOriginal)
            {
                if (!string.IsNullOrEmpty(linha))
                {
                    contador++;
                    if (linha.Length <= ObjEmpresa.InicioFuncionario ||
                        linha.Length <= ObjEmpresa.InicioEvento ||
                        linha.Length <= ObjEmpresa.InicioHoras ||
                        string.IsNullOrEmpty(linha.Substring(ObjEmpresa.InicioFuncionario, ObjEmpresa.TamanhoFuncionario)) ||
                        string.IsNullOrEmpty(linha.Substring(ObjEmpresa.InicioEvento, ObjEmpresa.TamanhoEvento)) ||
                        string.IsNullOrEmpty(linha.Substring(ObjEmpresa.InicioHoras, ObjEmpresa.TamanhoHoras)))
                        throw new Exception("Arquivo inválido.");
                    strFuncionario = linha.Substring(ObjEmpresa.InicioFuncionario, ObjEmpresa.TamanhoFuncionario);
                    strEvento = linha.Substring(ObjEmpresa.InicioEvento, ObjEmpresa.TamanhoEvento);
                    strHoras = linha.Substring(ObjEmpresa.InicioHoras, ObjEmpresa.TamanhoHoras);
                    if (!int.TryParse(strFuncionario, out int outputTryParse) ||
                        !int.TryParse(strEvento, out outputTryParse) ||
                        !int.TryParse(strHoras, out outputTryParse))
                        throw new Exception("Arquivo inválido.");
                    IEnumerable<Funcionario> Funcionario =
                        from funcionario in lFuncionarios
                        where (funcionario.Externo.PadLeft(ObjEmpresa.TamanhoFuncionario, '0') == strFuncionario)
                        select funcionario;
                    IEnumerable<Evento> Evento =
                        from evento in lEventos
                        where (evento.Externo.PadLeft(ObjEmpresa.TamanhoEvento, '0') == strEvento)
                        select evento;
                    if (Funcionario.Count() == 0 || Evento.Count() == 0)
                    {
                        if (string.IsNullOrEmpty(strErros))
                            strErros += "Funcionário(s) e/ou Evento(s) não cadastrados: " + Environment.NewLine;
                        AdicionarErros(contador, strFuncionario, strEvento, ref strErros, Funcionario, Evento);
                    }
                    else
                    {
                        Funcionario objFuncionario = Funcionario.ElementAt(0);
                        Evento objEvento = Evento.ElementAt(0);

                        if (objEvento.Transferivel)
                        {
                            Dictionary<string, string> Valores = new Dictionary<string, string>()
                            {
                                {"Empresa", ObjEmpresa.Id.PadLeft(ObjLayout.TamanhoEmpresa, '0') },
                                {"Evento", objEvento.Interno.PadLeft(ObjLayout.TamanhoEvento, '0') },
                                {"Funcionario", objFuncionario.Interno.PadLeft(ObjLayout.TamanhoFuncionario,'0') },
                                {"Horas",  strHoras.PadLeft(ObjLayout.TamanhoHoras, '0')}
                            };
                            string strNovaLinha = OrderLayout;
                            foreach (var valor in Valores)
                            {
                                strNovaLinha = strNovaLinha.Replace(valor.Key.ToString(), valor.Value.ToString());
                            }
                            strArquivoConvertido.Add(strNovaLinha);
                        }
                    }
                }
            }
            if (!string.IsNullOrEmpty(strErros))
                throw new Exception(strErros);
            return strArquivoConvertido;
        }

        public static void AdicionarErros(int contador, string strFuncionarioExterno, string strEventoExterno,
            ref string strErros, IEnumerable<Funcionario> Funcionario, IEnumerable<Evento> Evento)
        {
            if (Funcionario.Count() == 0)
                strErros += "- Funcionário: " + strFuncionarioExterno + Environment.NewLine;
            if (Evento.Count() == 0)
                strErros += "- Evento: " + strEventoExterno + Environment.NewLine;
            strErros += Environment.NewLine;
        }

        public static Dictionary<string, int> DefinirOrdemLayout(Layout ObjLayout)
        {
            return new Dictionary<string, int>()
            {
                { "Empresa", ObjLayout.InicioEmpresa },
                { "Evento", ObjLayout.InicioEvento },
                { "Funcionario", ObjLayout.InicioFuncionario },
                { "Horas", ObjLayout.InicioHoras }
            }.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public static Dictionary<string, int> CalcularEspacosBrancos(Dictionary<string, int> OrdemLayout, Dictionary<string, int> TamanhoLayout)
        {
            int brancos1 = (OrdemLayout.Values.ElementAt(1) - TamanhoLayout[OrdemLayout.Keys.ElementAt(0)]) - 1;
            int brancos2 = (OrdemLayout.Values.ElementAt(2) -
                (TamanhoLayout[OrdemLayout.Keys.ElementAt(1)] + TamanhoLayout[OrdemLayout.Keys.ElementAt(0)] + brancos1)) - 1;
            int brancos3 = (OrdemLayout.Values.ElementAt(3) -
                (TamanhoLayout[OrdemLayout.Keys.ElementAt(2)] + TamanhoLayout[OrdemLayout.Keys.ElementAt(1)] +
                TamanhoLayout[OrdemLayout.Keys.ElementAt(0)] + brancos1 + brancos2)) - 1;
            return new Dictionary<string, int>()
                            {
                                {OrdemLayout.Keys.ElementAt(0), brancos1 },
                                {OrdemLayout.Keys.ElementAt(1), brancos2 },
                                {OrdemLayout.Keys.ElementAt(2), brancos3 }
                            };
        }
    }
}
