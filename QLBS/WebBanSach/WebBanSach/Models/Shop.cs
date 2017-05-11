namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shop")]
    public partial class Shop
    {
        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        [StringLength(10)]
        public string Province_Id { get; set; }

        public virtual Province Province { get; set; }
    }
}
