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
    public partial class ControlDausach : UserControl
    {
        string strConnect = @"Data Source =LATITUDE-PC;Initial Catalog = QL_KhachSan; Integrated Security = True";
        public ControlDausach()
        {
            InitializeComponent();
            this.Load += loaddausach;
        }

        private void loaddausach(object sender, EventArgs e)
        {
            loaddulieu();
           
        }

        private void loaddulieu()
        {
            dgvHienthi.DataSource = SqlHelper.ExecuteDataset(QLTV.Class.StrConnect.strConnect(), "loaddausach").Tables[0];
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
    
        }

   
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                string tacgia = txtTacgia.Text.Trim();
                string soluong = txtSoluong.Text.Trim();
                string nhande = txtNhande.Text.Trim();
                string domat = txtDomat.Text.Trim();
                string ngonngu = txtNgonngu.Text.Trim();
                string theloai =txtTheLoai.Text.Trim();
                string maNXB = txtNXB.Text.Trim();
                SqlHelper.ExecuteNonQuery(QLTV.Class.StrConnect.strConnect(), "ADDTaiLieu", ma, tacgia, soluong,nhande,domat,ngonngu,theloai,maNXB);
                MessageBox.Show("Thêm thành công", "THông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddulieu();
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi");
            }
        }

      



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaDV = txtMa.Text.Trim();
                SqlHelper.ExecuteNonQuery(QLTV.Class.StrConnect.strConnect(), "deleteDauSach", MaDV);
                loaddulieu();
            }
            catch (Exception) { }
        }
    }
}
