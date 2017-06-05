using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using QLTV.Class;

namespace QLTV
{
    public partial class NguoidungControl : UserControl
    {
        public NguoidungControl()
        {
            InitializeComponent();
            Load += loaddgv;
        }
        private void loaddgv(object sender, EventArgs e)
        {
            loaddulieu();
            loadcbbLop();
        }
        private void loadcbbLop()
        {

            DataTable dtcvd;
            dtcvd = SqlHelper.ExecuteDataset(StrConnect.strConnect(), "loadmaLop").Tables[0];
            cbbMalop.DataSource = dtcvd;
            cbbMalop.DisplayMember = "MaLop";
            cbbMalop.ValueMember = "MaLop";
        }
        private void loaddulieu()
        {
            dgvHienthi.DataSource = SqlHelper.ExecuteDataset(QLTV.Class.StrConnect.strConnect(), "loadbandoc").Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                string ten = txtTen.Text.Trim();
                DateTime ngaysinh = DateTime.Parse(dtpNgaysinh.Value.ToString());
                string gioitinh = rdbNam.Text.Trim();
                if (rdbNam.Text == "Nam")
                {
                    rdbNam.Text = "Nam";
                    rdbNam.Checked = true;
                    rdbNu.Text = "Nữ";
                }
                else
                {
                    rdbNu.Text = "Nữ";
                    rdbNu.Checked = true;
                    rdbNam.Text = "Nam";
                }
                string CMND = txtCMND.Text.Trim();
                string lop = cbbMalop.SelectedValue.ToString();
                string diachi = txtDiachi.Text.Trim();
                string email = txtEmail.Text.Trim();
                string dt = txtDienthoai.Text.Trim();
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "addBD", ma, ten, gioitinh, ngaysinh, CMND, lop, diachi, email, dt);
                MessageBox.Show("Thêm thành công!");
                loaddulieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi!!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                string ten = txtTen.Text.Trim();
                DateTime ngaysinh = DateTime.Parse(dtpNgaysinh.Value.ToString());
                string gioitinh = rdbNam.Text.Trim();
                if (rdbNam.Text == "Nam")
                {
                    rdbNam.Text = "Nam";
                    rdbNam.Checked = true;
                    rdbNu.Text = "Nữ";
                }
                else
                {
                    rdbNu.Text = "Nữ";
                    rdbNu.Checked = true;
                    rdbNam.Text = "Nam";
                }
                string CMND = txtCMND.Text.Trim();
                string lop = cbbMalop.SelectedValue.ToString();
                string diachi = txtDiachi.Text.Trim();
                string email = txtEmail.Text.Trim();
                string dt = txtDienthoai.Text.Trim();
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "updateBD", ma, ten, gioitinh, ngaysinh, CMND, lop, diachi, email, dt);
                MessageBox.Show("Sửa thành công!");
                loaddulieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi!!!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                MessageBox.Show("Bạn xác nhận muốn xóa ???", "Thông báo", MessageBoxButtons.YesNoCancel);
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "delBD", ma);
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi!!!");
            }

        }

        private void dgvHienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bingdingGV();
        }
        private void bingdingGV()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvHienthi.DataSource, "MaBD");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvHienthi.DataSource, "HoTen");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dgvHienthi.DataSource, "CMND");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgvHienthi.DataSource, "DiaChi");
            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("Text", dgvHienthi.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvHienthi.DataSource, "Email");
            rdbNam.DataBindings.Clear();
            rdbNam.DataBindings.Add("Text", dgvHienthi.DataSource, "GioiTinh");
            if (rdbNam.Text == "Nam")
            {
                rdbNam.Text = "Nam";
                rdbNam.Checked = true;
                rdbNu.Text = "Nữ";
            }
            else
            {
                rdbNu.Text = "Nữ";
                rdbNu.Checked = true;
                rdbNam.Text = "Nam";
            }
            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("Text", dgvHienthi.DataSource, "NgaySinh");
            cbbMalop.DataBindings.Clear();
            cbbMalop.DataBindings.Add("Text", dgvHienthi.DataSource, "MaLop");
        }
    }
}
