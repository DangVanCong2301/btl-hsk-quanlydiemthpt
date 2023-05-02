using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyDiemTHPT.Connection
{
    class DBConnection
    {
        public static string strConnection = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=BTL_HSK_QLDiemTHPT;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(strConnection);
        }
    }
}
