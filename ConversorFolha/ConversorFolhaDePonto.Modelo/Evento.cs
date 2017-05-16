namespace ConversorFolhaDePonto.Modelo
{
    public class Evento
    {
        public string Externo { get; set; }
        public string IdEmpresa { get; set; }
        public string Interno { get; set; }
        public bool Transferivel { get; set; }
        public string NomeEmpresa { get; set; }
        public bool Inativos { get; set;}
    }
}
