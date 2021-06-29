using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAnQLDatPhong
{
    class ConnectionString
    {
        public static string connec;
        public  ConnectionString()
        {
            connec = @"Data Source=DESKTOP-Q71IFSO\BIGBOSS;Initial Catalog=QuanLiDatPhong;User ID=sa;Password=0240";
        }
        public SqlConnection getConnection()
        {
            SqlConnection getCon = new SqlConnection(connec);
            return getCon;
        }

    }
}
