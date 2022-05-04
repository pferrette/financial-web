namespace Financial_Web.Models
{
    public class Pendente
    {
        public int PendenteId { get; set; }
        public string? Nome { get; set; }
        public decimal ValorPagoAtual { get; set; }
        public decimal Restante { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataPagemento { get; set; }
        public DateTime DataInicio { get; set; }
    }
}
