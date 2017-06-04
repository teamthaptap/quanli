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
        }

        private void loaddulieu()
        {
            dgvHienthi.DataSource = SqlHelper.ExecuteDataset(QLTV.Class.StrConnect.strConnect(), "loadphieumuon").Tables[0];
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string mapm = txtMa.Text.Trim();
                string mabd = cbbbandoc.Text.Trim();
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

        private void btSua_Click(object sender, EventArgs e)
        {

            try
            {
                string mapm = txtMa.Text.Trim();
                string mabd = cbbbandoc.Text.Trim();
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

    }
}
