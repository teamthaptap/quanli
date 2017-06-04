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
    //public delegate void SendMessage(string value);
    public partial class frmChiTietPhieuNhap : Form
    {
        
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        public frmChiTietPhieuNhap(string str)
        {
            InitializeComponent();
            txtMaPN.Text = str;
        }

        ChiTietPhieuNhapCtl ctctl = new ChiTietPhieuNhapCtl();
        ChiTietPhieuNhapObj ctobj = new ChiTietPhieuNhapObj();
        PhieuNhapCtl pnctl = new PhieuNhapCtl();
        PhieuNhapObj pnobj = new PhieuNhapObj();
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
        private void GanDuLieu1(ChiTietPhieuNhapObj ctobj)
        {
            ctobj.MaHang1 = cbbMaHang.Text.ToString().Trim();
            ctobj.DonGia1 = txtDonGia.Text.ToString().Trim();
            ctobj.SLThuc1 = txtSLThuc.Text.ToString().Trim();
            ctobj.ThanhTien1 = txtThanhTien.Text.ToString().Trim();
        }
        private void Clear()
        {
         //   txtMaPN.Text = "";
            txtTongTien.Text = "";
            dtpNgayNhap.Text = "";
            //  txtTongTien.Text = "";
            txtSLThuc.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
          

        }
        public void dis_en(bool e)
        { 
            
           txtMaPN.Enabled = e; 
           
           
            cbbMaHang.Enabled = e;
            txtDonGia.Enabled = e;
            txtThanhTien.Enabled = e;
            txtSLThuc.Enabled = e;
            txtTongTien.Enabled = e;
            dtpNgayNhap.Enabled = e;
           
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnHuy.Enabled = e;
            btnThemHang.Enabled = !e;
            
            btnTroLai.Enabled = !e;
        }
        private void Load_cmbMaHang()
        {
            HangHoaCtl hh = new HangHoaCtl();
            cbbMaHang.DataSource = hh.GetData();
            cbbMaHang.DisplayMember = "TenHang";
            cbbMaHang.ValueMember = "MaHang";

        }

        public void LoadData()
        {
            txtMaPN.Text = dgvChiTiet.CurrentRow.Cells[0].Value.ToString();
            cbbMaHang.Text = dgvChiTiet.CurrentRow.Cells[1].Value.ToString();
            txtDonGia.Text = dgvChiTiet.CurrentRow.Cells[3].Value.ToString();
            txtSLThuc.Text = dgvChiTiet.CurrentRow.Cells[2].Value.ToString();
            txtThanhTien.Text = dgvChiTiet.CurrentRow.Cells[4].Value.ToString();
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            //frmChiTietPhieuNhap f2 = new frmChiTietPhieuNhap(SetValue);
            //f2.ShowDialog();
         //   frmChiTietPhieuNhap str;
           

            dgvChiTiet.DataSource = pnctl.GetData();
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dis_en(false);
            LoadData();
            //Binding1();
        }
        

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    txtMaPN.Text = dgvChiTiet.CurrentRow.Cells["MaPN"].Value.ToString();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
        public void Load_cbbMaHang()
        {
          HangHoaCtl kh = new HangHoaCtl();
            cbbMaHang.DataSource = kh.GetData();
            cbbMaHang.DisplayMember = "Mahang";
            cbbMaHang.ValueMember = "MaHang";
        }
        private void btnThemHang_Click(object sender, EventArgs e)
        {
            flag = 0;
            Clear();
            txtMaPN.Enabled = false;
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
                    if (ctctl.DeleteChiTietPhieuNhap(txtMaPN.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmChiTietPhieuNhap_Load(sender, e);
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

            frmChiTietPhieuNhap_Load(sender, e);
            dis_en(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            GanDuLieu1(ctobj);
            if (flag == 0)   // thêm
            {
                if (ctctl.AddChiTietPhieuNhap(ctobj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmChiTietPhieuNhap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            // sửa
            {
                if (ctctl.UpdateChiTietPhieuNhap(ctobj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmChiTietPhieuNhap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            frmPhieuNhap ds = new frmPhieuNhap();
            this.Hide();
            ds.Show();
        }
    }
}
