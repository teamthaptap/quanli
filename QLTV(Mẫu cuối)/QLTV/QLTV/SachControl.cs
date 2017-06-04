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
    public partial class SachControl : UserControl
    {
        public SachControl()
        {
            InitializeComponent();
            Load += loaddgv;
        }
        private void loaddgv(object sender, EventArgs e)
        {
            loaddulieu();
            loadcbbDS();
        }

        private void loadcbbDS()
        {
            DataTable dtcvd;
            dtcvd = SqlHelper.ExecuteDataset(StrConnect.strConnect(), "loadcbbDS").Tables[0];
            cbbDausach.DataSource = dtcvd;
            cbbDausach.DisplayMember = "MaDauSach";
            cbbDausach.ValueMember = "MaDauSach";
        }

        private void loaddulieu()
        {
            dgvHienthi.DataSource = SqlHelper.ExecuteDataset(QLTV.Class.StrConnect.strConnect(), "loadsach").Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)//Cập nhật
        {
            loaddulieu();
        }

        private void button1_Click(object sender, EventArgs e)//Thêm
        {
            
        }

        private void button2_Click(object sender, EventArgs e)//Sửa
        {
            
        }

        private void button3_Click(object sender, EventArgs e)//Xóa
        {
           
        }

        private void dgvHienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bingdingGV();
        }

        private void bingdingGV()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvHienthi.DataSource, "MaSach");
            cbbDausach.DataBindings.Clear();
            cbbDausach.DataBindings.Add("Text", dgvHienthi.DataSource, "MaDauSach");
            txtSotrang.DataBindings.Clear();
            txtSotrang.DataBindings.Add("Text", dgvHienthi.DataSource, "SoTrang");
            txtTaiban.DataBindings.Clear();
            txtTaiban.DataBindings.Add("Text", dgvHienthi.DataSource, "TaiBan");
            txtTrangthai.DataBindings.Clear();
            txtTrangthai.DataBindings.Add("Text", dgvHienthi.DataSource, "TrangThai");
            dtpNgaynhap.DataBindings.Clear();
            dtpNgaynhap.DataBindings.Add("Text", dgvHienthi.DataSource, "NgayNhap");
        }
    }
}
