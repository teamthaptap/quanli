using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho11.Model
{
    class KhoObj
    {
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string ThuKho { get; set; }

        public KhoObj() { }
        public KhoObj(string MaKho, string TenKho, string SDT, string DiaChi, string ThuKho)
        {
            this.MaKho = MaKho;
            this.TenKho = TenKho;
            this.SDT = SDT;
            this.DiaChi = DiaChi;
            this.ThuKho = ThuKho;
        }
    }
}
