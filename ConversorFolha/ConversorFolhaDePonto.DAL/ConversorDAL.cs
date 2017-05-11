using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorFolhaDePonto.DAL
{
    public class ConversorDAL
    {
        public void GerarArquivo(List<string> LArquivoConvertido, string strDiretorio)
        {
            if (LArquivoConvertido.Count == 0) throw new Exception("Arquivo Inválido.");
            File.WriteAllLines(strDiretorio, LArquivoConvertido, Encoding.Default);
        }
    }
}
