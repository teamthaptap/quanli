using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho11.Model
{
    class HangHoaObj
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string DonViTinh { get; set; }
        public string Ton { get; set; }

        public HangHoaObj() { }
        public HangHoaObj(string MaHang, string TenHang, string DonViTinh, string Ton)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.DonViTinh = DonViTinh;
            this.Ton = Ton;
        }
    }
}
