using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;

namespace QuanLiKhachSan
{
    public partial class DangNhap : Form
    {
        string strCon = @"Data Source=LATITUDE-PC;Initial Catalog=QL_KhachSan;Integrated Security=True";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void bttQuenMK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            DataTable dt = SqlHelper.ExecuteDataset(strCon, "DangNhap", user, pass).Tables[0];
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                FormMain frm = new FormMain();
                frm.Show();
                Hide();
            }
            else MessageBox.Show("Lỗi  !!!");
        }
    }
}
