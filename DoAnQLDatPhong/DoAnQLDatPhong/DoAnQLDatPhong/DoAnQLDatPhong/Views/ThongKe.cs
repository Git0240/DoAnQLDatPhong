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
using System.Data.Sql;
using System.Data.SqlClient;
namespace DoAnQLDatPhong.Views
{
    public partial class ThongKe : DevExpress.XtraEditors.XtraForm
    {
        public ThongKe()
        {
            InitializeComponent();
            
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtchisuatphong.Text = "";
            txtdoanhthuthang.Text = "";
            txtdoanhthuthucte.Text = "";
            txtdoanthuthucte1.Text = "";
            txtsoluongphong.Text = "";
            txttieledoanhthu1.Text = "";
            txttiledoanhthu.Text = "";
            txttongdoanhthuthang1.Text = "";
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        
    }

}