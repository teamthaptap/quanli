﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThuctapNhom
{
    public partial class FormPhongBan : Form
    {
        public FormPhongBan()
        {
            InitializeComponent();
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable datadangky = new DataTable();
          
            cm.Connection = conn;
            cm.CommandText = "select * from phongban";
            da.SelectCommand = cm;
            da.Fill(datadangky);
            cmbdanhsach.DataSource = datadangky;
            cmbdanhsach.DisplayMember = "ten";
            cmbdanhsach.ValueMember = "ID";
            cmbdanhsach.SelectedValue = "ID";
            
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            FormThongTinPhongBan fr = new FormThongTinPhongBan();
            fr.mapb = (cmbdanhsach.SelectedIndex+1).ToString();
            fr.Show();
            Hide();
        }
    }
}