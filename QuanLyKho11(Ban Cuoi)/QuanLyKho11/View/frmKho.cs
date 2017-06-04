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
    public partial class frmKho : Form
    {
        KhoCtl khoctl = new KhoCtl();
        KhoObj khoobj = new KhoObj();
        int flag = 0;
        public frmKho()
        {
           
            InitializeComponent();
        }
        public void LoadData()
        {
            txtMaKho.Text = dgvKho.CurrentRow.Cells["MaKho"].Value.ToString();
            txtTenKho.Text = dgvKho.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKho.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvKho.CurrentRow.Cells[3].Value.ToString();
            txtThuKho.Text = dgvKho.CurrentRow.Cells[4].Value.ToString();
        }
        public void dis_en(bool e)
        {
            txtMaKho.Enabled = e;
            txtTenKho.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            txtThuKho.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        private void clean()
        {
            txtMaKho.Clear();
            txtTenKho.Clear();
            txtDiaChi.Clear();
            // cbbMaNV.Clear();
            txtSDT.Clear();
            txtThuKho.Clear();

        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            dgvKho.DataSource = khoctl.GetData();
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dis_en(false);
            LoadData();
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    txtMaKho.Text = dgvKho.CurrentRow.Cells[0].Value.ToString();
                    txtTenKho.Text = dgvKho.CurrentRow.Cells[1].Value.ToString();
                    txtDiaChi.Text = dgvKho.CurrentRow.Cells[2].Value.ToString();
                    txtSDT.Text = dgvKho.CurrentRow.Cells[3].Value.ToString();
                    txtThuKho.Text = dgvKho.CurrentRow.Cells[4].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void GanDuLieu(KhoObj kho1obj)
        {
            kho1obj.MaKho = txtMaKho.Text.ToString().Trim();
            kho1obj.TenKho = txtTenKho.Text.ToString().Trim();
            kho1obj.DiaChi = txtDiaChi.Text.ToString().Trim();
            kho1obj.SDT = txtSDT.Text.ToString().Trim();
            kho1obj.ThuKho = txtThuKho.Text.ToString().Trim();
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
                    if (khoctl.DelKho(txtMaKho.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmKho_Load(sender, e);
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
            GanDuLieu(khoobj);
            if (flag == 0)   // thêm
            {
                if (khoctl.AddKho(khoobj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmKho_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            // sửa
            {
                if (khoctl.UpdateKho(khoobj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmKho_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKho_Load(sender, e);
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
