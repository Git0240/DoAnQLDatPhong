using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAnQLDatPhong.Controller;
using System.Data.SqlClient;
using DoAnQLDatPhong.Models;

namespace DoAnQLDatPhong.Views
{
    public partial class frmPhong : DevExpress.XtraEditors.XtraForm
    {
        ConnectionString connectDB;
        SqlDataAdapter adapter;
        BLPhong blPhong;
        public frmPhong()
        {
            InitializeComponent();
            blPhong = new BLPhong();
            connectDB = new ConnectionString();
        }
        public void HienThiPhong()
        {
            DataTable dt = blPhong.LayDLPhong();
            dgvPhong.DataSource = dt;
        }
        
        public void LoadLoaiPhong()
        {
            string query = "select TenLoaiPhong,MaLoaiPhong from LoaiPhong";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lkLoaiPhong.Properties.DisplayMember = "TenLoaiPhong";
            lkLoaiPhong.Properties.ValueMember = "MaLoaiPhong";
            lkLoaiPhong.Properties.DataSource = dt;
            con.Close();
        }
        
        public void LoadTT()
        {
            string query = "select TenLoaiTT,MaLoaiTT from LoaiTinhTrang";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lkTT.Properties.DisplayMember = "TenLoaiTT";
            lkTT.Properties.ValueMember = "MaLoaiTT";
            lkTT.Properties.DataSource = dt;
            con.Close();
            
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            lkLoaiPhong.EditValue = lkLoaiPhong.Text;
            lkTT.EditValue = lkTT.Text;
            HamTuTang a = new HamTuTang();
            a.GetLastID("Phong", "MaPhong");
            string lastid = a.GetLastID("Phong", "MaPhong");
            string ID = a.NextID(lastid, "P");
            txtMaPhong.Text = ID;
            HienThiPhong();
            LoadLoaiPhong();
            LoadTT();
        }
       

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.MaPhong = txtMaPhong.Text;
            p.MaLoaiPhong = lkLoaiPhong.EditValue.ToString();
            p.MaLoaiTT = lkTT.EditValue.ToString();
            if (blPhong.ThemPhong(p))
            {
                MessageBox.Show("Thêm thành công phòng "+txtMaPhong.Text, "Thông báo");
                HienThiPhong();
            }
            else
            {
                MessageBox.Show("Lỗi","Thông báo");
            }
            
        }

        private void lkLoaiPhong_EditValueChanged(object sender, EventArgs e)
        {

            if (lkLoaiPhong.EditValue.ToString() == "LP01")
            {
                txtDonGia.Text = String.Format("{0:0,0 vnđ}", 1500000);
                txtSoNChuan.Text = 1.ToString();
                txtSoNToiDa.Text = 2.ToString();
            }
            if (lkLoaiPhong.EditValue.ToString() == "LP02")
            {
                txtDonGia.Text = String.Format("{0:0,0 vnđ}", 3000000);
                txtSoNChuan.Text = 2.ToString();
                txtSoNToiDa.Text = 4.ToString();
            }
            if (lkLoaiPhong.EditValue.ToString() == "LP03")
            {
                txtDonGia.Text = String.Format("{0:0,0 vnđ}", 4000000);
                txtSoNChuan.Text = 4.ToString();
                txtSoNToiDa.Text = 8.ToString();
            }
            
        }
        public void LocPhong()
        {
            DataTable dt = blPhong.LocDLPhong();
            dgvPhong.DataSource = dt;
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            
            LocPhong();
        }

       

        

    }
}