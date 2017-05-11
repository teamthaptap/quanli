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
    public partial class PhieumuonControl : UserControl
    {
        public PhieumuonControl()
        {
            InitializeComponent();
            KetNoiCSDL();
            LoadData();

        }
        SqlConnection con = new SqlConnection(@"Data Source=KN-PC\KN;Initial Catalog=QL_ThuVien;Integrated Security=True");
        //ham ket noi
        private void KetNoiCSDL()
        {
            con.Open();
            string sql = "select * from PhieuMuon";
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
            txtMa.DataBindings.Add("Text", dgvHienthi.DataSource, "MaPM");
            cbbbandoc.DataBindings.Clear();
            cbbbandoc.DataBindings.Add("Text", dgvHienthi.DataSource, "MaBD");
            txtTrangthai.DataBindings.Clear();
            txtTrangthai.DataBindings.Add("Text", dgvHienthi.DataSource, "TrangThai");
        }
        

        private void btCapnhat_Click(object sender, EventArgs e)
        {
          
        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
