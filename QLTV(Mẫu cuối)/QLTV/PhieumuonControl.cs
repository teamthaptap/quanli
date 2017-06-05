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
    public partial class PhieumuonControl : UserControl
    {
        public PhieumuonControl()
        {
            InitializeComponent();
            Load += loaddgv;
        }
        private void loaddgv(object sender, EventArgs e)
        {
            loaddulieu();
            loadcbbBD();
        }
        private void loadcbbBD()
        {
            DataTable dtcvd;
            dtcvd = SqlHelper.ExecuteDataset(StrConnect.strConnect(), "loadmaBD").Tables[0];
            cbbbandoc.DataSource = dtcvd;
            cbbbandoc.DisplayMember = "MaBD";
            cbbbandoc.ValueMember = "MaBD";
        }

        private void loaddulieu()
        {
            dgvHienthi.DataSource = SqlHelper.ExecuteDataset(QLTV.Class.StrConnect.strConnect(), "loadphieumuon").Tables[0];
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            loaddulieu();
        }
        private void bingdingGV()
        {
            cbbbandoc.DataBindings.Clear();
            cbbbandoc.DataBindings.Add("Text", dgvHienthi.DataSource, "MaBD");
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvHienthi.DataSource, "MaPM");
            txtTrangthai.DataBindings.Clear();
            txtTrangthai.DataBindings.Add("Text", dgvHienthi.DataSource, "TrangThai");
        }
        private void dgvHienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bingdingGV();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string mapm = txtMa.Text.Trim();
                string mabd = cbbbandoc.SelectedValue.ToString();
                string trangthai = txtTrangthai.Text.Trim();
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "addPM", mapm, mabd, trangthai);
                MessageBox.Show("Thêm thành công!");
                loaddulieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi!!!");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mapm = txtMa.Text.Trim();
                MessageBox.Show("Bạn xác nhận muốn xóa ???", "Thông báo", MessageBoxButtons.YesNoCancel);
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "delPM", mapm);
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi!!!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string mapm = txtMa.Text.Trim();
                string mabd = cbbbandoc.SelectedValue.ToString();
                string trangthai = txtTrangthai.Text.Trim();
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "updatePM", mapm, mabd, trangthai);
                MessageBox.Show("Sửa thành công!");
                loaddulieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi!!!");
            }
        }
    }
}
