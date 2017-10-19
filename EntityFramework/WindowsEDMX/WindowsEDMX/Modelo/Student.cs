using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEDMX.Modelo
{
    public class Student
    {
        [Key]
        public int SId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Name", TypeName = "Varchar")]
        public string StudentName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public byte[] Photo { get; set; }

        public decimal Height { get; set; }

        public float Weight { get; set; }

        [NotMapped]
        public int? Age { get; set; }

        public int StdId { get; set; }

        [ForeignKey("StdId")]
        public Standar Standar { get; set; }
    }
}
