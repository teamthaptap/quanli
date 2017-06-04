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
    class PhieuNhapCtl
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from PhieuNhap";
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

        public bool AddPhieuNhap(PhieuNhapObj pnObj)
        {
            cmd.CommandText = "Insert into PhieuNhap values ('" + pnObj.MaPN + "','" + pnObj.NgayNhap + "','" + pnObj.MaNCC + "','" + pnObj.TongTien + "','" + pnObj.MaKho + "')";

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

        public bool DeletePhieuNhap(string ma)
        {
            cmd.CommandText = "Delete PhieuNhap where MaPN='" + ma + "'";
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
        public bool UpdatePhieuNhap(PhieuNhapObj pnobj)
        {
            cmd.CommandText = " update PhieuNhap set MaPN='" + pnobj.MaPN + "',NgayNhap='" + pnobj.NgayNhap + "',MaKho='" + pnobj.MaKho + "',MaNCC='" + pnobj.MaNCC + "',TongTien='"+pnobj.TongTien+ "' where MaPN='" + pnobj.MaPN + "'";
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
