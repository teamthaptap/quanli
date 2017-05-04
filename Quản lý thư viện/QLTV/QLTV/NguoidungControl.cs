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

namespace QLTV
{
    public partial class NguoidungControl : UserControl
    {
        public NguoidungControl()
        {
            InitializeComponent();
            KetNoiCSDL();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KN-PC\KN;Initial Catalog=QL_ThuVien;Integrated Security=True");
        //ham ket noi
        private void KetNoiCSDL()
        {
            con.Open();
            string sql = "select * from BanDoc";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();// Chon mot table ao de luu tru dunlieu
            da.Fill(dt);// do du lieu vao kho
            con.Close();
            dgvHienthi.DataSource = dt;// do du lieu vao data GV



        }
        private void LoadData()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvHienthi.DataSource, "MaBD");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvHienthi.DataSource, "HoTen");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dgvHienthi.DataSource, "CMND");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgvHienthi.DataSource, "DiaChi");
            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("Text", dgvHienthi.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvHienthi.DataSource, "Email");
            cbbMalop.DataBindings.Clear();
            cbbMalop.DataBindings.Add("Text", dgvHienthi.DataSource, "MaLop");
            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("Text", dgvHienthi.DataSource, "NgaySinh");
            rbdNam.DataBindings.Clear();
            rbdNam.DataBindings.Add("Text", dgvHienthi.DataSource, "GioiTinh");
            if (rbdNam.Text == "Nam")
            {
                rbdNam.Text = "Nam";
                rbdNam.Checked = true;
                rbdNu.Text = "Nữ";

            }
            else
            {
                rbdNu.Text = "Nữ";
                rbdNu.Checked = true;
                rbdNam.Text = "Nam";
            }


        }
        private void button4_Click(object sender, EventArgs e)
        {
        
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
