namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [Display(Name = "Mã sách")]
        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(500)]
        [Display(Name = "Tên sách")]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Miêu tả")]
        public string Detail { get; set; }
        [Display(Name = "Giá")]
        public long? Price { get; set; }

        [StringLength(300)]
        [Display(Name = "Ảnh")]
        public string ImageCover { get; set; }
        [Display(Name = "Giá mới")]
        public long? PriceNew { get; set; }
        [Display(Name = "Số lượng")]
        public int? Status { get; set; }
        
        [StringLength(10)]
        [Display(Name = "Mã Thể loại")]
        public string GroupBook_Id { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã Tác giả")]
        public string Auth_Id { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã Dịch giả")]
        public string Translator_Id { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày xuất bản")]
        public DateTime? IssueDate { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã NXB")]
        public string Publisher_Id { get; set; }

        public int? Order { get; set; }

        public virtual Auth Auth { get; set; }

        public virtual GroupBook GroupBook { get; set; }

        public virtual Publisher Publisher { get; set; }

        public virtual Translator Translator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
