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
    public partial class frmKho : Form
    {
        KhoCtl khoctl = new KhoCtl();
        KhoObj khoobj = new KhoObj();
        int flag = 0;
        public frmKho()
        {
           
            InitializeComponent();
        }
       

        private void frmKho_Load(object sender, EventArgs e)
        {
         
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }
    }
}
