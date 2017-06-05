using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho11.Controller;
using QuanLyKho11.Model;

namespace QuanLyKho11.View
{
    public partial class frmHangHoa : Form
    {
        HangHoaCtl hhctl = new HangHoaCtl();
        HangHoaObj hhobj = new HangHoaObj();
        int flag = 0;
        public frmHangHoa()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            txtMaHang.Text = dgvHangHoa.CurrentRow.Cells["MaHang"].Value.ToString();
            txtTenHang.Text = dgvHangHoa.CurrentRow.Cells[1].Value.ToString();
            txtDonViTinh.Text = dgvHangHoa.CurrentRow.Cells[2].Value.ToString();
            txtTon.Text = dgvHangHoa.CurrentRow.Cells[3].Value.ToString();
        }
        public void dis_en(bool e)
        {
            txtMaHang.Enabled = e;
            txtTenHang.Enabled = e;
            txtDonViTinh.Enabled = e;
            txtTon.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        private void clean()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtDonViTinh.Clear();
            // cbbMaNV.Clear();
            txtTon.Clear();

        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = hhctl.GetData();
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dis_en(false);
            LoadData();
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    txtMaHang.Text = dgvHangHoa.CurrentRow.Cells[0].Value.ToString();
                    txtTenHang.Text = dgvHangHoa.CurrentRow.Cells[1].Value.ToString();
                    txtDonViTinh.Text = dgvHangHoa.CurrentRow.Cells[2].Value.ToString();
                    txtTon.Text = dgvHangHoa.CurrentRow.Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void GanDuLieu(HangHoaObj hh1obj)
        {
            hh1obj.MaHang = txtMaHang.Text.ToString().Trim();
            hh1obj.TenHang = txtTenHang.Text.ToString().Trim();
            hh1obj.DonViTinh = txtDonViTinh.Text.ToString().Trim();
            hh1obj.Ton = txtTon.Text.ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clean();
            dis_en(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    if (hhctl.DelHangHoa(txtMaHang.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmHangHoa_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóakhông thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(hhobj);
            if (flag == 0)   // thêm
            {
                if (hhctl.AddHangHoa(hhobj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmHangHoa_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            // sửa
            {
                if (hhctl.UpdateHangHoa(hhobj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmHangHoa_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmHangHoa_Load(sender, e);
            dis_en(false);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }
    }
}
