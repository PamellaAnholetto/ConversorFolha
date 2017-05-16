namespace ConversorFolhaDePonto.Modelo
{
    public class Empresa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int InicioEvento { get; set; }
        public int TamanhoEvento { get; set; }
        public int InicioFuncionario { get; set; }
        public int TamanhoFuncionario { get; set; }
        public int InicioHoras { get; set; }
        public int TamanhoHoras { get; set; }
        public bool Inativos { get; set; }
    }
}
