﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_THUCTAP
{
    public partial class FormThemPM : Form
    {
        public FormThemPM()
        {
            InitializeComponent();
        }


        private void FormThemPM_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            QUANLI ql = new QUANLI();
            this.Hide();
            ql.ShowDialog();
        }
    }
}
