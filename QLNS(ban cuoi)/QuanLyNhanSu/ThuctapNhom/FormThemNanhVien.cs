﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ThuctapNhom
{
    public partial class FormThemNanhVien : Form
    {
        private void getdata()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            DataTable data1 = new DataTable();
            DataTable data = new DataTable();
            cm.Connection = con;

            cm.CommandText = "select * from chucvu";
            da.SelectCommand = cm;
            da.Fill(data);
            cmbChucVu.DataSource = data;
            cmbChucVu.DisplayMember = "ten";
            cmbChucVu.ValueMember = "ID";
            cmbChucVu.SelectedValue = "ID";

            cm.CommandText = "select * from PhongBan";
            da.SelectCommand = cm;
            da.Fill(data1);
            cmbTenPhongBan.DataSource = data1;
            cmbTenPhongBan.DisplayMember = "ten";
            cmbTenPhongBan.ValueMember = "ID";
            cmbTenPhongBan.SelectedValue = "ID";

        }
        private bool isEmpty()
        {
            if(txtID.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập mã");
                return true;
            }
            if (txtHoten.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên");
                return true;
            }
            if (!rdbNam.Checked && !rdbNu.Checked)
            {
                MessageBox.Show("Bạn chưa chọn giới tính");
                return true;
            }
            if (txtQuequan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập quê quán");
                return true;
            }
            if (txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                return true;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số CMND");
                return true;
            }
            if (txtDienthoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập điện thoại");
                return true;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập email");
                return true;
            }
            if (cmbTenPhongBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng ban");
                return true;
            }
            if (cmbChucVu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn chức vụ");
                return true;
            }
            return false;
        }
        public FormThemNanhVien()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
        NhanVien_obj nv;
        

      
        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}