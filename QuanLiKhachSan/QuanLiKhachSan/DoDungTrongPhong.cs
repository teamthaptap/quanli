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
    public partial class DoDungTrongPhong : Form
    {
        string strCon = @"Data Source=LATITUDE-PC;Initial Catalog=QL_KhachSan;Integrated Security=True";
        public DoDungTrongPhong()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            dgvDDTP.DataSource = SqlHelper.ExecuteDataset(strCon, "Load_Ddtp").Tables[0];
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            Hide();
        }
    }
}
