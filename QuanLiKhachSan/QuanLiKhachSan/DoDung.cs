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
    public partial class DoDung : Form
    {
        string strCon = @"Data Source=LATITUDE-PC;Initial Catalog=QL_KhachSan;Integrated Security=True";
        public DoDung()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvDoDung.DataSource = SqlHelper.ExecuteDataset(strCon, "Load_Dodung").Tables[0];
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            Hide();
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                string ten = txtTen.Text.Trim();
                string sl = txtSoLuong.Text.Trim();
                string gia = txtGiaMua.Text.Trim();
                string dvt = txtDVT.Text.Trim();
                SqlHelper.ExecuteNonQuery(strCon, "Insert_Dodung", ma, ten, sl, dvt, gia);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rùi cưng!!");
            }

        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                string ten = txtTen.Text.Trim();
                string sl = txtSoLuong.Text.Trim();
                string gia = txtGiaMua.Text.Trim();
                string dvt = txtDVT.Text.Trim();
                SqlHelper.ExecuteNonQuery(strCon, "Update_Dodung", ma, ten, sl, dvt, gia);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rùi cưng!!");
            }

        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                SqlHelper.ExecuteNonQuery(strCon, "Delete_Dodung", ma);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rùi cưng!!");
            }

        }

        private void dgvDoDung_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setValue(e.RowIndex);
        }
    }
}
