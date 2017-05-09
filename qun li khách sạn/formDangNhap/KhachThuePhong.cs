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
namespace formDangNhap
{
    public partial class KhachThuePhong : Form
    {
        string strConnect = @"Data Source =LATITUDE-PC;Initial Catalog = QL_KhachSan; Integrated Security = True";
        public KhachThuePhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemKhachThuePhong tktp = new ThemKhachThuePhong();
            this.Hide();
            tktp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            this.Hide();
            fm.Show();
        }
        public void LoadData()
        {
            dgvHienThi.DataSource = SqlHelper.ExecuteDataset(strConnect,"HienThiKTP").Tables[0];
        }
        private void KhachThuePhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
