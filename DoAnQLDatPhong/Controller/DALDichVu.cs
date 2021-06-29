using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnQLDatPhong.Views;
using DoAnQLDatPhong.Models;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAnQLDatPhong.Controller
{
    class DALDichVu
    {
        frmDichVu frmDV;
        ConnectionString connectDB;
        SqlDataAdapter adapter;
        public DALDichVu()
        {
            connectDB = new ConnectionString();
        }
        public DataTable LayDLDichVu()
        {
            string query = "select * from DichVu";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        //public bool KiemTraMaDV()
        //{
        //    frmDV = new frmDichVu();
        //    string madv = frmDV.txtMaDV.Text;
        //    string query = "select MaDV from DichVu where MaDV = '" + madv + "'";
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
        public bool ThemDV(DichVu dv)
        {
            HamTuTang a = new HamTuTang();
            a.GetLastID("DichVu", "MaDV");
            string lastid = a.GetLastID("DichVu", "MaDV");
            string ID = a.NextID(lastid, "DV");
            frmDV = new frmDichVu();
            frmDV.txtMaDV.Text = ID;
            string query = "insert into DichVu(MaDV,TenDV,DonVi,DonGia) values('" + frmDV.txtMaDV.Text + "',@tendv,@donvi,@dongia)";
            SqlConnection con = connectDB.getConnection();
            try {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@madv", SqlDbType.Char).Value = dv.MaDV;
                cmd.Parameters.Add("@tendv", SqlDbType.NVarChar).Value = dv.TenDV;
                cmd.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = dv.DonVi;
                cmd.Parameters.Add("@dongia", SqlDbType.Float).Value = dv.DonGia;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
            
        }
        public bool XoaDV(DichVu dv)
        {
            string query = "delete DichVu where MaDV = @madv";
            SqlConnection con = connectDB.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@madv", SqlDbType.Char).Value = dv.MaDV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool SuaDV(DichVu dv)
        {
            HamTuTang a = new HamTuTang();
            a.GetLastID("DichVu", "MaDV");
            string lastid = a.GetLastID("DichVu", "MaDV");
            string ID = a.NextID(lastid, "DV");
            frmDV = new frmDichVu();
            frmDV.txtMaDV.Text = ID;
            string query = "update DichVu set MaDV = @madv,TenDV = @tendv ,DonVi = @donvi,DonGia= @dongia where MaDV = @madv";
            SqlConnection con = connectDB.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@madv", SqlDbType.Char).Value = dv.MaDV;
                cmd.Parameters.Add("@tendv", SqlDbType.NVarChar).Value = dv.TenDV;
                cmd.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = dv.DonVi;
                cmd.Parameters.Add("@dongia", SqlDbType.Float).Value = dv.DonGia;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;

        }
        public DataTable TimKiemDV(string dv)
        {
            string query = "select * from DichVu where TenDV like N'%" + dv + "%'";
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
