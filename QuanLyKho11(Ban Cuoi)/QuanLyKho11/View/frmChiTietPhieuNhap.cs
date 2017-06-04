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
    //public delegate void SendMessage(string value);
    public partial class frmChiTietPhieuNhap : Form
    {
        
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        public frmChiTietPhieuNhap(string str)
        {
            InitializeComponent();
            txtMaPN.Text = str;
        }

     
      



        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
           
        }
        

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtMaPN_TextChanged(object sender, EventArgs e)
        {
         
        }
        public void Load_cbbMaHang()
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
            frmPhieuNhap ds = new frmPhieuNhap();
            this.Hide();
            ds.Show();
        }
    }
}
