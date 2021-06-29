using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnQLDatPhong.Views;

namespace DoAnQLDatPhong.Controller
{
    class DALPhieuThuePhong
    {
        frmPhieuThuePhong frmPTP;
        ConnectionString connectDB;
        SqlDataAdapter adapter;
        public DALPhieuThuePhong()
        {
            connectDB = new ConnectionString();
        }
        public DataTable LoadKH()
        {
            string query = "select * from KhachHang";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable LoadPhongTrong()
        {
            string query = "select MaPhong from Phong,LoaiTinhTrang where Phong.MaLoaiTT = LoaiTinhTrang.MaLoaiTT and LoaiTinhTrang.MaLoaiTT = 'TT01'";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable LayDLPhieuNhanPhong()
        {
            string query = "Select pt.MaPhieuThue, TenKH, p.MaPhong, DonGia, NgayDangKi, NgayNhan from PhieuThuePhong pt, KhachHang kh, CT_PhieuThuePhong ct, Phong p, LoaiPhong lp where pt.MaPhieuThue =ct.MaPhieuThue and kh.MaKH = pt.MaKH and ct.MaPhong = p.MaPhong and p.MaLoaiPhong = lp.MaLoaiPhong";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter =  new SqlDataAdapter(query,con);
            DataTable dtPTP = new DataTable();
            adapter.Fill(dtPTP);
            con.Close();
            return dtPTP;
        }
    }
}
