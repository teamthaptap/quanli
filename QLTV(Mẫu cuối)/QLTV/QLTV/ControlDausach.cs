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
        //string strConnect = @"Data Source =LATITUDE-PC;Initial Catalog = QL_KhachSan; Integrated Security = True";
        public ControlDausach()
        {
            InitializeComponent();
            this.Load += loaddausach;
        }

        private void loaddausach(object sender, EventArgs e)
        {
            loaddulieu();
            loadcbbMaTheLoai();
            loadcbbNXB();
           
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
          
        }
        private void loadcbbMaTheLoai()
        {
            DataTable dtcv;
            dtcv = SqlHelper.ExecuteDataset(Class.StrConnect.strConnect(), "loadTheLoai").Tables[0];
            cbbMaTheLoai.DataSource = dtcv;
            cbbMaTheLoai.DisplayMember = "MaTheLoai";
            cbbMaTheLoai.ValueMember = "MaTheLoai";
        }
        private void loadcbbNXB()
        {
            DataTable dtcv;
            dtcv = SqlHelper.ExecuteDataset(Class.StrConnect.strConnect(), "loadnxb1").Tables[0];
            cbbMaNXB.DataSource = dtcv;
            cbbMaNXB.DisplayMember = "MaNXB";
            cbbMaNXB.ValueMember = "MaNXB";
        }

        public void bingdingGV()
        {
            txtMa.DataBindings.Clear();//Lệnh xóa các dữ liệu của text box
            txtMa.DataBindings.Add("text", dgvHienthi.DataSource, "MaDauSach");
            txtDomat.DataBindings.Clear();//Lệnh xóa các dữ liệu của text box
            txtDomat.DataBindings.Add("text", dgvHienthi.DataSource, "DoMat");
            txtNgonngu.DataBindings.Clear();//Lệnh xóa các dữ liệu của text box
            txtNgonngu.DataBindings.Add("text", dgvHienthi.DataSource, "NgonNgu");
            txtNhande.DataBindings.Clear();//Lệnh xóa các dữ liệu của text box
            txtNhande.DataBindings.Add("text", dgvHienthi.DataSource, "NhanDe");
            txtSoluong.DataBindings.Clear();//Lệnh xóa các dữ liệu của text box
            txtSoluong.DataBindings.Add("text", dgvHienthi.DataSource, "SoLuong");
            txtTacgia.DataBindings.Clear();//Lệnh xóa các dữ liệu của text box
            txtTacgia.DataBindings.Add("text", dgvHienthi.DataSource, "TacGia");
            cbbMaNXB.DataBindings.Clear();//Lệnh xóa các dữ liệu của text box
            cbbMaNXB.DataBindings.Add("text", dgvHienthi.DataSource, "MaNXB");
            cbbMaTheLoai.DataBindings.Clear();//Lệnh xóa các dữ liệu của text box
            cbbMaTheLoai.DataBindings.Add("text", dgvHienthi.DataSource, "MaTheLoai");
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
        }

        private void btSua_Click(object sender, EventArgs e)
        {
         
        }

        private void dgvHienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bingdingGV();
        }
    }
}
