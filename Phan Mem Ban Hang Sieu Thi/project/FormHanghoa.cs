using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class FormHanghoa : Form
    {
        public FormHanghoa()
        {
            InitializeComponent();
        }

        private void FormHanghoa_Load(object sender, EventArgs e)
        {
            lblThemsoluong.Text = "2.Chức Năng Thêm Số Lượng Một Mặt Hàng Có Trong Kho Nằm Trong Mục Tìm Kiếm";
            Loadsanpham();
           // dgvSanpham.Columns[5].Width = 100;
        }
        void Loadsanpham()
        {
            string sql = @"select hh.Masanpham as 'Mã Sản Phẩm', hh.Tensanpham as 'Tên Sản Phẩm', hh.Gianhap as 'Giá Nhập',hh.Giaban as 'Giá Bán', hh.Soluong as 'Số Lượng' from HANGHOA hh";
            DataTable dt = DataProvider.LoadCSDL(sql);
            dgvSanpham.DataSource = dt;
            dgvSanpham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanpham.Columns[0].Width = 150;
            dgvSanpham.Columns[1].Width = 258;
            dgvSanpham.Columns[2].Width = 150;
            dgvSanpham.Columns[3].Width = 150;
            dgvSanpham.Columns[4].Width = 120;
        }
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
           
        }

        private void txtMasanpham_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtGianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtGiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            FormTimkiemhanghoa frmhanghoa = new FormTimkiemhanghoa();
            frmhanghoa.ShowDialog();
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            Loadsanpham();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu frmmenu = new FormMenu();
            this.Hide();
            frmmenu.Closed += (s, args) => this.Close();
            frmmenu.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormNhanVien frmnhanvien = new FormNhanVien();
            this.Hide();
            frmnhanvien.Closed += (s, args) => this.Close();
            frmnhanvien.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form1 frmhanghoa = new Form1();
            this.Hide();
            frmhanghoa.Closed += (s, args) => this.Close();
            frmhanghoa.ShowDialog();
        }
    }
}
