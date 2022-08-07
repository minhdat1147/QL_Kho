using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POJO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-7RCP7TU;Initial Catalog=QL_KHODIENTU;Integrated Security=True");
    }
}
