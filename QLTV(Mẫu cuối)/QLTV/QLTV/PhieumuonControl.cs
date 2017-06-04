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
            cbbBD.DataSource = dtcvd;
            cbbBD.DisplayMember = "MaBD";
            cbbBD.ValueMember = "MaBD";
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
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
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
            cbbBD.DataBindings.Clear();
            cbbBD.DataBindings.Add("Text", dgvHienthi.DataSource, "MaBD");
            txtMaPM.DataBindings.Clear();
            txtMaPM.DataBindings.Add("Text", dgvHienthi.DataSource, "MaPM");
            txtTrangthai.DataBindings.Clear();
            txtTrangthai.DataBindings.Add("Text", dgvHienthi.DataSource, "TrangThai");
        }
    }
}
