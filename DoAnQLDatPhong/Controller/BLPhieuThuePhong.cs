using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAnQLDatPhong.Controller
{
    class BLPhieuThuePhong
    {
        DALPhieuThuePhong dalptp;
        public BLPhieuThuePhong()
        {
            dalptp = new DALPhieuThuePhong();
        }
        public DataTable LayDLPTP()
        {
            return dalptp.LayDLPhieuNhanPhong();
        }
        public DataTable LoadKH()
        {
            return dalptp.LoadKH();
        }
        public DataTable LoadPhong()
        {
            return dalptp.LoadPhongTrong();
        }
    }
}
