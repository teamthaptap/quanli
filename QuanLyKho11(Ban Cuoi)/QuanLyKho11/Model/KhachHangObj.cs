using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho11.Model
{
    class KhachHangObj
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public KhachHangObj() { }
        public KhachHangObj(string MaKH, string TenKH, string SDT, string DiaChi)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.SDT = SDT;
            this.DiaChi = DiaChi;
        }
    }
}
