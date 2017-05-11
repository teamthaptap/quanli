namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesDetail")]
    public partial class SalesDetail
    {
        [Key]
        [StringLength(10)]
        public string Sales_Id { get; set; }

        [StringLength(10)]
        public string Book_Id { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
