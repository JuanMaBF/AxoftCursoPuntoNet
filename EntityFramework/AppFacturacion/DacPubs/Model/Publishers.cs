using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DacPubs.Model
{
    public class Publishers
    {
        [Key]
        [Column(TypeName = "Char")]
        [MaxLength(4)]
        public string pub_id { get; set; }

        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(40)]
        public string pub_name { get; set; }

        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        public string city { get; set; }

        [Required]
        [Column(TypeName = "Char")]
        [MaxLength(2)]
        public string state { get; set; }

        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(30)]
        public string country { get; set; }
    }
}
