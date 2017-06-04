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
    public partial class NXBControl : UserControl
    {
        public NXBControl()
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
            dgvHienthi.DataSource = SqlHelper.ExecuteDataset(QLTV.Class.StrConnect.strConnect(), "loadNXB").Tables[0];
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvHienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bingdingGV();
        }

        private void bingdingGV()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvHienthi.DataSource, "MaNXB");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvHienthi.DataSource, "TenNXB");
            txtQuocgia.DataBindings.Clear();
            txtQuocgia.DataBindings.Add("Text", dgvHienthi.DataSource, "QuocGia");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgvHienthi.DataSource, "DiaChi");
            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("Text", dgvHienthi.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvHienthi.DataSource, "Email");
        }
    }
}
