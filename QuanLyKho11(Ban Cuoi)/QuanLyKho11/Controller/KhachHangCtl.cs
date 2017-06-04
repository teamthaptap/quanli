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
    class KhachHangCtl
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
            cmd.CommandText = "select * from KhachHang";
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
        /// <param name="khobj">đối tượng cần thêm vào ds</param>
        public bool AddKhachHang(KhachHangObj khobj)
        {
            cmd.CommandText = "Insert into KhachHang values ('" + khobj.MaKH + "','" + khobj.TenKH + "','" + khobj.DiaChi + "','" + khobj.SDT + "')";
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
        public bool DelKhachHang(string ma)
        {
            cmd.CommandText = "delete KhachHang where MaKH= '" + ma + "'";
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
        /// <param name="khobj"> đối tượng nhân viên cần sửa</param>
        public bool UpdateKhachHang(KhachHangObj khobj)
        {
            cmd.CommandText = " update KhachHang set MaKH='" + khobj.MaKH + "',TenKH='" + khobj.TenKH + "',SDT='" + khobj.SDT + "',DiaChi='" + khobj.DiaChi + "' where MaKH='" + khobj.MaKH + "'";
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
