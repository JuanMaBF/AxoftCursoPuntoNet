using System.ComponentModel.DataAnnotations;

namespace AppFacturacion.Model
{
    public class Cliente
    {
        [Key]
        public int Cli_ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public string Email { get; set; }
        [Required]
        public int DNI { get; set; }
    }
}
