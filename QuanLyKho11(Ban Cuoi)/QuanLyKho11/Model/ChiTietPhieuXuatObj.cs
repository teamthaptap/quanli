using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho11.Model
{
    class ChiTietPhieuXuatObj
    {
        string MaPX, MaHang, DonGia, SLThuc, ThanhTien;

        public string DonGia1
        {
            get
            {
                return DonGia;
            }

            set
            {
                DonGia = value;
            }
        }

        public string MaPX1
        {
            get
            {
                return MaPX;
            }

            set
            {
                MaPX = value;
            }
        }

        public string MaHang1
        {
            get
            {
                return MaHang;
            }

            set
            {
                MaHang = value;
            }
        }

        public string SLThuc1
        {
            get
            {
                return SLThuc;
            }

            set
            {
                SLThuc = value;
            }
        }

        public string ThanhTien1
        {
            get
            {
                return ThanhTien;
            }

            set
            {
                ThanhTien = value;
            }
        }

        public ChiTietPhieuXuatObj() { }
        public ChiTietPhieuXuatObj(string MaPX, string MaHang, string DonGia, string SLThuc, string ThanhTien)
        {
            this.MaPX = MaPX;
            this.MaHang = MaHang;
            this.DonGia = DonGia;
            this.SLThuc = SLThuc;
            this.ThanhTien = ThanhTien;
        }
    }
}
