using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagementDAL;
using System.Data;
using MySql.Data.MySqlClient;

namespace ShopManagementBLL
{
    public class loginBLL
    {
        MySqlConnection con;
        connection cont = new connection();
         public loginBLL()
        {
            con = cont.myCon();
        }
         public DataTable login(string name, string pass)
         {
             con.Open();
             MySqlCommand cmd = con.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "select * from loginall where username = '" + name + "' and password = '" + pass + "'";

             //cmd.ExecuteNonQuery();//insert
             con.Close();
             DataTable dt = new DataTable();
             MySqlDataAdapter da = new MySqlDataAdapter(cmd);
             da.Fill(dt);
             return dt;
         }

         public int logEmployee(long id,string name, string pass)
         {
             try
             {
                 con.Open();
                 MySqlCommand cmd = con.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "INSERT INTO `login`(`id`, `username`, `password`) VALUES ('" + id + "' ,'" + name + "',  '" + pass + "')";
                 DataTable dt = new DataTable();
                 MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                 da.Fill(dt);
                 con.Close();
                 return 1;
             }
             catch (Exception e)
             {
                 con.Close();
                 return 0;
             }
         }
    }
}
