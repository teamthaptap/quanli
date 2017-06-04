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
    public partial class CTPMControl : UserControl
    {
        public CTPMControl()
        {
            InitializeComponent();
            this.Load += loaddulieu;
         
        }

        private void loaddulieu(object sender, EventArgs e)
        {
            loaddgv();
            loadCBBphieu();
            loadCBBsach();
        }

        private void loaddgv()
        {
            dgvHienthi.DataSource = SqlHelper.ExecuteDataset(Class.StrConnect.strConnect(), "loadchitiephieumuon").Tables[0];
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
        private void btnThem_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            loaddgv();
        }
    }
}
