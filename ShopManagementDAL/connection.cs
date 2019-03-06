using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementDAL
{
    public class connection
    {
        MySqlConnection con = new MySqlConnection(@"data Source=localhost;port=3306;Initial Catalog=shop_management;User Id=root;password=''");
        public connection()
        {

        }
        public MySqlConnection myCon()
        {
            return con;
        }
    }
}
