using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho11.Model
{
    class PhieuXuatObj
    {
        public string MaPX { get; set; }
        public DateTime NgayXuat { get; set; }
        public string MaKH { get; set; }
        public string TongTien { get; set; }
        public string MaKho { get; set; }

        public PhieuXuatObj() { }
        public PhieuXuatObj(string MaPX, DateTime NgayXuat, string MaKH, string TongTien, string MaKho)
        {
            this.MaPX = MaPX;
            this.NgayXuat = NgayXuat;
            this.MaKH = MaKH;
            this.TongTien = TongTien;
            this.MaKho = MaKho;
        }
    }
}
