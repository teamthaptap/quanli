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

namespace ThuctapNhom
{
    public partial class FormThongTinPhongBan : Form
    {
        public String mapb;
        public FormThongTinPhongBan()
        {
            InitializeComponent();
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(globalParameter.str);
            conn.Open();
            String a = @"select COUNT(*) from (
                               select nv.hoten,cv.ten as[chucvu], pb.ten[phongban],pb.dienthoai,pb.email 
                               from PHONGBAN pb left join NHANVIEN nv on nv.PB_ID = pb.ID
                               left join CHUCVU cv on cv.ID = nv.CV_ID
                               where pb.ID = '"+mapb+"') as a";

            String b = @"select pb.ten
                               from PHONGBAN pb 
                               where pb.ID = '" + mapb + "'";
           
            SqlCommand cm = new SqlCommand(a, conn);
            txtsoluongnv.Text = cm.ExecuteScalar().ToString();
            SqlCommand cm1 = new SqlCommand(b, conn);
            lbltenphongban.Text = cm1.ExecuteScalar().ToString();
            connect();
            getdata();
            disconect();
        }
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblPHONGBAN");
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
            command.CommandText = @"select nv.hoten,cv.ten as[chucvu], pb.ten[phongban],pb.dienthoai,pb.email 
                                    from PHONGBAN pb left join NHANVIEN nv on nv.PB_ID = pb.ID
                                    left join CHUCVU cv on cv.ID = nv.CV_ID
                                    where pb.ID = '"+mapb+"' order by nv.CV_ID";
            da.SelectCommand = command;
            da.Fill(dt);
            dvgphongban.DataSource = dt;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
