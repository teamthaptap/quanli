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
    public delegate void SendMessage(string value);
    public partial class frmChiTietPhieuXuat : Form
    {
        public frmChiTietPhieuXuat()
        {
            InitializeComponent();
        }
        public frmChiTietPhieuXuat(string str)
        {
            InitializeComponent();
            txtMaPX.Text = str;
        }
        ChiTietPhieuXuatCtl ctctl = new ChiTietPhieuXuatCtl();
        ChiTietPhieuXuatObj ctobj = new ChiTietPhieuXuatObj();
        PhieuXuatCtl pnctl = new PhieuXuatCtl();
        PhieuXuatObj pnobj = new PhieuXuatObj();
        int flag = 0;

        private void Binding1()
        {

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvChiTiet.DataSource, "DonGia");
            cbbMaHang.DataBindings.Clear();
            cbbMaHang.DataBindings.Add("Text", dgvChiTiet.DataSource, "TenHang");
            txtSLThuc.DataBindings.Clear();
            txtSLThuc.DataBindings.Add("Text", dgvChiTiet.DataSource, "SLThuc");
            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("Text", dgvChiTiet.DataSource, "ThanhTien");
        }
        private void GanDuLieu1(ChiTietPhieuXuatObj ctobj)
        {
            ctobj.MaHang1 = cbbMaHang.Text.ToString().Trim();
            ctobj.DonGia1 = txtDonGia.Text.ToString().Trim();
            ctobj.SLThuc1 = txtSLThuc.Text.ToString().Trim();
            ctobj.ThanhTien1 = txtThanhTien.Text.ToString().Trim();
        }
        private void Clear()
        {
            //   txtMaPX.Text = "";
            txtTongTien.Text = "";
            dtpNgayXuat.Text = "";
            //  txtTongTien.Text = "";
            txtSLThuc.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";


        }
        public void dis_en(bool e)
        {

            txtMaPX.Enabled = e;


            cbbMaHang.Enabled = e;
            txtDonGia.Enabled = e;
            txtThanhTien.Enabled = e;
            txtSLThuc.Enabled = e;
            txtTongTien.Enabled = e;
            dtpNgayXuat.Enabled = e;

            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnHuy.Enabled = e;
            btnThemHang.Enabled = !e;

            btnTroLai.Enabled = !e;
        }
        private void Load_cbbMaHang()
        {
            HangHoaCtl hh = new HangHoaCtl();
            cbbMaHang.DataSource = hh.GetData();
            cbbMaHang.DisplayMember = "TenHang";
            cbbMaHang.ValueMember = "MaHang";

        }

        public void LoadData()
        {
            txtMaPX.Text = dgvChiTiet.CurrentRow.Cells[0].Value.ToString();
            cbbMaHang.Text = dgvChiTiet.CurrentRow.Cells[1].Value.ToString();
            txtDonGia.Text = dgvChiTiet.CurrentRow.Cells[3].Value.ToString();
            txtSLThuc.Text = dgvChiTiet.CurrentRow.Cells[2].Value.ToString();
            txtThanhTien.Text = dgvChiTiet.CurrentRow.Cells[4].Value.ToString();
        }

        private void frmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            dgvChiTiet.DataSource = pnctl.GetData();
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dis_en(false);
            LoadData();
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    txtMaPX.Text = dgvChiTiet.CurrentRow.Cells["MaPX"].Value.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtMaPX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctctl.GetData(txtMaPX.Text.Trim());
                dgvChiTiet.DataSource = dt;
            }
            catch
            {
                dgvChiTiet.DataSource = null;
            }
            Binding1();
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {

            flag = 0;
            Clear();
            txtMaPX.Enabled = false;
            dis_en(true);

            Load_cbbMaHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            Load_cbbMaHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    if (ctctl.DeleteChiTietPhieuXuat(txtMaPX.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmChiTietPhieuXuat_Load(sender, e);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuXuat_Load(sender, e);
            dis_en(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            GanDuLieu1(ctobj);
            if (flag == 0)   // thêm
            {
                if (ctctl.AddChiTietPhieuXuat(ctobj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmChiTietPhieuXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            // sửa
            {
                if (ctctl.UpdateChiTietPhieuXuat(ctobj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmChiTietPhieuXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            frmPhieuXuat ds = new frmPhieuXuat();
            this.Hide();
            ds.Show();
        }
    }
}
