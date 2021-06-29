using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAnQLDatPhong.Controller;
using DoAnQLDatPhong.Models;

namespace DoAnQLDatPhong.Views
{
    public partial class frmDichVu : DevExpress.XtraEditors.XtraForm
    {
        BLDichVu bldv;
        ConnectionString connectDB;
        public frmDichVu()
        {
            InitializeComponent();
            bldv = new BLDichVu();
            connectDB = new ConnectionString();
        }
        public void HienThiDLDichVu()
        {
            DataTable dt = bldv.LayDLDichVu();
            dgvDV.DataSource = dt;
        }
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            HamTuTang a = new HamTuTang();
            a.GetLastID("DichVu", "MaDV");
            string lastid = a.GetLastID("DichVu", "MaDV");
            string ID = a.NextID(lastid, "DV");
            txtMaDV.Text = ID;
            HienThiDLDichVu();
            txtTenDV.Focus();

        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.MaDV = txtMaDV.Text;
            dv.TenDV = txtTenDV.Text;
            dv.DonVi = txtDonVi.Text;
            dv.DonGia = float.Parse(txtDonGia.Text);
            string query = "select TenDV from DichVu where TenDV = N'" + txtTenDV.Text + "'";
            SqlConnection con = connectDB.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                XtraMessageBox.Show("Tên dịch vụ đã tồn tại. Vui lòng đổi tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (bldv.ThemDV(dv))
                {
                    MessageBox.Show("Thêm dịch vụ " + txtTenDV.Text + " thành công", "Thông báo");
                    HienThiDLDichVu();
                    txtTenDV.Text = "";
                    txtDonVi.Text = "";
                    txtDonGia.Text = "";
                }
                else
                    MessageBox.Show("Thêm không thành công", "Thông báo");
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text == "")
                XtraMessageBox.Show("Bạn phải chọn dịch vụ để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DichVu dv = new DichVu();
                dv.MaDV = txtMaDV.Text;
                if (bldv.XoaDV(dv))
                {
                    XtraMessageBox.Show("Xóa thành công dịch vụ " + txtTenDV.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDLDichVu();
                    txtTenDV.Text = "";
                    txtDonVi.Text = "";
                    txtDonGia.Text = "";
                }
                else
                {
                    XtraMessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text == "")
                XtraMessageBox.Show("Bạn phải chọn dịch vụ để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DichVu dv = new DichVu();
                dv.MaDV = txtMaDV.Text;
                dv.TenDV = txtTenDV.Text;
                dv.DonVi = txtDonVi.Text;
                dv.DonGia = float.Parse(txtDonGia.Text);
                string query = "select TenDV from DichVu where TenDV = N'" + txtTenDV.Text + "'";
                SqlConnection con = connectDB.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    XtraMessageBox.Show("Tên dịch vụ đã tồn tại. Vui lòng đổi tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (bldv.SuaDV(dv))
                    {
                        XtraMessageBox.Show("Đã sửa thành công khách hàng " + txtTenDV.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDLDichVu();
                        txtTenDV.Text = "";
                        txtDonVi.Text = "";
                        txtDonGia.Text = "";
                    }
                    else
                    {
                        XtraMessageBox.Show("Không sửa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }
        private void dgvDV_DoubleClick(object sender, EventArgs e)
        {
            txtMaDV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaDV").ToString();
            txtTenDV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenDV").ToString();
            txtDonVi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DonVi").ToString();
            txtDonGia.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DonGia").ToString();
        }

        private void txtTimKiemDV_EditValueChanged(object sender, EventArgs e)
        {
            string dv = txtTimKiemDV.EditValue.ToString();
            if (dv != "")
            {
                DataTable dt = bldv.TimKiemDV(dv);
                dgvDV.DataSource = dt;
            }
            else
            {
                XtraMessageBox.Show("Không tìm thấy dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDLDichVu();
            }
        }

        private void btnLamMoiDV_Click(object sender, EventArgs e)
        {
            HienThiDLDichVu();
        }

        private void btnThoatDV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInDV_Click(object sender, EventArgs e)
        {
            Print pr = new Print();
            pr.Show();
        }
    }
}

        