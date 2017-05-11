namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Order_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Book_Id { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        public virtual Book Book { get; set; }

        public virtual Order Order { get; set; }
    }
}
