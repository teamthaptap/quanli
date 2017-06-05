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
    public partial class CTPMControl : UserControl
    {
        public CTPMControl()
        {
            InitializeComponent();
            Load += loadCTPM;
        }
        private void loadCTPM(object sender, EventArgs e)
        {
            loaddulieu();
            loadCBBphieu();
            loadCBBsach();
        }

        private void loaddulieu()
        {
            dgvHienthi.DataSource = SqlHelper.ExecuteDataset(QLTV.Class.StrConnect.strConnect(), "loadchitiephieumuon").Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loaddulieu();
        }
        private void loadCBBphieu()
        {
            DataTable dtcv;
            dtcv = SqlHelper.ExecuteDataset(StrConnect.strConnect(), "loadcbbphieumuon").Tables[0];
            cbbPhieu.DataSource = dtcv;
            cbbPhieu.DisplayMember = "MaPM";
            cbbPhieu.ValueMember = "MaPM";
        }
        private void loadCBBsach()
        {
            DataTable dtcv;
            dtcv = SqlHelper.ExecuteDataset(StrConnect.strConnect(), "loadcbbsach").Tables[0];
            cbbSach.DataSource = dtcv;
            cbbSach.DisplayMember = "MaSach";
            cbbSach.ValueMember = "MaSach";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mapm = cbbPhieu.SelectedValue.ToString();
                string mas = cbbSach.SelectedValue.ToString();
                DateTime ngaymuon = DateTime.Parse(dtpNgaymuon.Value.ToString());
                DateTime ngaytra = DateTime.Parse(dtpNgaytra.Value.ToString());
                DateTime hantra = DateTime.Parse(dtpHantra.Value.ToString());
                string ghichu = txtGhiChu.Text.Trim();
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "addCTPM", mapm, mas, ngaymuon, ngaytra, hantra, ghichu);
                MessageBox.Show("Thêm thành công!");
                //loaddgv();
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
                string mapm = cbbPhieu.SelectedValue.ToString();
                string mas = cbbSach.SelectedValue.ToString();
                DateTime ngaymuon = DateTime.Parse(dtpNgaymuon.Value.ToString());
                DateTime ngaytra = DateTime.Parse(dtpNgaytra.Value.ToString());
                DateTime hantra = DateTime.Parse(dtpHantra.Value.ToString());
                string ghichu = txtGhiChu.Text.Trim();
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "updateCTPM", mapm, mas, ngaymuon, ngaytra, hantra, ghichu);
                MessageBox.Show("Sửa thành công!");
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
                string mapm = cbbPhieu.SelectedValue.ToString();
                string mas = cbbSach.SelectedValue.ToString();
                MessageBox.Show("Bạn xác nhận muốn xóa ???", "Thông báo", MessageBoxButtons.YesNoCancel);
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "delCTPM", mapm, mas);
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi!!!");
            }
        }
        private void bingdingGV()
        {
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvHienthi.DataSource, "GhiChu");
            cbbPhieu.DataBindings.Clear();
            cbbPhieu.DataBindings.Add("Text", dgvHienthi.DataSource, "MaPM");
            cbbSach.DataBindings.Clear();
            cbbSach.DataBindings.Add("Text", dgvHienthi.DataSource, "MaSach");
            dtpHantra.DataBindings.Clear();
            dtpHantra.DataBindings.Add("Text", dgvHienthi.DataSource, "HanTra");
            dtpNgaymuon.DataBindings.Clear();
            dtpNgaymuon.DataBindings.Add("Text", dgvHienthi.DataSource, "NgayMuon");
            dtpNgaytra.DataBindings.Clear();
            dtpNgaytra.DataBindings.Add("Text", dgvHienthi.DataSource, "NgayTra");
        }
        private void dgvHienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            bingdingGV();
        }
    }
}
