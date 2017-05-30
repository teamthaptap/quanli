namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        public int MaHD { get; set; }

        public DateTime NgayDatHang { get; set; }

        public DateTime NgayGiaoHang { get; set; }

        public int TrangThai { get; set; }

        [StringLength(50)]
        public string NguoiNhan { get; set; }

        [StringLength(50)]
        public string DiaChiNhan { get; set; }

        [StringLength(50)]
        public string SDTNguoiNhan { get; set; }

        public int? MaNguoiDung { get; set; }
    }
}
