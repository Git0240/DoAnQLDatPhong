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
using System.Data;
using System.Data.SqlClient;

namespace DoAnQLDatPhong.Views
{
    public partial class frmDoiMK : DevExpress.XtraEditors.XtraForm
    {
        ConnectionString connectDB;
        SqlDataAdapter adapter;
        public frmDoiMK()
        {
            InitializeComponent();
            connectDB = new ConnectionString();
        }
        public void LoadNguoiDung()
        {
            string query = "select TenDangNhap from NguoiDung";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbtendn.DataSource = dt;
            cbtendn.DisplayMember = "TenDangNhap";
            cbtendn.ValueMember = "TenDangNhap";
            con.Close();
        }
        public bool KtraMk()
        {
            String matkhau = txtMKCu.Text;
            String sql = "Select MatKhau from NguoiDung  where   MatKhau ='" + matkhau + "'";
            SqlConnection con = connectDB.getConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            LoadNguoiDung();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (KtraMk() == true)
            {
                string query = "update NguoiDung set MatKhau = '"+txtMKMoi.Text+"'where TenDangNhap ='"+cbtendn.Text+"'";
                SqlConnection con = connectDB.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteReader();
                con.Close();
                XtraMessageBox.Show("Đổi mật khẩu thành công!.Đăng nhập lại", "Thông báo");
                this.Hide();
                frmDangNhap dn = new frmDangNhap();
                dn.Show();
            }
            else
            {
                XtraMessageBox.Show("Sai mật khẩu. Mời nhập lại", "Thông báo");
                txtMKCu.Focus();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}