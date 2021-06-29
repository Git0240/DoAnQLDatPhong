using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnQLDatPhong.Models;

namespace DoAnQLDatPhong.Controller
{
    class BLNguoiDung
    {
        DALNguoiDung dalnd;
        public BLNguoiDung()
        {
            dalnd = new DALNguoiDung();
        }
        public DataTable LoadPQ()
        {
            return dalnd.LoadPQ();
        }
        public bool ThemND(NguoiDung nd)
        {
            return dalnd.ThemND(nd);
        }
        public bool SuaPQ(NguoiDung nd)
        {
            return dalnd.SuaPQ(nd);
        }
    }
}
