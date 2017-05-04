using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class FormDangnhap : Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }

        private void FormDangnhap_Load(object sender, EventArgs e)
        {
            txtMatkhau.PasswordChar = '*';
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            FormMenu frommenu = new FormMenu();
            //if (txtMatkhau.Text == "phong" && txtTendangnhap.Text == "admin")
            //{
            //    this.Hide();
            //    frommenu.Closed += (s, args) => this.Close();
            //    frommenu.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng", "Đăng Nhập Thất Bại", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            //}
            this.Hide();
            frommenu.Closed += (s, args) => this.Close();
            frommenu.ShowDialog();
        }

        private void btnQuenmatkhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mật Khẩu Của Bạn Là : phong");
        }
    }
}
