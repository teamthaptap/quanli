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
    public partial class frmPhieuNhap : Form
    {
        public SendMessage send;

        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        public frmPhieuNhap(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }
        PhieuNhapCtl pnctl = new PhieuNhapCtl();
        PhieuNhapObj pnobj = new PhieuNhapObj();
        int flag = 0;

        public void Load_cbbMaKho()
        {
            KhoCtl kh = new KhoCtl();
            cbbMaKho.DataSource = kh.GetData();
            cbbMaKho.DisplayMember = "MaKho";
            cbbMaKho.ValueMember = "MaKho";
        }

        public void Load_cbbMaNCC()
        {
            NhaCungCapCtl ncc = new NhaCungCapCtl();
            cbbMaNCC.DataSource = ncc.GetData();
            cbbMaNCC.DisplayMember = "MaNCC";
            cbbMaNCC.ValueMember = "MaNCC";
        }
        private void Binding()
        {

            txtMaPN.DataBindings.Clear();
            txtMaPN.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "MaPN");
            cbbMaKho.DataBindings.Clear();
            cbbMaKho.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "MaKho");
            cbbMaNCC.DataBindings.Clear();
            cbbMaNCC.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "MaNCC");
            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "TongTien");
            dtpNgayNhap.DataBindings.Clear();
            dtpNgayNhap.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "NgayNhap");

        }

        public void dis_en(bool e)
        {
            txtMaPN.Enabled = e;
            txtTongTien.Enabled = e;
            cbbMaKho.Enabled = e;
            cbbMaNCC.Enabled = e;
            dtpNgayNhap.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnTrangChu.Enabled = !e;
            btnXem.Enabled = !e;
        }
        private void clean()
        {
            txtMaPN.Clear();
            txtTongTien.Clear();

            // cbbMaNV.Clear();


        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = pnctl.GetData();
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dis_en(false);
            //LoadData();
            Binding();
        }
        private void GanDuLieu(PhieuNhapObj pnobj)
        {
            pnobj.MaPN = txtMaPN.Text.ToString().Trim();
            pnobj.MaKho = cbbMaKho.Text.ToString().Trim();
            pnobj.MaNCC = cbbMaNCC.Text.ToString().Trim();
            pnobj.NgayNhap = dtpNgayNhap.Value;
            pnobj.TongTien = txtTongTien.Text.ToString().Trim();
        }


        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    txtMaPN.Text = dgvPhieuNhap.CurrentRow.Cells["MaPN"].Value.ToString();
                    dtpNgayNhap.Text = dgvPhieuNhap.CurrentRow.Cells["NgayNhap"].Value.ToString();
                    txtTongTien.Text = dgvPhieuNhap.CurrentRow.Cells["TongTien"].Value.ToString();
                    cbbMaNCC.Text = dgvPhieuNhap.CurrentRow.Cells["MaNCC"].Value.ToString();
                    cbbMaKho.Text = dgvPhieuNhap.CurrentRow.Cells["MaKho"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clean();
            dis_en(true);
            Load_cbbMaKho();
            Load_cbbMaNCC();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            Load_cbbMaKho();
            Load_cbbMaNCC();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    if (pnctl.DeletePhieuNhap(txtMaPN.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPhieuNhap_Load(sender, e);
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
            GanDuLieu(pnobj);
            if (flag == 0)   // thêm
            {
                if (pnctl.AddPhieuNhap(pnobj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPhieuNhap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            // sửa
            {
                if (pnctl.UpdatePhieuNhap(pnobj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPhieuNhap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmPhieuNhap_Load(sender, e);
            dis_en(false);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string MaPN = txtMaPN.Text.Trim();
            frmChiTietPhieuNhap ds = new frmChiTietPhieuNhap();
            this.Hide();
            ds.Show();

        }


        private void btnTrangChu_Click(object sender, EventArgs e)
        {

            frmMain ds = new frmMain();
            this.Hide();
            ds.Show();
        }
    }
}
