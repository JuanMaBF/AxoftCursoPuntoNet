using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DacPubs.Model
{
    public class Titles
    {
        [Key]
        [Column(TypeName = "Tid")]
        [MaxLength(6)]
        public string title_id { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(90)]
        [Required]
        public string title { get; set; }

        [Column(TypeName = "Char")]
        [MaxLength(12)]
        [Required]
        public string type { get; set; }

        [Column(TypeName = "Char")]
        [MaxLength(4)]
        public string pub_id { get; set; }

        [ForeignKey("pub_id")]
        public Publishers Publishers { get; set; }

        [Column(TypeName = "Money")]
        public long? price { get; set; }

        [Column(TypeName = "Money")]
        public long? advance { get; set; }

        public int? royalty { get; set; }

        public int? ytd_sales { get; set; }

        [MaxLength(200)]
        [Column(TypeName = "Money")]
        public string notes { get; set; }

        [Required]
        public DateTime pubdate { get; set; }

        /*
        royalty
ytd_sales
notes
pubdate
        
        */
    }
}
