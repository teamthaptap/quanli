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
    public partial class FormThongke : Form
    {
        public FormThongke()
        {
            InitializeComponent();
        }
        private void FormThongke_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbDanhsachsanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbDanhsachphongban_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbDanhsachnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            FormMenu frmmenu = new FormMenu();
            this.Hide();
            frmmenu.Closed += (s, args) => this.Close();
            frmmenu.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frmhanghoa = new Form1();
            this.Hide();
            frmhanghoa.Closed += (s, args) => this.Close();
            frmhanghoa.ShowDialog();
        }
    }
}
