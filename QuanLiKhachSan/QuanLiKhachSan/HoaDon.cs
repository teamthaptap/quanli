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
using QuanLiKhachSan;

namespace WindowsFormsApplication1
{
    public partial class HoaDon : Form
    {

        string strCon = @"Data Source=LATITUDE-PC;Initial Catalog=QL_KhachSan;Integrated Security=True";
        public HoaDon()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            dgvHoaDon.DataSource = SqlHelper.ExecuteDataset(strCon, "HienThiHD").Tables[0];
        }
        private void HoaDon_Load(object sender, EventArgs e)
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
            DataGridViewRow r = dgvHoaDon.Rows[ind];
            txtMaHD.Text = r.Cells[0].Value.ToString();
            txtMaKH.Text = r.Cells[1].Value.ToString();
            txtNguoiLap.Text = r.Cells[2].Value.ToString();
            txtTongTien.Text = r.Cells[3].Value.ToString();
            dtTGM.Text = r.Cells[4].Value.ToString();
            dtTGT.Text = r.Cells[5].Value.ToString();
        }
        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maHD = txtMaHD.Text.Trim();
                string maKH = txtMaKH.Text.Trim();
                string nl = txtNguoiLap.Text.Trim();
                string tong = txtTongTien.Text.Trim();
                DateTime tgm = DateTime.Parse(dtTGM.Value.ToString());
                DateTime tgt = DateTime.Parse(dtTGT.Value.ToString());
                SqlHelper.ExecuteNonQuery(strCon, "Update_Hoadon", maHD, maKH, nl, tong, tgm, tgt);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rùi cưng!!");
            }
        }

        private void bttCapNhat_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maHD = txtMaHD.Text.Trim();
                string maKH = txtMaKH.Text.Trim();
                string nl = txtNguoiLap.Text.Trim();
                string tong = txtTongTien.Text.Trim();
                DateTime tgm = DateTime.Parse(dtTGM.Value.ToString());
                DateTime tgt = DateTime.Parse(dtTGT.Value.ToString());
                SqlHelper.ExecuteNonQuery(strCon, "Insert_Hoadon", maHD, maKH, nl, tong, tgm, tgt);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rùi cưng!!");
            }
        }

        private void dgvHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setValue(e.RowIndex);
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();
            string maKH = txtMaKH.Text.Trim();

            SqlHelper.ExecuteNonQuery(strCon, "Delete_Hoadon", maHD, maKH);
            loadData();
        }
    }
}
