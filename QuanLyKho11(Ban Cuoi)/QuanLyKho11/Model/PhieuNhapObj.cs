using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho11.Model
{
    class PhieuNhapObj
    {
        public string MaPN{ get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNCC { get; set; }
        public string MaKho { get; set; }
        public string TongTien { get; set; }

        public PhieuNhapObj() { }
        public PhieuNhapObj(string MaPN, DateTime NgayNhap, string MaNCC, string MaKho,string TongTien)
        {
            this.MaPN = MaPN;
            this.NgayNhap = NgayNhap;
            this.MaNCC = MaNCC;
            this.MaKho = MaKho;
            this.TongTien = TongTien;
        }
    }
}
