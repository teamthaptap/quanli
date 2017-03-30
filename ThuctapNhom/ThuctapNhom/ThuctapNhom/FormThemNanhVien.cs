using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ThuctapNhom
{
    public partial class FormThemNanhVien : Form
    {
        public FormThemNanhVien()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
        NhanVien_obj nv;
        private void btLuu_Click(object sender, EventArgs e)
        {
            nv = new NhanVien_obj();
            try
            {
                if (datetimeNgaySinh.Value < DateTime.Today)
                {
                    nv.ngaysinhNV = datetimeNgaySinh.Value;
                    nv.IDNV = txtID.Text;
                    nv.hotenNV = txtHoten.Text;



                    if (rdbNam.Checked == true)
                    {
                        nv.gioitinhNV = true;
                    }
                    else if (rdbNu.Checked == true)
                    {
                        nv.gioitinhNV = false;
                    }
                    nv.quequanNV = txtQuequan.Text;
                    nv.diachiNV = txtDiachi.Text;
                    nv.emailNV = txtEmail.Text;
                    nv.dienthoaiNV = txtDienthoai.Text;
                    nv.soCMNDNV = txtCMND.Text;
                    nv.PB_IDNV = cmbTenPhongBan.SelectedValue.ToString();
                    nv.CV_IDNV = cmbChucVu.SelectedValue.ToString();


                    NhanVienBus bus = new NhanVienBus();
                    int ret;
                    ret = bus.insert(nv);
                    bus.close();
                    if (ret < 0)
                    {
                        MessageBox.Show("Khong ghi duoc du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ghi thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai ngày!!!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa nhập đầy đủ dữ liệu!!!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtHoten.Clear();
            txtEmail.Clear();
            txtDienthoai.Clear();
            txtDiachi.Clear();
            txtCMND.Clear();
            txtQuequan.Clear();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormNhanVien nv = new FormNhanVien();
            nv.ShowDialog();
        }

        private void FormThemNanhVien_Load(object sender, EventArgs e)
        {
            getdata();
        }
        private void getdata()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            DataTable data1 = new DataTable();
            DataTable data = new DataTable();
            cm.Connection = con;

            cm.CommandText = "select * from chucvu";
            da.SelectCommand = cm;
            da.Fill(data);
            cmbChucVu.DataSource = data;
            cmbChucVu.DisplayMember = "ten";
            cmbChucVu.ValueMember = "ID";
            cmbChucVu.SelectedValue = "ID";

            cm.CommandText = "select * from PhongBan";
            da.SelectCommand = cm;
            da.Fill(data1);
            cmbTenPhongBan.DataSource = data1;
            cmbTenPhongBan.DisplayMember = "ten";
            cmbTenPhongBan.ValueMember = "ID";
            cmbTenPhongBan.SelectedValue = "ID";

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
