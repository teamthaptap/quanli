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
namespace WindowsFormsApplication1
{
    public partial class DoDungTrongPhong : Form
    {
        string strCon = @"Data Source=LATITUDE-PC;Initial Catalog=QL_KhachSan;Integrated Security=True";
        public DoDungTrongPhong()
        {
            InitializeComponent();
            Load += Dodungtrongphong;
        }

        public void loadData()
        {
            dgvDDTP.DataSource = SqlHelper.ExecuteDataset(strCon, "Load_Ddtp").Tables[0];
        }
        private void DoDungTrongPhong_Load(object sender, EventArgs e)
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
            DataGridViewRow r = dgvDDTP.Rows[ind];
            cmbMaDD.Text = r.Cells[0].Value.ToString();
            txtSoLuong.Text = r.Cells[1].Value.ToString();
            cmbDVT.Text = r.Cells[2].Value.ToString();
            txtTinhTrang.Text = r.Cells[3].Value.ToString();
            cmbMaPhong.Text = r.Cells[4].Value.ToString();
        }
        private void Dodungtrongphong(object sender, EventArgs e)
        {
            loadCBBMaPhong();
            loadData();
            loadCBBMaDodung();
        }

        public void loadCBBMaPhong()
        {
            DataTable dthv;
            dthv = SqlHelper.ExecuteDataset(strCon, "Load_MaPhong").Tables[0];
            cmbMaPhong.DataSource = dthv;
            cmbMaPhong.DisplayMember = "MaPhong";
            cmbMaPhong.ValueMember = "MaPhong";
        }
        public void loadCBBMaDodung()
        {
            DataTable dtdd;
            dtdd = SqlHelper.ExecuteDataset(strCon, "Load_MaDodung").Tables[0];
            cmbMaDD.DataSource = dtdd;
            cmbMaDD.DisplayMember = "MaDD";
            cmbMaDD.ValueMember = "MaDD";
        }
        private void bttThem_Click(object sender, EventArgs e)
        {

            try
            {
                string ma = cmbMaDD.SelectedValue.ToString();
                string tinhtrang = txtTinhTrang.Text.Trim();
                string maphong = cmbMaPhong.SelectedValue.ToString();
                string DVT = cmbDVT.SelectedValue.ToString();
                string SL = txtSoLuong.Text.Trim();
                SqlHelper.ExecuteNonQuery(strCon, "Insert_Ddtp", ma, SL, DVT, tinhtrang, maphong);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Lỗi");
            }
        }

        private void cmbMaDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtdd;
            string ma = cmbMaDD.SelectedValue.ToString();
            dtdd = SqlHelper.ExecuteDataset(strCon, "Load_DVTDD", ma).Tables[0];
            cmbDVT.DataSource = dtdd;
            cmbDVT.ValueMember = "DonViTinh";
            cmbDVT.DisplayMember = "DonViTinh";
        }

        private void dgvDDTP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setValue(e.RowIndex);
        }

        private void bttCapNhat_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = cmbMaDD.SelectedValue.ToString();
                string tinhtrang = txtTinhTrang.Text.Trim();
                string maphong = cmbMaPhong.SelectedValue.ToString();
                string DVT = cmbDVT.SelectedValue.ToString();
                string SL = txtSoLuong.Text.Trim();
                SqlHelper.ExecuteNonQuery(strCon, "Update_Ddtp", ma, SL, DVT, tinhtrang, maphong);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Lỗi");
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            string ma = cmbMaDD.SelectedValue.ToString();

            SqlHelper.ExecuteNonQuery(strCon, "Delete_Ddtp", ma);
            loadData();
        }
    }
}
