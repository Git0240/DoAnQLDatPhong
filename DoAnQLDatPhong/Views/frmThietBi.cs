using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLDatPhong.Controller;
using System.Data.SqlClient;
using DoAnQLDatPhong.Models;

namespace DoAnQLDatPhong.Views
{
    public partial class frmThietBi : Form
    {
        ConnectionString connectDB;
        SqlDataAdapter adapter;
        BLThietBi blTB;
        public frmThietBi()
        {
            InitializeComponent();
            blTB = new BLThietBi();
            connectDB = new ConnectionString();
        }
        public void HienThiDLThietBi()
        {
            DataTable dt = blTB.LayDLThietBi();
            dgvThietBi.DataSource = dt;
        }
        public void LoadLoaiPhong()
        {
            string query = "select TenLoaiPhong from LoaiPhong";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lkLoaiPhongtb.Properties.DisplayMember = "TenLoaiPhong";
            lkLoaiPhongtb.Properties.ValueMember = "TenLoaiPhong";
            lkLoaiPhongtb.Properties.DataSource = dt;
            con.Close();
        }
        private void frmThietBi_Load(object sender, EventArgs e)
        {
            lkLoaiPhongtb.EditValue = lkLoaiPhongtb.Text;
            HamTuTang a = new HamTuTang();
            a.GetLastID("ThietBi", "MaThietBi");
            string lastid = a.GetLastID("ThietBi", "MaThietBi");
            string ID = a.NextID(lastid, "TB");
            txtMaTB.Text = ID;
            HienThiDLThietBi();
            LoadLoaiPhong();
            //this.Size = this.MaximunSize = MinximunSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi();
            tb.MaThietBi = txtMaTB.Text;
            tb.TenThietBi = txtTenTB.Text;
            tb.SoLuong = int.Parse(txtSoLuong.Text);
            tb.MaLoaiPhong = lkLoaiPhongtb.Text;
            if (blTB.ThemTB(tb))
            {
                MessageBox.Show("Thêm thành công thiết bị "+txtTenTB.Text);
                HienThiDLThietBi();
            }
            else
            {
                MessageBox.Show("Thêm thiết bị không thành công!","Thông báo");
            }
        }
    }
}
