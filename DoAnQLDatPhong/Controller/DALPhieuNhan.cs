using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLDatPhong.Views;
using System.Data;
using System.Data.SqlClient;

namespace DoAnQLDatPhong.Controller
{
    class DALPhieuNhan
    {
            ConnectionString connectDB;
            SqlDataAdapter adapter;
            public DALPhieuNhan()
            {
                connectDB = new ConnectionString();
            }
            public DataTable LayDLPhieuNhanPhong()
            {
                string query = "select pn.MaPhieuNhan, MaPhieuThue,MaPhong, kh.TenKH,CMND,DiaChi,SDT,NgayNhan from PhieuNhanPhong pn, CT_PhieuNhanPhong ct, KhachHang kh where kh.MaKH = pn.MaKH and ct.MaPhieuNhan = pn.MaPhieuNhan";
                SqlConnection con = connectDB.getConnection();
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                DataTable dtPTP = new DataTable();
                adapter.Fill(dtPTP);
                con.Close();
                return dtPTP;
            }
            public DataSet LoadKH()
            {
                string query = "select TenKH,kh.MaKH from KhachHang kh,PhieuThuePhong pt where kh.MaKH = pt.MaKH";
                SqlConnection con = connectDB.getConnection();
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            public DataTable LoadPhong()
            {
                frmNhanPhong np = new frmNhanPhong();
                string query = "select MaPhong from CT_PhieuThuePhong ct, PhieuThuePhong pt, KhachHang kh where ct.MaPhieuThue = pt.MaPhieuThue and kh.MaKH = pt.MaKH ";
                SqlConnection con = connectDB.getConnection();
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            public DataTable LoadPT()
            {
                string query = "select MaPhieuThue from Phong,CT_PhieuThuePhong where Phong.MaPhong = CT_PhieuThuePhong.MaPhong";
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
