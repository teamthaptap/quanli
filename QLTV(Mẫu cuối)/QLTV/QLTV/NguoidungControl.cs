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
using System.Data.SqlClient;
using QLTV.Class;

namespace QLTV
{
    public partial class NguoidungControl : UserControl
    {

        public NguoidungControl()
        {
            InitializeComponent();
            Load += loaddgv;
        }

        private void loaddgv(object sender, EventArgs e)
        {
            loaddulieu();
            loadcbbLop();
        }

        private void loadcbbLop()
        {

            DataTable dtcvd;
            dtcvd = SqlHelper.ExecuteDataset(StrConnect.strConnect(), "loadmaLop").Tables[0];
            cbbMalop.DataSource = dtcvd;
            cbbMalop.DisplayMember = "MaLop";
            cbbMalop.ValueMember = "MaLop";
        }

        private void loaddulieu()
        {
            dgvHienthi.DataSource = SqlHelper.ExecuteDataset(QLTV.Class.StrConnect.strConnect(), "loadBD").Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)//Cập nhật
        {
            loaddulieu();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//Sửa
        {
            
        }

        private void button1_Click(object sender, EventArgs e)//Thêm
        {
            
        }

        private void button3_Click(object sender, EventArgs e)//Xóa
        {
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dgvHienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bingdingGV();
        }

        private void bingdingGV()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvHienthi.DataSource, "MaBD");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvHienthi.DataSource, "HoTen");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dgvHienthi.DataSource, "CMND");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgvHienthi.DataSource, "DiaChi");
            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("Text", dgvHienthi.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvHienthi.DataSource, "Email");
            rdbNam.DataBindings.Clear();
            rdbNam.DataBindings.Add("Text", dgvHienthi.DataSource, "GioiTinh");
            if (rdbNam.Text == "Nam")
            {
                rdbNam.Text = "Nam";
                rdbNam.Checked = true;
                rdbNu.Text = "Nữ";
            }
            else
            {
                rdbNu.Text = "Nữ";
                rdbNu.Checked = true;
                rdbNam.Text = "Nam";
            }
            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("Text", dgvHienthi.DataSource, "NgaySinh");
            cbbMalop.DataBindings.Clear();
            cbbMalop.DataBindings.Add("Text", dgvHienthi.DataSource, "MaLop");
        }
    }
}
