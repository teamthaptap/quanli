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

namespace QuanLyKho11.Model
{
    public partial class PhieuNhap1 : Form
    {
        public PhieuNhap1()
        {
            InitializeComponent();
        }
        PhieuNhapCtl pnctl = new PhieuNhapCtl();
        PhieuNhapObj pnobj = new PhieuNhapObj();
        ChiTietPhieuNhapCtl ctctl = new ChiTietPhieuNhapCtl();
        ChiTietPhieuNhapObj ctobj = new ChiTietPhieuNhapObj();
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
        private void Load_cmbMaHang()
        {
            HangHoaCtl hh = new HangHoaCtl();
            cbbMaHang.DataSource = hh.GetData();
            cbbMaHang.DisplayMember = "MaHang";
            cbbMaHang.ValueMember = "MaHang";
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
        private void GanDuLieu1(ChiTietPhieuNhapObj ctobj)
        {
            ctobj.MaPN1 = txtMaPN.Text.ToString().Trim();
            ctobj.MaHang1 = cbbMaHang.Text.ToString().Trim();
            ctobj.DonGia1 = txtDonGia.Text.ToString().Trim();
            ctobj.SLThuc1 = txtSLThuc.Text.ToString().Trim();
            ctobj.ThanhTien1 = txtThanhTien.Text.ToString().Trim();
        }
        private void GanDuLieu(PhieuNhapObj pnobj)
        {
            pnobj.MaPN = txtMaPN.Text.ToString().Trim();
            pnobj.MaKho = cbbMaKho.Text.ToString().Trim();
            pnobj.MaNCC = cbbMaNCC.Text.ToString().Trim();
            pnobj.NgayNhap = dtpNgayNhap.Value;
            pnobj.TongTien = txtTongTien.Text.ToString().Trim();
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
            txtSLThuc.Enabled = e;
            txtThanhTien.Enabled = e;
            txtDonGia.Enabled = e;
            cbbMaHang.Enabled = e;
            btnSuaCT.Enabled = !e;
            btnXoaCT.Enabled = !e;
            button5.Enabled = !e;
            // btnTrangChu.Enabled = !e;
            // btnXem.Enabled = !e;
        }
        private void Clear()
        {
            txtMaPN.Clear();
            txtTongTien.Clear();
            txtDonGia.Clear();
            txtSLThuc.Clear();
            txtThanhTien.Clear();


            // cbbMaNV.Clear();


        }

        private void PhieuNhap1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pnctl.GetData();
            dgvPhieuNhap.DataSource = dt;
            Binding();
            // Binding1();
            dis_en(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
            Clear();
            Load_cmbMaHang();
            Load_cbbMaKho();
            Load_cbbMaNCC();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            //Clear();
            Load_cmbMaHang();
            Load_cbbMaKho();
            Load_cbbMaNCC();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    ctctl.DeleteChiTietPhieuNhap(txtMaPN.Text.Trim());
                    if (pnctl.DeletePhieuNhap(txtMaPN.Text.Trim()))
                    {

                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PhieuNhap1_Load(sender, e);
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
                    GanDuLieu1(ctobj);
                    if (ctctl.AddChiTietPhieuNhap(ctobj))
                        MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhieuNhap1_Load(sender, e);
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
                    // frmPhieuNhap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            PhieuNhap1_Load(sender, e);
            dis_en(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flag = 0;
            Load_cmbMaHang();
            txtDonGia.Clear();
            txtSLThuc.Clear();
            txtThanhTien.Clear();
            txtTongTien.Clear();
            txtDonGia.Enabled = true;
            txtSLThuc.Enabled = true;
            txtThanhTien.Enabled = true;
            txtTongTien.Enabled = true;
            cbbMaHang.Enabled = true;
            btnLuuCT.Enabled = true;
            btnSuaCT.Enabled = false;
            btnXoaCT.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            flag = 1;
            Load_cmbMaHang();
            txtDonGia.Enabled = true;
            txtSLThuc.Enabled = true;
            txtThanhTien.Enabled = true;
            txtTongTien.Enabled = true;
            btnLuuCT.Enabled = true;
            btnSuaCT.Enabled = false;
            btnXoaCT.Enabled = false;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    if (ctctl.DeleteChiTietPhieuNhap(cbbMaHang.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ph(sender, e);
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
                PhieuNhap1_Load(sender, e);
            }
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            GanDuLieu1(ctobj);
            if (flag == 0)   // thêm
            {
                if (ctctl.AddChiTietPhieuNhap(ctobj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  frmChiTietPhieuNhap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            // sửa
            {
                if (flag == 1)
                {
                    if (ctctl.UpdateChiTietPhieuNhap(ctobj))
                    {
                        MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //frmChiTietPhieuNhap_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            PhieuNhap1_Load(sender, e);
        }

        private void txtMaPN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctctl.GetData(txtMaPN.Text.Trim());
                dgvChiTiet.DataSource = dt;


            }
            catch
            {
                dgvChiTiet.DataSource = null;
            }
            Binding1();
        }

        private void txtThanhTien_MouseClick(object sender, MouseEventArgs e)
        {
            txtThanhTien.Text = (Int32.Parse(txtDonGia.Text) * Int32.Parse(txtSLThuc.Text)).ToString();
        }
    }
}
