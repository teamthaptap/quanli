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

namespace QuanLyKho11.View
{
    public delegate void SendMessage(string value);
    public partial class frmChiTietPhieuXuat : Form
    {
        public frmChiTietPhieuXuat()
        {
            InitializeComponent();
        }
        public frmChiTietPhieuXuat(string str)
        {
            InitializeComponent();
            txtMaPX.Text = str;
        }
        ChiTietPhieuXuatCtl ctctl = new ChiTietPhieuXuatCtl();
        ChiTietPhieuXuatObj ctobj = new ChiTietPhieuXuatObj();
        PhieuXuatCtl pnctl = new PhieuXuatCtl();
        PhieuXuatObj pnobj = new PhieuXuatObj();
        int flag = 0;

     
        private void Clear()
        {
           


        }
       

      
        private void frmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtMaPX_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {

          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

          
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            frmPhieuXuat ds = new frmPhieuXuat();
            this.Hide();
            ds.Show();
        }
    }
}
