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
    public partial class frmPhieuXuat : Form
    {
        public SendMessage send;
        public frmPhieuXuat()
        {
            InitializeComponent();
        }
        public frmPhieuXuat(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }
        PhieuXuatCtl pnctl = new PhieuXuatCtl();
        PhieuXuatObj pnobj = new PhieuXuatObj();
        ChiTietPhieuXuatCtl ctctl = new ChiTietPhieuXuatCtl();
        ChiTietPhieuXuatObj ctobj = new ChiTietPhieuXuatObj();
        int flag = 0;
      


      
       
        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
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
            
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

            frmMain ds = new frmMain();
            this.Hide();
            ds.Show();
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
          
        }
        private void txtMaPX_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void btnTroLai_Click(object sender, EventArgs e)
        {
            
        }

        private void txtThanhTien_MouseClick(object sender, MouseEventArgs e)
        {
            txtThanhTien.Text = (Int32.Parse(txtDonGia.Text) * Int32.Parse(txtSLThuc.Text)).ToString();

        }

        private void dgvPhieuXuat_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //dgvChiTiet.Rows[e.RowIndex].Cells["ThanhTien"].Value =  dgvChiTiet.Rows[e.RowIndex].Cells["ThanhTien"].Value;
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {

        }
    }
}