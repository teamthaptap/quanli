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
    public partial class NguoidungControl : UserControl
    {
        public NguoidungControl()
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
            dgvHienthi.DataSource = SqlHelper.ExecuteDataset(QLTV.Class.StrConnect.strConnect(), "loadbandoc").Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loaddulieu();
        }
    }
}
