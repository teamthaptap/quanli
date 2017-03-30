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
    public partial class FormConnect : Form
    {
        public FormConnect()
        {
            InitializeComponent();
        }

        private void FormConnect_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Vui lòng nhập sever để kết nối với CSDL";
            cbbAuthen.SelectedIndex = 0;
        }
       
        private void EnableControl(bool b)
        {

            txtUserName.Enabled = b;
            txtPassWord.Enabled = b;
            label3.Enabled = b;
            label4.Enabled = b;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (cbbListDB.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn 1 csdl.");
                return;
            }


            if (cbbAuthen.SelectedIndex == 0)
            {
                globalParameter.str = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + cbbListDB.SelectedValue.ToString() + ";Integrated Security=True";
            }
            else
            {
                globalParameter.str = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + cbbListDB.SelectedValue.ToString() + ";User ID=" + txtUserName.Text.Trim() + ";password=" + txtPassWord.Text.Trim();
            }

            SqlConnection con = new SqlConnection(globalParameter.str);
            con.Open();
            try
            {


                SqlCommand cmd = new SqlCommand("TESTCONNECTION", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader ren = cmd.ExecuteReader();

                bool flag = false;

                while (ren.Read())
                {
                    if (ren[0].ToString().Equals("True"))
                    {
                        flag = true;
                    }
                    break;
                }
                con.Close();

                if (flag)
                {
                    this.Hide();
                    new FormLogin().Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đúng CSDL. Mặc định là ...");
                }
            }
            catch
            {
                con.Close();
                MessageBox.Show("Vui lòng chọn đúng CSDL. Mặc định là ...");
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbbAuthen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAuthen.SelectedIndex == 0)
            {
                EnableControl(false);
            }
            else
            {
                EnableControl(true);
            }
        }

        private void btnldl_Click(object sender, EventArgs e)
        {
            if (cbbAuthen.SelectedIndex == 0)
            {
                globalParameter.str = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=master;Integrated Security=True";
            }
            else
            {
                globalParameter.str = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=master;User ID=" + txtUserName.Text.Trim() + ";password=" + txtPassWord.Text.Trim();
            }


            SqlConnection con = new SqlConnection(globalParameter.str);

            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases WHERE name not in('master','model','msdb','tempdb','ReportServer','ReportServerTempDB')", con);

                DataTable table = new DataTable();
                da.Fill(table);

                da.Dispose();

                con.Close();

                cbbListDB.DataSource = table;
                cbbListDB.DisplayMember = "name";
                cbbListDB.ValueMember = "name";

                label5.Enabled = true;
                cbbListDB.Enabled = true;

                btnldl.Enabled = false;
                btnknCSDL.Enabled = true;

                label1.Enabled = false;
                txtServerName.Enabled = false;

                cbbAuthen.Enabled = false;

                EnableControl(false);

            }
            catch (Exception ex)
            {
                btnknCSDL.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
