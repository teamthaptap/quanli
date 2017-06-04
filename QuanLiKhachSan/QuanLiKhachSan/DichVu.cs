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
    public partial class DichVu : Form
    {
        string strCon = @"Data Source=LATITUDE-PC;Initial Catalog=QL_KhachSan;Integrated Security=True";
        public DichVu()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvDichVu.DataSource = SqlHelper.ExecuteDataset(strCon, "Load_Dichvu").Tables[0];
        }
        private void DichVu_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            Hide();
        }
        private void setValue(int ind)
        {
            DataGridViewRow row = dgvDichVu.Rows[ind];
            txtMaDV.Text = row.Cells[0].Value.ToString();
            txtTenDV.Text = row.Cells[1].Value.ToString();
            txtGia.Text = row.Cells[2].Value.ToString();
            txtDVT.Text = row.Cells[3].Value.ToString();

        }
        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maDV = txtMaDV.Text.Trim();
                string ten = txtTenDV.Text.Trim();
                string gia = txtGia.Text.Trim();
                string dvt = txtDVT.Text.Trim();
                SqlHelper.ExecuteNonQuery(strCon, "Insert_Dichvu", maDV, ten, gia, dvt);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("bị lỗi rùi cưng !!");
            }
        }

        private void dgvDichVu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setValue(e.RowIndex);
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maDV = txtMaDV.Text.Trim();
                string ten = txtTenDV.Text.Trim();
                string gia = txtGia.Text.Trim();
                string dvt = txtDVT.Text.Trim();
                SqlHelper.ExecuteNonQuery(strCon, "Update_Dichvu", maDV, ten, gia, dvt);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("bị lỗi rùi cưng !!");
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaDV.Text.Trim();

                SqlHelper.ExecuteNonQuery(strCon, "Delete_dichvu", ma);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("bị lỗi rùi cưng !!");
            }
        }

        private void bttCapNhat_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
