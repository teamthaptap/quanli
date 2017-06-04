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
    class ChiTietPhieuNhapCtl
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select ct.MaPN,hh.TenHang,ct.DonGia,ct.SLThuc,ct.ThanhTien from ChiTietPhieuNhap ct,HangHoa hh where ct.MaHang = hh.MaHang and MaPN='" + ma+ "'";
            //cmd.CommandText = "select ct.MaPN,hh.TenHang,ct.DonGia,ct.SLThuc from ChiTietPhieuNhap ct,HangHoa hh where ct.MaMang = hh.MaMang and MaPN='" + ma + "'";
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

        public bool AddChiTietPhieuNhap(ChiTietPhieuNhapObj ctobj)
        {

           
                
              
                    cmd.CommandText = "Insert into ChiTietPhieuNhap values('" + ctobj.MaPN1 + "','" + ctobj.MaHang1 + "','" + ctobj.SLThuc1 + "','" + ctobj.DonGia1 + "','" + ctobj.ThanhTien1 + "')";
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

        public bool DeleteChiTietPhieuNhap(string ma)
        {
            cmd.CommandText = "Delete ChiTietPhieuNhap where MaHang='" + ma + "'";
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
        public bool UpdateChiTietPhieuNhap(ChiTietPhieuNhapObj ctobj)
        {
            cmd.CommandText = " update ChiTietPhieuNhap set MaPN='" + ctobj.MaPN1 + "',MaHang='" + ctobj.MaHang1 + "',DonGia='" + ctobj.DonGia1 + "',SLThuc='" + ctobj.SLThuc1 + "',ThanhTien='" + ctobj.ThanhTien1 + "' where MaPN='" + ctobj.MaPN1 + "'";
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
