using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace ThuctapNhom
{
    public partial class FormNhanVien : Form
    {
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblNHANVIEN");
        private SqlDataAdapter da = new SqlDataAdapter();
        public void connect()
        {
            String conStr = globalParameter.str;
            try
            {

                conn = new SqlConnection(conStr);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi");
            }
        }
        public void disconect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        public void getdata()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "Select * from NHANVIEN";
            da.SelectCommand = command;
            da.Fill(dt);
            dvgnhanvien.DataSource = dt;

        }
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {

            if (FormLogin.quyen == false)
            {
                btnthemnv.Enabled = false;
                btnsuanv.Enabled = false;
                btnxoanv.Enabled = false;
            }
            else
            {
                btnthemnv.Enabled = true;
                btnsuanv.Enabled = true;
                btnxoanv.Enabled = true;
            }
            connect();
            getdata();
            //binding();
            disconect();

        }

        //private void binding()
        //{
        //    txtID.DataBindings.Clear();
        //    txtID.DataBindings.Add("Text", dvgnhanvien.DataSource, "ID");
        //    txthoten.DataBindings.Clear();
        //    txthoten.DataBindings.Add("Text", dvgnhanvien.DataSource, "hoten");
        //    dtpngaysinh.DataBindings.Clear();
        //    dtpngaysinh.DataBindings.Add("Text", dvgnhanvien.DataSource, "ngaysinh");
        //    txtquequan.DataBindings.Clear();
        //    txtquequan.DataBindings.Add("Text", dvgnhanvien.DataSource, "quequan");
        //    txtdiachi.DataBindings.Clear();
        //    txtdiachi.DataBindings.Add("Text", dvgnhanvien.DataSource, "diachi");
        //    txtsoCMND.DataBindings.Clear();
        //    txtsoCMND.DataBindings.Add("Text", dvgnhanvien.DataSource, "soCMND");
        //    txtemail.DataBindings.Clear();
        //    txtemail.DataBindings.Add("Text", dvgnhanvien.DataSource, "email");
        //    txtdienthoai.DataBindings.Clear();
        //    txtdienthoai.DataBindings.Add("Text", dvgnhanvien.DataSource, "dienthoai");
        //}
        private void btnthem_Click(object sender, EventArgs e)
        {
            FormThemNanhVien nv1 = new FormThemNanhVien();
            this.Hide();
            nv1.ShowDialog();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnsuanv_Click(object sender, EventArgs e)
        {
            txtdiachi.Enabled = true;
            txtdienthoai.Enabled = true;
            txtemail.Enabled = true;
            txthoten.Enabled = true;
            txtquequan.Enabled = true;
            txtsoCMND.Enabled = true;
            dtpngaysinh.Enabled = true;
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            NhanVien_obj nv = new NhanVien_obj();
            nv.IDNV = txtID.Text;
            nv.hotenNV = txthoten.Text;
            nv.ngaysinhNV = dtpngaysinh.Value;
            nv.emailNV = txtemail.Text;
            nv.dienthoaiNV = txtdienthoai.Text;
            nv.quequanNV = txtquequan.Text;
            nv.diachiNV = txtdiachi.Text;
            nv.soCMNDNV = txtsoCMND.Text;

            NhanVienBus bus = new NhanVienBus();
            int ret;
            ret = bus.update(nv);
            bus.close();
            if (ret < 0)
            {
                MessageBox.Show("Không sửa được dữ liệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            txtdiachi.Enabled = false;
            txtdienthoai.Enabled = false;
            txtemail.Enabled = false;
            txthoten.Enabled = false;
            txtquequan.Enabled = false;
            txtsoCMND.Enabled = false;
            dtpngaysinh.Enabled = true;
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                SqlCommand command = new SqlCommand("SP_DELETE_NHANVIEN", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id", txtID.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getdata();
            disconect();
           

        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dvgnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gt = this.dvgnhanvien.CurrentRow.Cells["gioitinh"].Value.ToString().Trim();
            if (gt == "True")
            {
                rdbnam.Checked = true;

            }
            else if (gt == "False")
            {
                rdbnu.Checked = true;

            }
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dvgnhanvien.DataSource, "ID");
            txthoten.DataBindings.Clear();
            txthoten.DataBindings.Add("Text", dvgnhanvien.DataSource, "hoten");
            dtpngaysinh.DataBindings.Clear();
            dtpngaysinh.DataBindings.Add("Text", dvgnhanvien.DataSource, "ngaysinh");
            txtquequan.DataBindings.Clear();
            txtquequan.DataBindings.Add("Text", dvgnhanvien.DataSource, "quequan");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dvgnhanvien.DataSource, "diachi");
            txtsoCMND.DataBindings.Clear();
            txtsoCMND.DataBindings.Add("Text", dvgnhanvien.DataSource, "soCMND");
            txtemail.DataBindings.Clear();
            txtemail.DataBindings.Add("Text", dvgnhanvien.DataSource, "email");
            txtdienthoai.DataBindings.Clear();
            txtdienthoai.DataBindings.Add("Text", dvgnhanvien.DataSource, "dienthoai");
            cmbChucVu.DataBindings.Clear();
            cmbChucVu.DataBindings.Add("Text",dvgnhanvien.DataSource,"CV_ID");
            cmbPhongBan.DataBindings.Clear();
            cmbPhongBan.DataBindings.Add("Text", dvgnhanvien.DataSource, "PB_ID");
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                connect();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_TIMKIEM_NHANVIEN";
                command.Parameters.Add(new SqlParameter("@id", txtTimKiem.Text));
                command.Parameters.Add(new SqlParameter("@hoten", txtTimKiem.Text));
                da.SelectCommand = command;
                da.Fill(dt);
                dvgnhanvien.DataSource = dt;
                disconect();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
