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
    class DALPhong
    {
        frmPhong frmP;
        ConnectionString connectDB;
        SqlDataAdapter adapter;
        public DALPhong()
        {
            connectDB = new ConnectionString();
        }
        public DataTable LayDLPhong()
        {
            string query = "select MaPhong,TenLoaiPhong,TenLoaiTT,SoNguoiChuan,SoNguoiToiDa,DonGia from Phong,LoaiPhong,LoaiTinhTrang where Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong and Phong.MaLoaiTT = LoaiTinhTrang.MaLoaiTT";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public bool ThemPhong(Phong p)
        {
            HamTuTang a = new HamTuTang();
            a.GetLastID("Phong", "MaPhong");
            string lastid = a.GetLastID("Phong", "MaPhong");
            string ID = a.NextID(lastid, "P");
            frmP = new frmPhong();
            frmP.txtMaPhong.Text = ID;
            string query = "insert into Phong(MaPhong,MaLoaiPhong,MaLoaiTT) values('" + frmP.txtMaPhong.Text + "',@malp,@maltt)";
            SqlConnection con = connectDB.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@maphong", SqlDbType.Char).Value = p.MaPhong;
                cmd.Parameters.Add("@malp", SqlDbType.Char).Value = p.MaLoaiPhong;
                cmd.Parameters.Add("@maltt", SqlDbType.Char).Value = p.MaLoaiTT;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;

        }
        public DataTable LocDLPhong()
        {
            string query = "select MaPhong,TenLoaiPhong,TenLoaiTT,SoNguoiChuan,SoNguoiToiDa,DonGia from Phong,LoaiPhong,LoaiTinhTrang where Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong and Phong.MaLoaiTT = LoaiTinhTrang.MaLoaiTT and LoaiTinhTrang.MaLoaiTT = 'TT01'";
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
