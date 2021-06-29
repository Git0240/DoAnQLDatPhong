using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnQLDatPhong.Views;
using DoAnQLDatPhong.Models;

namespace DoAnQLDatPhong.Controller
{
    class DALKhachHang
    {
        frmKhachHang frmKH;
        ConnectionString connectDB;
        SqlDataAdapter adapter;
        public DALKhachHang()
        {
            connectDB = new ConnectionString();
        }
        public DataTable LayDLKhachHang()
        {
            string query = "Select * from KhachHang";
            SqlConnection sqlconn = connectDB.getConnection();
            sqlconn.Open();
            adapter =  new SqlDataAdapter(query,sqlconn);
            DataTable dtKH = new DataTable();
            adapter.Fill(dtKH);
            sqlconn.Close();
            return dtKH;
        }
        //public bool KiemTraMaKH()
        //{
        //    frmKhachHang frmKH = new frmKhachHang();
        //    string makh = frmKH.txtMaKH.Text;
        //    string query = "select MaKH from KhachHang where MaKH = '"+makh+"'";
        //    SqlConnection con = connectDB.getConnection();
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    con.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }        
        //}
        public bool ThemKH(KhachHang kh)
        {
            HamTuTang a = new HamTuTang();
            a.GetLastID("KhachHang", "MaKH");
            string lastid = a.GetLastID("KhachHang", "MaKH");
            string ID = a.NextID(lastid, "KH");
            frmKH = new frmKhachHang();
            frmKH.txtMaKH.Text = ID;
            string query = "insert into KhachHang(MaKH,TenKH,CMND,Phai,DiaChi,SDT, QuocTich) values ('"+frmKH.txtMaKH.Text+"',@tenkh,@cmnd,@phai,@diachi,@sdt,@quoctich)";
            SqlConnection con = connectDB.getConnection();
            try 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@makh", SqlDbType.Char).Value = kh.MaKH;
                cmd.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = kh.TenKH;
                cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = kh.CMND;
                cmd.Parameters.Add("@Phai", SqlDbType.NVarChar).Value = kh.Phai;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = kh.DiaChi;
                cmd.Parameters.Add("@sdt", SqlDbType.Int).Value = kh.SDT;
                cmd.Parameters.Add("@quoctich", SqlDbType.NVarChar).Value = kh.QuocTich;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool XoaKH(KhachHang kh)
        {
            string query = "delete KhachHang where MaKH = @makh";
            SqlConnection con = connectDB.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.Add("@makh", SqlDbType.Char).Value = kh.MaKH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public bool SuaKH(KhachHang kh)
        {
            HamTuTang a = new HamTuTang();
            a.GetLastID("KhachHang", "MaKH");
            string lastid = a.GetLastID("KhachHang", "MaKH");
            string ID = a.NextID(lastid, "KH");
            frmKH = new frmKhachHang();
            frmKH.txtMaKH.Text = ID;
            string query = "update KhachHang set MaKH =@makh, TenKH = @tenkh, CMND = @cmnd, Phai = @phai, DiaChi = @diachi, SDT = @sdt, QuocTich = @quoctich where MaKH = @makh";
            SqlConnection con = connectDB.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@makh", SqlDbType.Char).Value = kh.MaKH;
                cmd.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = kh.TenKH;
                cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = kh.CMND;
                cmd.Parameters.Add("@Phai", SqlDbType.NVarChar).Value = kh.Phai;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = kh.DiaChi;
                cmd.Parameters.Add("@sdt", SqlDbType.Int).Value = kh.SDT;
                cmd.Parameters.Add("@quoctich", SqlDbType.NVarChar).Value = kh.QuocTich;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiemKH(string kh)
        {
            string query = "select * from KhachHang where TenKH like N'%"+kh+"%'";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
