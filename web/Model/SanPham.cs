namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        public int MaSanPham { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        [StringLength(50)]
        public string GiaCu { get; set; }

        [StringLength(50)]
        public string GiaMoi { get; set; }

        [StringLength(100)]
        public string BaoHanh { get; set; }

        [StringLength(200)]
        public string AnhSP { get; set; }

        public int IdDanhMuc { get; set; }

        public int IdHangSP { get; set; }

        [StringLength(50)]
        public string MauSac { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        public virtual HangSP HangSP { get; set; }
    }
}
