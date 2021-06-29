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
    class DALNguoiDung
    {
        ConnectionString connectDB;
        SqlDataAdapter adapter;
        public DALNguoiDung()
        {
            connectDB = new ConnectionString();
        }
        public DataTable LoadPQ()
        {
            string query = "select LoaiNguoiDung from LoaiNguoiDung";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public bool ThemND(NguoiDung nd)
        {
            string query = "insert into NguoiDung(TenDangNhap,MatKhau,LoaiNguoiDung) values (@tendn,@mk,@lnd)";
            SqlConnection con = connectDB.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@tendn", SqlDbType.VarChar).Value = nd.TenDangNhap;
                cmd.Parameters.Add("@mk", SqlDbType.VarChar).Value = nd.MatKhau;
                cmd.Parameters.Add("@lnd", SqlDbType.Int).Value = nd.LoaiNguoiDung;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool SuaPQ(NguoiDung nd)
        {
            string query = "update NguoiDung set LoaiNguoiDung = @lnd  where TenDangNhap = @tendn";
            SqlConnection con = connectDB.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@lnd", SqlDbType.Int).Value = nd.LoaiNguoiDung;
                cmd.Parameters.Add("@tendn", SqlDbType.VarChar).Value = nd.TenDangNhap;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
