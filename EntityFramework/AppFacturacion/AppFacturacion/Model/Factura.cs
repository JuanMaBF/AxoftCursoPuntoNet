using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppFacturacion.Model
{
    public class Factura
    {
        [Key]
        public string Fact_ID { get; set; }
        
        public int Cli_ID { get; set; }

        [ForeignKey("Cli_ID")]
        public Cliente cliente { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IVA { get; set; }
    }
}
