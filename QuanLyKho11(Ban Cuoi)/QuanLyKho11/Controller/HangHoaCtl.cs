using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho11.Model;

namespace QuanLyKho11.Controller
{
    class HangHoaCtl
    {

        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        /// <summary>
        /// Hàm lấy dữ liệu . Trả về 1 data table
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from HangHoa";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConnection();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return dt;
        }

        /// <summary>
        /// Hàm Thêm nhân viên vào danh sách
        /// </summary>
        /// <param name="hhobj">đối tượng cần thêm vào ds</param>
        public bool AddHangHoa(HangHoaObj hhobj)
        {
            cmd.CommandText = "Insert into HangHoa values ('" + hhobj.MaHang + "','" + hhobj.TenHang + "','" + hhobj.DonViTinh + "','" + hhobj.Ton + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return true;
        }

        /// <summary>
        /// Hàm xóa một nhân viên ra khỏi danh sách
        /// </summary>
        /// <param name="ma"> mã nhân viên cần xóa</param>
        public bool DelHangHoa(string ma)
        {
            cmd.CommandText = "delete HangHoa where MaHang= '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                cmd.ExecuteNonQuery();
                con.CloseConnection();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return true;
        }

        /// <summary>
        /// Hàm sửa thông tin một nhân viên
        /// </summary>
        /// <param name="hhobj"> đối tượng nhân viên cần sửa</param>
        public bool UpdateHangHoa(HangHoaObj hhobj)
        {
            cmd.CommandText = " update HangHoa set MaHang='" + hhobj.MaHang + "',TenHang='" + hhobj.TenHang + "',DonViTinh='" + hhobj.DonViTinh + "',Ton='" + hhobj.Ton + "' where MaHang='" + hhobj.MaHang + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return true;
        }
    }
}
