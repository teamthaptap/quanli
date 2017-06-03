using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachThuePhong frm = new KhachThuePhong();
            frm.Show();
            Hide();
        }

        private void đồDùngTrongPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong frm = new Phong();
            frm.Show();
            Hide();
        }

        private void đồDùngTrongPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoDungTrongPhong frm = new DoDungTrongPhong();
            frm.Show();
            Hide();
        }

        private void đồDùngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoDung frm = new DoDung();
            frm.Show();
            Hide();
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon frm = new HoaDon();
            frm.Show();
            Hide();
        }

        private void thôngTinDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DichVu frm = new DichVu();
            frm.Show();
            Hide();
        }

        private void hỗTrợToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HoTro frm = new HoTro();
            frm.Show();
            Hide();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
