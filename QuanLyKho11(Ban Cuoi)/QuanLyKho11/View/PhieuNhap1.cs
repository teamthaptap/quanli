using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho11.Controller;
using QuanLyKho11.Model;

namespace QuanLyKho11.Model
{
    public partial class PhieuNhap1 : Form
    {
        public PhieuNhap1()
        {
            InitializeComponent();
        }
        PhieuNhapCtl pnctl = new PhieuNhapCtl();
        PhieuNhapObj pnobj = new PhieuNhapObj();
        ChiTietPhieuNhapCtl ctctl = new ChiTietPhieuNhapCtl();
        ChiTietPhieuNhapObj ctobj = new ChiTietPhieuNhapObj();
        int flag = 0;
        
        private void PhieuNhap1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
           
        }

        private void txtMaPN_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtThanhTien_MouseClick(object sender, MouseEventArgs e)
        {
            txtThanhTien.Text = (Int32.Parse(txtDonGia.Text) * Int32.Parse(txtSLThuc.Text)).ToString();
        }
    }
}
