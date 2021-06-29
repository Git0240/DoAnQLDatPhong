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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        BLKhachHang blKH;
        public frmKhachHang()
        {
            InitializeComponent();
            blKH = new BLKhachHang();
        }
        public void HienThiThongTinKH()
        {
            DataTable dt = blKH.LayDuLieuKH();
            dgvKhachHang.DataSource = dt;
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            
            if (KiemTraDuLieu.KtraRong(txtTenKH, " tên khách hàng"))
            {
                if (KiemTraDuLieu.KtraKieuDL(txtCMND, " số chứng minh nhân dân"))
                    if (KiemTraDuLieu.KtraKieuDL(txtSDT, " số điện thoại"))
                    {
                        KhachHang kh = new KhachHang();
                        kh.MaKH = txtMaKH.Text;
                        kh.TenKH = txtTenKH.Text;
                        kh.CMND = txtCMND.Text;
                        kh.Phai = cbGioiTinh.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        kh.SDT = int.Parse(txtSDT.Text);
                        kh.QuocTich = txtQuocTich.Text;
                        if (blKH.ThemKh(kh))
                        {
                            XtraMessageBox.Show("Đã thêm thành công khách hàng " + txtTenKH.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HienThiThongTinKH();
                            txtTenKH.Text = "";
                            txtSDT.Text = "";
                            txtCMND.Text = "";
                            txtDiaChi.Text = "";
                            txtQuocTich.Text = "";
                            cbGioiTinh.Text = "";
                            txtTenKH.Focus();
                        }
                        else
                        {
                            XtraMessageBox.Show("Không thêm được", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
            }
           
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HamTuTang a = new HamTuTang();
            a.GetLastID("KhachHang", "MaKH");
            string lastid = a.GetLastID("KhachHang", "MaKH");
            string ID = a.NextID(lastid, "KH");
            txtMaKH.Text = ID;
            HienThiThongTinKH();
            txtTenKH.Focus();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
                XtraMessageBox.Show("Bạn phải chọn khách hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = txtMaKH.Text;
                if (blKH.XoaKH(kh))
                {
                    XtraMessageBox.Show("Xóa thành công khách hàng " + txtTenKH.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiThongTinKH();
                    txtTenKH.Text = "";
                    txtSDT.Text = "";
                    txtCMND.Text = "";
                    txtDiaChi.Text = "";
                    txtQuocTich.Text = "";
                    cbGioiTinh.Text = "";
                    txtTenKH.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    txtMaKH.Text = gridView1.GetRowCellValue(e.RowHandle, "MaKH").ToString();
        //    txtTenKH.Text = gridView1.GetRowCellValue(e.RowHandle, "TenKH").ToString();
        //    txtCMND.Text = gridView1.GetRowCellValue(e.RowHandle, "CMND").ToString();
        //    txtSDT.Text = gridView1.GetRowCellValue(e.RowHandle, "SDT").ToString();
        //    cbGioiTinh.Text = gridView1.GetRowCellValue(e.RowHandle, "Phai").ToString();
        //    txtDiaChi.Text = gridView1.GetRowCellValue(e.RowHandle, "DiaChi").ToString();
        //    txtQuocTich.Text = gridView1.GetRowCellValue(e.RowHandle, "QuocTich").ToString();
        //}

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
                XtraMessageBox.Show("Bạn phải chọn khách hàng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = txtMaKH.Text;
                kh.TenKH = txtTenKH.Text;
                kh.CMND = txtCMND.Text;
                kh.Phai = cbGioiTinh.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.SDT = int.Parse(txtSDT.Text);
                kh.QuocTich = txtQuocTich.Text;
                if (blKH.SuaKH(kh))
                {
                    XtraMessageBox.Show("Đã sửa thành công khách hàng " + txtTenKH.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiThongTinKH();
                    txtTenKH.Text = "";
                    txtSDT.Text = "";
                    txtCMND.Text = "";
                    txtDiaChi.Text = "";
                    txtQuocTich.Text = "";
                    cbGioiTinh.Text = "";
                }
                else
                {
                    XtraMessageBox.Show("Không sửa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtSearchKH_EditValueChanged(object sender, EventArgs e)
        {
            string kh = txtSearchKH.EditValue.ToString();
            if (kh != "")
            {
                DataTable dt = blKH.TimLiemKH(kh);
                dgvKhachHang.DataSource = dt;
            }
            else
            {
                XtraMessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiThongTinKH();
            }
        }

        private void btnLamMoiKh_Click(object sender, EventArgs e)
        {
            HienThiThongTinKH();
        }

        private void btnThoatKh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInKH_Click(object sender, EventArgs e)
        {
            Print pr = new Print();
            pr.Show();
        }

        private void dgvKhachHang_DoubleClick(object sender, EventArgs e)
        {
            txtMaKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
            txtTenKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenKH").ToString();
            txtCMND.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
            txtSDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
            cbGioiTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Phai").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
            txtQuocTich.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "QuocTich").ToString();
        }

        //private void dgvKhachHang_Click(object sender, EventArgs e)
        //{
        //    txtMaKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
        //    txtTenKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenKH").ToString();
        //    txtCMND.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
        //    txtSDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
        //    cbGioiTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Phai").ToString();
        //    txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
        //    txtQuocTich.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "QuocTich").ToString();
        //}

       
    }
}