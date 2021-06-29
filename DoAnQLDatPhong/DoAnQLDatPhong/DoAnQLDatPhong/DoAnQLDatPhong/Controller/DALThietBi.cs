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
    class DALThietBi
    {
        frmThietBi frmTB;
        ConnectionString connectDB;
        SqlDataAdapter adapter;
        public DALThietBi()
        {
            connectDB = new ConnectionString();
        }
        public DataTable LayDLThietBi()
        {
            string query = "select MaThietBi,TenThietBi,TenLoaiPhong,SoLuong from ThietBi,LoaiPhong where ThietBi.MaLoaiPhong = LoaiPhong.MaLoaiPhong";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public bool ThemTB(ThietBi tb)
        {
            HamTuTang a = new HamTuTang();
            a.GetLastID("ThietBi", "MaTB");
            string lastid = a.GetLastID("ThietBi", "MaTB");
            string ID = a.NextID(lastid, "TB");
            frmTB = new frmThietBi();
            frmTB.txtMaTB.Text = ID;
            string query = "insert into ThietBi(MaThietBi,TenThietBi,SoLuong,MaLoaiPhong) values('" + frmTB.txtMaTB.Text + "',@tentb,@soluong,@malp)";
            SqlConnection con = connectDB.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@matb", SqlDbType.Char).Value = tb.MaThietBi;
                cmd.Parameters.Add("@tentb", SqlDbType.NVarChar).Value = tb.TenThietBi;
                cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = tb.SoLuong;
                cmd.Parameters.Add("@malp", SqlDbType.Float).Value = tb.MaLoaiPhong;
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
