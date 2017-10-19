namespace DacPubs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class titles
    {
        [Key]
        [StringLength(6)]
        public string title_id { get; set; }

        [Required]
        [StringLength(80)]
        public string title { get; set; }

        [Required]
        [StringLength(12)]
        public string type { get; set; }

        [StringLength(4)]
        public string pub_id { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        [Column(TypeName = "money")]
        public decimal? advance { get; set; }

        public int? royalty { get; set; }

        public int? ytd_sales { get; set; }

        [StringLength(200)]
        [Column(TypeName = "Varchar")]
        public string notes { get; set; }

        [Required]
        public DateTime pubdate { get; set; }
    }
}
