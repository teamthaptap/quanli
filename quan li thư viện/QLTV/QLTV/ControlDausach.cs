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
    }
}
