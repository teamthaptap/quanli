namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNguoiDung { get; set; }

        [StringLength(50)]
        public string TenNguoiDung { get; set; }

        public int? MaLoaiTK { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        public bool? GioiTinh { get; set; }

        public virtual LoaiNguoiDung LoaiNguoiDung { get; set; }
    }
}
