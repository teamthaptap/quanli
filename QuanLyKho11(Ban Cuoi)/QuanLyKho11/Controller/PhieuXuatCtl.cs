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
    class PhieuXuatCtl
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from PhieuXuat";
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

        public bool AddPhieuXuat(PhieuXuatObj pxObj)
        {
            cmd.CommandText = "Insert into PhieuXuat values ('" + pxObj.MaPX + "','" + pxObj.NgayXuat + "','" + pxObj.MaKH + "','" + pxObj.TongTien + "','" + pxObj.MaKho + "')";

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

        public bool DeletePhieuXuat(string ma)
        {
            cmd.CommandText = "Delete PhieuXuat where MaPX='" + ma + "'";
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
            return false;
        }
        public bool UpdatePhieuXuat(PhieuXuatObj pxObj)
        {
            cmd.CommandText = " update PhieuXuat set MaPX='" + pxObj.MaPX + "',NgayXuat='" + pxObj.NgayXuat + "',MaKH='" + pxObj.MaKH + "',TongTien='" + pxObj.TongTien + "',MaKho='" + pxObj.MaKho + "' where MaPN='" + pxObj.MaPX + "'";
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
