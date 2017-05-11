namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(10)]
        public string Book_Id { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        public int User_Id { get; set; }

        public virtual User User { get; set; }
    }
}
