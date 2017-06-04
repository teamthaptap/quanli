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
    class ChiTietPhieuXuatCtl
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select ct.MaPX,hh.MaHang,ct.DonGia,ct.SLThuc,ct.ThanhTien from ChiTietPhieuXuat ct,HangHoa hh where ct.MaHang = hh.MaHang and MaPX='" + ma + "'";
            //cmd.CommandText = "select ct.MaPX,hh.TenHang,ct.DonGia,ct.SLThuc from ChiTietPhieuXuat ct,HangHoa hh where ct.MaMang = hh.MaMang and MaPX='" + ma + "'";
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

        public bool AddChiTietPhieuXuat(ChiTietPhieuXuatObj ctobj)
        {




            cmd.CommandText = "Insert into ChiTietPhieuXuat values('" + ctobj.MaPX1 + "','" + ctobj.MaHang1 + "','" + ctobj.SLThuc1 + "','" + ctobj.DonGia1 + "','" + ctobj.ThanhTien1 + "')";
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

        public bool DeleteChiTietPhieuXuat(string ma)
        {
            cmd.CommandText = "Delete ChiTietPhieuXuat where MaHang='" + ma + "'";
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
        public bool UpdateChiTietPhieuXuat(ChiTietPhieuXuatObj ctobj)
        {
            cmd.CommandText = " update ChiTietPhieuXuat set MaPX='" + ctobj.MaPX1 + "',MaHang='" + ctobj.MaHang1 + "',DonGia='" + ctobj.DonGia1 + "',SLThuc='" + ctobj.SLThuc1 + "',ThanhTien='" + ctobj.ThanhTien1 + "' where MaPX='" + ctobj.MaPX1 + "'";
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
