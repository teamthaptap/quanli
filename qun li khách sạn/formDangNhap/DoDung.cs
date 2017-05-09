using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formDangNhap
{
    public partial class DoDung : Form
    {
        string strConnect = @"Data Source = PHAMTUNG\SQLEXPRESS;Initial Catalog = QL_KhachSan; Integrated Security = True";

        public DoDung()
        {
            InitializeComponent();
            Load += DodungLoad;
        }

        private void DodungLoad(object sender, EventArgs e)
        {
            LoadDodung();
        }

        private void LoadDodung()
        {
            dgvHienThi.DataSource = SqlHelper.ExecuteDataset(strConnect, "Load_Dodung").Tables[0];
;        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMadd.Text.Trim();
                string ten = txtTendd.Text.Trim();
                string gia = txtGiamua.Text.Trim();
                string DVT = txtDVT.Text.Trim();
                string SL = txtSoluong.Text.Trim();
                SqlHelper.ExecuteNonQuery(strConnect, "Insert_Dodung", ma, ten, SL, DVT, gia);
                MessageBox.Show("Thêm thành công", "THông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            fm.Show();
            this.Hide();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadDodung();
        }
    }
}
