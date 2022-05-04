using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financial_Web.Models
{
    public class Ganho
    {
        public int GanhoId { get; set; }
        [StringLength(50)]
        public string? Nome { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        public DateTime DataRecebido { get; set; }

    }
}
