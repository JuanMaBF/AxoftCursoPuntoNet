using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppFacturacion.Model
{
    public class Detalle
    {

        [Key]
        public int Det_ID { get; set; }

        public int Fact_ID { get; set; }

        [ForeignKey("Fact_ID")]
        public Factura Factura { get; set; }

        [Required]
        public int Precio { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
