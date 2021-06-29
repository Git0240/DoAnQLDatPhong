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
using System.Data.SqlClient;
using DoAnQLDatPhong.Controller;
using DoAnQLDatPhong.Models;

namespace DoAnQLDatPhong.Views
{
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        
        ConnectionString connectDB;
        SqlDataAdapter adapter;
        BLNguoiDung blnd;
        public frmPhanQuyen()
        {
            InitializeComponent();
            connectDB = new ConnectionString();
            blnd = new BLNguoiDung();
        }
        public void LoadTaiKhoan()
        {
            string query = "select TenDangNhap from NguoiDung";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbTk.DataSource = dt;
            cbTk.DisplayMember = "TenDangNhap";
            cbTk.ValueMember = "TenDangNhap";
            con.Close();
        }
        public void LoadPQ()
        {
            String sql1 = "select * from LoaiNguoiDung";
            SqlConnection con = connectDB.getConnection();
            adapter = new SqlDataAdapter(sql1, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbPQ.DataSource = dt;
            cbPQ.DisplayMember = "TenLoaiNguoiDung";
            cbPQ.ValueMember = "LoaiNguoiDung";
            con.Close();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            LoadPQ();
            LoadTaiKhoan();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();
            nd.TenDangNhap = cbTk.Text;
            nd.LoaiNguoiDung = int.Parse(cbPQ.SelectedValue.ToString());
            if (blnd.SuaPQ(nd))
            {
                XtraMessageBox.Show("Phân quyền thành công", "Thông báo");
            }
            else
            {
                XtraMessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}