using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho11.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKho frm = new frmKho();
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frm = new frmPhieuNhap();
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuXuat frm = new frmPhieuXuat();
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void hàngTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn thoát !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
