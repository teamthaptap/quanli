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

namespace QLTV
{
    public partial class TheloaiControl : UserControl
    {
        public TheloaiControl()
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
            dgvHienthi.DataSource = SqlHelper.ExecuteDataset(QLTV.Class.StrConnect.strConnect(), "loadtheloai").Tables[0];
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void dgvHienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                string ten = txtTen.Text.Trim();
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "addTL", ma, ten);
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
                string ma = txtMa.Text.Trim();
                MessageBox.Show("Bạn xác nhận muốn xóa ???", "Thông báo", MessageBoxButtons.YesNoCancel);
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "delTL", ma);
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
                string ma = txtMa.Text.Trim();
                string ten = txtTen.Text.Trim();
                SqlHelper.ExecuteNonQuery(StrConnect.strConnect(), "updateTL", ma, ten);
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
