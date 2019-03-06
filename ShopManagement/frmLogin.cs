using ShopManagementBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginValid();
        }
        private void loginValid()
        {
            loginBLL l = new loginBLL();
            DataTable dt;
            dt = l.login(txtUserName.Text,txtPassword.Text);
            //MessageBox.Show("" + dt.Rows.Count);

            if(dt.Rows.Count == 1)
            {
                string status = dt.Rows[0][4].ToString();
                if(status.Equals("valid"))
                {
                    string des = dt.Rows[0][3].ToString();
                    long id = Convert.ToInt64(dt.Rows[0][0].ToString());
                    string name = dt.Rows[0][5].ToString();

                    if (des.Equals("admin"))
                    {
                        this.Hide();
                        frmAdmin adm = new frmAdmin(id,name);
                        adm.Show();
                    }
                    else if (des.Equals("salesman"))
                    {
                        this.Hide();
                        frmSalesman adm = new frmSalesman(id,name);
                        adm.Show();
                    }
                }
                else
                {
                    lblLogin.Text = "you are invalid";
                }
            }
            else
            {
                lblLogin.Text = "User name or Password not matched";
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
