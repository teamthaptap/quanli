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
    public partial class HoaDon : Form
    {
        string strCon = @"Data Source=LATITUDE-PC;Initial Catalog=QL_KhachSan;Integrated Security=True";
        public HoaDon()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvHoaDon.DataSource = SqlHelper.ExecuteDataset(strCon, "HienThiHD").Tables[0];
        }
        private void bttThoat_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            Hide();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
