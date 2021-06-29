using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using DevExpress.XtraEditors;
using DoAnQLDatPhong.Controller;
using DoAnQLDatPhong.Models;

namespace DoAnQLDatPhong.Views
{
    public partial class frmDangKi : Form
    {
        ConnectionString connectDB;
        BLNguoiDung blnd;
        public frmDangKi()
        {
            InitializeComponent();
            connectDB = new ConnectionString();
            blnd = new BLNguoiDung();
        }
        
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();
            nd.TenDangNhap = txtDkUsername.Text;
            nd.MatKhau = txtDkMatKhau.Text;
            nd.LoaiNguoiDung = int.Parse(2.ToString());
            if (KiemTraDuLieu.KtraRong(txtDkUsername, " tên đăng nhập"))
            {
                if (KiemTraDuLieu.KtraRong(txtDkMatKhau, " mật khẩu") && KiemTraDuLieu.KtraRong(txtDkMatKhauNhapLai, " lại mật khẩu"))
                {
                    if (txtDkMatKhau.Text == txtDkMatKhauNhapLai.Text)
                    {
                        if (blnd.ThemND(nd))
                        {
                            XtraMessageBox.Show("Đã đăng kí thành công. Mời đăng nhập", "Thông báo");
                            this.Hide();
                            frmDangNhap dn = new frmDangNhap();
                            dn.Show();
                        }
                        else
                        {
                            XtraMessageBox.Show("Đăng kí không thành công", "Thông báo");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo");
                    }
                }
                
            }
            
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {
 
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
