using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class HoTro : Form
    {
        public HoTro()
        {
            InitializeComponent();
        }

        private void HoTro_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            Hide();
        }
    }
}
