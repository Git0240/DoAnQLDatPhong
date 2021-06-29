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

namespace DoAnQLDatPhong.Views
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        ConnectionString connectDB;
        public static string user;
        public static string pq;
        public frmDangNhap()
        {
            InitializeComponent();
            connectDB = new ConnectionString();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Money Twins";
        }
        
        // Tạo sự kiện đăng nhập
        private void btnDangNhap1_Click(object sender, EventArgs e)
        {
            string query, pass;
            SqlConnection con = connectDB.getConnection();
                con.Open(); 
                user = txtUsername.Text;
                pass = txtPass.Text;
                query = "select LoaiNguoiDung from NguoiDung where TenDangNhap='" + user /*+ "'and MatKhau='" + pass */+ "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    //this.Hide();
                    //Form1 frm1 = new Form1();
                    //frm1.Show();
                    this.Hide();
                    string Msg = dr[0].ToString();
                    Form1 a = new Form1(Msg);
                    a.ShowDialog();
                }
                else
                {
                    DialogResult drt;
                    drt = (MessageBox.Show("Đăng nhập không thành công.Mời nhập lại!","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information));
                    if (drt == DialogResult.No)
                        Application.Exit();
                    else
                    {
                        txtUsername.Focus();
                        txtUsername.SelectAll();
                        txtPass.SelectAll();
                    }
                }
            
        }
        // Tạo sự kiện cho nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            skin();
        }
    }
}