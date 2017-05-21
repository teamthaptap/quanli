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
            txtMaPM.DataBindings.Clear();
            txtMaPM.DataBindings.Add("Text", dgvHienthi.DataSource, "MaPM");
            txtMaBD.DataBindings.Clear();
            txtMaBD.DataBindings.Add("Text", dgvHienthi.DataSource, "MaBD");
            txtTrangthai.DataBindings.Clear();
            txtTrangthai.DataBindings.Add("Text", dgvHienthi.DataSource, "TrangThai");
        }
        public void themPM(string MaPM, string MaBD, string TT)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "them_PM";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("MaPM", SqlDbType.NVarChar)).Value = MaPM;
                comd.Parameters.Add(new SqlParameter("MaBD", SqlDbType.NVarChar)).Value = MaBD;
                comd.Parameters.Add(new SqlParameter("TT", SqlDbType.Int)).Value = TT;


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
        public void suaPM(string MaPM,string MaBD,string TT)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "Sua_PM";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("MaPM1", SqlDbType.NVarChar)).Value = MaPM;
                comd.Parameters.Add(new SqlParameter("MaBD1", SqlDbType.NVarChar)).Value = MaBD;
                comd.Parameters.Add(new SqlParameter("TT1", SqlDbType.Int)).Value = TT;
       

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
        public void xoaPM(string MaPM)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "xoa_PM";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("MaPM2", SqlDbType.NVarChar)).Value = MaPM;
               


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

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            themPM(txtMaPM.Text,txtMaBD.Text,txtTrangthai.Text);
            KetNoiCSDL();
            MessageBox.Show("Them Thanh Cong");
            LoadData();
            txtMaPM.Enabled = false;
            
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtMaPM.DataBindings.Clear();
            txtMaBD.DataBindings.Clear();
            
            txtMaPM.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            suaPM(txtMaPM.Text,txtMaBD.Text,txtTrangthai.Text);
            KetNoiCSDL();
            MessageBox.Show("Sua Thanh Cong");
            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            xoaPM(txtMaPM.Text);
            KetNoiCSDL();
            MessageBox.Show("Xoa thanh cong");
            LoadData();
        }
    }
}
