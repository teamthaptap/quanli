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
    public partial class frmNhaCungCap : Form
    {
        NhaCungCapCtl nccctl = new NhaCungCapCtl();
        NhaCungCapObj nccobj = new NhaCungCapObj();
        int flag = 0;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            txtMaNCC.Text = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaCungCap.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvNhaCungCap.CurrentRow.Cells[3].Value.ToString();
        }
        public void dis_en(bool e)
        {
            txtMaNCC.Enabled = e;
            txtTenNCC.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        private void clean()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            // cbbMaNV.Clear();
            txtSDT.Clear();

        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCungCap.DataSource = nccctl.GetData();
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dis_en(false);
            LoadData();
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    txtMaNCC.Text = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
                    txtTenNCC.Text = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
                    txtDiaChi.Text = dgvNhaCungCap.CurrentRow.Cells[2].Value.ToString();
                    txtSDT.Text = dgvNhaCungCap.CurrentRow.Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void GanDuLieu(NhaCungCapObj ncc1obj)
        {
            ncc1obj.MaNCC = txtMaNCC.Text.ToString().Trim();
            ncc1obj.TenNCC = txtTenNCC.Text.ToString().Trim();
            ncc1obj.DiaChi = txtDiaChi.Text.ToString().Trim();
            ncc1obj.SDT = txtSDT.Text.ToString().Trim();
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
                    if (nccctl.DelNhaCungCap(txtMaNCC.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmNhaCungCap_Load(sender, e);
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
            GanDuLieu(nccobj);
            if (flag == 0)   // thêm
            {
                if (nccctl.AddNhaCungCap(nccobj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNhaCungCap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            // sửa
            {
                if (nccctl.UpdateNhaCungCap(nccobj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNhaCungCap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhaCungCap_Load(sender, e);
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
