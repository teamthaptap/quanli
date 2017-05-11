namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Company { get; set; }

        [Column(TypeName = "ntext")]
        public string Address { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        [StringLength(300)]
        public string Email { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }
    }
}
