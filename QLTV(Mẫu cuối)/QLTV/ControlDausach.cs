﻿using System;
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
                string theloai = cbbTheloai.SelectedValue.ToString();
                string maNXB = cbbNXB.SelectedValue.ToString();
                SqlHelper.ExecuteNonQuery(QLTV.Class.StrConnect.strConnect(), "Insert_DauSach", ma, tacgia, nhande, soluong, domat, ngonngu, theloai, maNXB);
                MessageBox.Show("Thêmthànhcông", "THôngbáo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddulieu();
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi");
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                string tacgia = txtTacgia.Text.Trim();
                string soluong = txtSoluong.Text.Trim();
                string nhande = txtNhande.Text.Trim();
                string domat = txtDomat.Text.Trim();
                string ngonngu = txtNgonngu.Text.Trim();
                string theloai = cbbTheloai.SelectedValue.ToString();
                string maNXB = cbbNXB.SelectedValue.ToString();
                SqlHelper.ExecuteNonQuery(QLTV.Class.StrConnect.strConnect(), "UpDate_DS", ma, tacgia, nhande, soluong, domat, ngonngu, theloai, maNXB);
                MessageBox.Show("Sửathànhcông", "Thôngbáo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddulieu();
            }
            catch (Exception)
            {
                MessageBox.Show("SửaLỗi", "Thôngbáo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaDS = txtMa.Text.Trim();
                SqlHelper.ExecuteNonQuery(QLTV.Class.StrConnect.strConnect(), "delDS", MaDS);
                loaddulieu();
            }
            catch (Exception) { }

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
            cbbNXB.DataBindings.Clear();//Lệnh xóa các dữ liệu của text box
            cbbNXB.DataBindings.Add("text", dgvHienthi.DataSource, "MaNXB");
            cbbTheloai.DataBindings.Clear();//Lệnh xóa các dữ liệu của text box
            cbbTheloai.DataBindings.Add("text", dgvHienthi.DataSource, "MaTheLoai");
        }

        private void dgvHienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bingdingGV();
        }
    }
}
