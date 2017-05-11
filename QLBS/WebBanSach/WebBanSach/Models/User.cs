namespace WebBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "Tài khoản")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Display(Name = "Mật khẩu")]
        public string PassWord { get; set; }

        [StringLength(300)]
        [Display(Name = "Họ Tên")]
        public string Name { get; set; }

        [StringLength(10)]
        [Display(Name = "Số điện thoại")]
        public string Tel { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã Thành phố")]
        public string Province_Id { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [StringLength(100)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public bool? Ruless { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày sinh")]
        public DateTime? DateOfBirth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        public virtual Province Province { get; set; }
    }
}
