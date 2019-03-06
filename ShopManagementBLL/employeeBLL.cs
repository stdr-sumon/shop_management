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
   public class employeeBLL
    {
        MySqlConnection con;
        connection cont = new connection();
        public employeeBLL()
        {
            con = cont.myCon();
        }
        public DataTable profile(long id)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employee where id = '" + id + "'";

            //cmd.ExecuteNonQuery();//insert
            con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
       public long addEmployee(string name, string pp, string po, string address, string email, DateTime dob, long salary, string des, long nid, string bg, string gender)
       {
           try
           {
               con.Open();
               MySqlCommand cmd = con.CreateCommand();
               cmd.CommandType = CommandType.Text;
               string format = "yyyy-MM-dd";
               cmd.CommandText = "INSERT INTO `employee`(`id`, `name`, `ph_personal`, `ph_office`, `address`, `email`, `dob`, `salary`, `join_date`, `designation`, `status`, `NID`, `BG`, `gender`) VALUES (NULL, '" + name + "', '" + pp + "', '" + po + "', '" + address + "', '" + email + "', '" + dob.ToString(format) + "', '" + salary + "', NOW(), '" + des + "', 'valid',  '" + nid + "',  '" + bg + "',  '" + gender + "');select last_insert_id()";
               DataTable dt = new DataTable();
               MySqlDataAdapter da = new MySqlDataAdapter(cmd);
               da.Fill(dt);
               con.Close();
               return Convert.ToInt64(dt.Rows[0][0].ToString());
           }
           catch (Exception e)
           {
               con.Close();
               return 0;
           }
       }
       public DataTable viewEmp(string search, string orderby, string asc)
       {
           con.Open();
           MySqlCommand cmd = con.CreateCommand();
           cmd.CommandType = CommandType.Text;
           cmd.CommandText = "select * from employee where name like '%" + search + "%' or ph_personal like '%" + search + "%' or ph_office like '%" + search + "%' or id like '%" + search + "%' order by " + orderby + " " + asc + "";

           //cmd.ExecuteNonQuery();//insert
           con.Close();
           DataTable dt = new DataTable();
           MySqlDataAdapter da = new MySqlDataAdapter(cmd);
           da.Fill(dt);
           return dt;
       }
    }
}
