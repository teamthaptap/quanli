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
    public partial class frmPhieuNhap : Form
    {
        public SendMessage send;

        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        public frmPhieuNhap(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }
        PhieuNhapCtl pnctl = new PhieuNhapCtl();
        PhieuNhapObj pnobj = new PhieuNhapObj();
        int flag = 0;
     
      
        
       
       
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            
        }
      
      

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            string MaPN = txtMaPN.Text.Trim();
            frmChiTietPhieuNhap ds = new frmChiTietPhieuNhap();
            this.Hide();
            ds.Show();

        }
       

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

            frmMain ds = new frmMain();
            this.Hide();
            ds.Show();
        }
    }
}
