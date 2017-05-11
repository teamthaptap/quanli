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
    public partial class CTPMControl : UserControl
    {
        public CTPMControl()
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
            string sql = "select * from ChitietPhieuMuon";
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
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvHienthi.DataSource, "GhiChu");
            cbbPhieu.DataBindings.Clear();
            cbbPhieu.DataBindings.Add("Text", dgvHienthi.DataSource, "MaPM");
            cbbSach.DataBindings.Clear();
            cbbSach.DataBindings.Add("Text", dgvHienthi.DataSource, "MaSach");
            dtpHantra.DataBindings.Clear();
            dtpHantra.DataBindings.Add("Text", dgvHienthi.DataSource, "HanTra");
            dtpNgaymuon.DataBindings.Clear();
            dtpNgaymuon.DataBindings.Add("Text", dgvHienthi.DataSource, "NgayMuon");
            dtpNgaytra.DataBindings.Clear();
            dtpNgaytra.DataBindings.Add("Text", dgvHienthi.DataSource, "NgayTra");
        }

        public void themCTPM(string mapm, string masach, string hantra, string ngaymuon, string ngaytra, string ghichu)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "them_CTPM";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("mapm", SqlDbType.NVarChar)).Value = mapm;
                comd.Parameters.Add(new SqlParameter("masach", SqlDbType.NVarChar)).Value = masach;
                comd.Parameters.Add(new SqlParameter("hantra", SqlDbType.Date)).Value = hantra;
                comd.Parameters.Add(new SqlParameter("ngaymuon", SqlDbType.Date)).Value = ngaymuon;
                comd.Parameters.Add(new SqlParameter("ngaytra", SqlDbType.Date)).Value = ngaytra;

                comd.Parameters.Add(new SqlParameter("ghichu", SqlDbType.NText)).Value = ghichu;

                comd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void suaCTPM(string mapm, string masach, string hantra, string ngaymuon, string ngaytra, string ghichu)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "sua_CTPM";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("mapm1", SqlDbType.NVarChar)).Value = mapm;
                comd.Parameters.Add(new SqlParameter("masach1", SqlDbType.NVarChar)).Value = masach;
                comd.Parameters.Add(new SqlParameter("hantra1", SqlDbType.Date)).Value = hantra;
                comd.Parameters.Add(new SqlParameter("ngaymuon1", SqlDbType.Date)).Value = ngaymuon;
                comd.Parameters.Add(new SqlParameter("ngaytra1", SqlDbType.Date)).Value = ngaytra;

                comd.Parameters.Add(new SqlParameter("ghichu1", SqlDbType.NText)).Value = ghichu;

                comd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void xoaCTPM(string mapm,string masach)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "xoa_CTPM";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("mapm2", SqlDbType.NVarChar)).Value = mapm;
                comd.Parameters.Add(new SqlParameter("masach2", SqlDbType.NVarChar)).Value = masach;


                comd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
          
                themCTPM(cbbPhieu.Text,cbbSach.Text,dtpHantra.Text,dtpNgaymuon.Text,dtpNgaytra.Text,txtGhiChu.Text);
                KetNoiCSDL();
                MessageBox.Show("Them Thanh Cong");
                LoadData();
            cbbPhieu.Enabled = false;
            cbbSach.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbbPhieu.Enabled = true;
            cbbSach.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaCTPM(cbbPhieu.Text, cbbSach.Text, dtpHantra.Text, dtpNgaymuon.Text, dtpNgaytra.Text, txtGhiChu.Text);
            KetNoiCSDL();
            MessageBox.Show("Sua Thanh Cong");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaCTPM(cbbPhieu.Text, cbbSach.Text);
            KetNoiCSDL();
            MessageBox.Show("Xoa thanh cong");
            LoadData();
        }
    }
}
