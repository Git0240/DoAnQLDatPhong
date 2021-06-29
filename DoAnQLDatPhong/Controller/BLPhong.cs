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
    class BLPhong
    {
        DALPhong dalPhong;
        public BLPhong()
        {
            dalPhong = new DALPhong();
        }
        public DataTable LayDLPhong()
        {
            return dalPhong.LayDLPhong();
        }
        public bool ThemPhong(Phong p)
        {
            return dalPhong.ThemPhong(p);
        }
        public DataTable LocDLPhong()
        {
            return dalPhong.LocDLPhong();
        }
    }
}
