using MySql.Data.MySqlClient;
using ShopManagementDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementBLL
{
    public class productBLL
    {
         MySqlConnection con;
         connection cont = new connection();
         public productBLL()
        {
            con = cont.myCon();
        }
         public long addProduct(string pr_name, string unit_type, long unit_price, long quantity)
         {
             try
             {
                 con.Open();
                 MySqlCommand cmd = con.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "INSERT INTO `product`(`pr_id`, `pr_name`, `unit_type`, `unit_price`, `quantity`) VALUES  (NULL,'" + pr_name + "',  '" + unit_type + "',  '" + unit_price + "',  '" + quantity + "')";
                 DataTable dt = new DataTable();
                 MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                 da.Fill(dt);
                 con.Close();
                 return 0;
             }
             catch (Exception e)
             {
                 con.Close();
                 return 0;
             }
         }
         public DataTable viewProduct(string search, string orderby, string asc)
         {
             con.Open();
             MySqlCommand cmd = con.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "select * from product where  pr_id like '%" + search + "%' or pr_name like '%" + search + "%' or unit_type like '%" + search + "%' order by " + orderby + " " + asc + "";

             //cmd.ExecuteNonQuery();//insert
             con.Close();
             DataTable dt = new DataTable();
             MySqlDataAdapter da = new MySqlDataAdapter(cmd);
             da.Fill(dt);
             return dt;
         }
    }
}
