using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financial_Web.Models
{
    public class Gasto
    {
        public int GastoId { get; set; }
        public string Nome { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        public int ParcelaAtual { get; set; }
        public int TotalParcelas { get; set; }
        public string FormaDePagamento { get; set; }
        [StringLength(50)]
        public string Tipo { get; set; }
        public DateTime DataPagemento { get; set; }
        public DateTime DataInclusão { get; set; }
    }
}
