namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sale")]
    public partial class Sale
    {
        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        [StringLength(500)]
        public string Promotion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public virtual SalesDetail SalesDetail { get; set; }
    }
}
