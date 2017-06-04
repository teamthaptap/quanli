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
    public partial class Phong : Form
    {
        string strCon = @"Data Source=JOJO-PC\SQLEXPRESS;Initial Catalog=QL_KhachSan;Integrated Security=True";
        public Phong()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvPhong.DataSource = SqlHelper.ExecuteDataset(strCon, "HienThiP").Tables[0];
        }
        private void Phong_Load(object sender, EventArgs e)
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
            DataGridViewRow r = dgvPhong.Rows[ind];
            txtMaPhong.Text = r.Cells[0].Value.ToString();
            txtTen.Text = r.Cells[1].Value.ToString();
            txtLoai.Text = r.Cells[2].Value.ToString();
            txtTinhTrang.Text = r.Cells[3].Value.ToString();
            txtGia.Text = r.Cells[4].Value.ToString();
        }
        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaPhong.Text.Trim();
                string ten = txtTen.Text.Trim();
                string loai = txtLoai.Text.Trim();
                string gia = txtGia.Text.Trim();
                string tt = txtTinhTrang.Text.Trim();
                SqlHelper.ExecuteNonQuery(strCon, "Insert_Phong", ma, ten, loai,tt, gia);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rùi cưng!!");
            }
        }

        private void dgvPhong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setValue(e.RowIndex);
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaPhong.Text.Trim();
                string ten = txtTen.Text.Trim();
                string loai = txtLoai.Text.Trim();
                string gia = txtGia.Text.Trim();
                string tt = txtTinhTrang.Text.Trim();
                SqlHelper.ExecuteNonQuery(strCon, "Update_Phong", ma, ten, loai, tt, gia);
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
                string ma = txtMaPhong.Text.Trim();
               
                SqlHelper.ExecuteNonQuery(strCon, "Delete_Phong", ma);
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rùi cưng!!");
            }
        }
    }
}

