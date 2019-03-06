using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagementBLL;

namespace ShopManagement
{
    public partial class ucAddEmployee : UserControl
    {
        long nxtId;
        public ucAddEmployee()
        {
            InitializeComponent();
        }

        private void cmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int chk()
        {
            if (txtName.Text != "")
            {
                if (txtNid.Text != "")
                {
                    if (cmbGender.Text != "")
                    {
                        if (cmbBloodGroup.Text != "")
                        {
                            if (txtPersonal.Text != "" || txtOffice.Text != "")
                            {
                                if (txtEmail.Text != "")
                                {
                                    if (richTxtAddress.Text != "")
                                    {
                                        if (txtSalarry.Text != "")
                                        {
                                            if (cmbDesignation.Text != "")
                                            {
                                                MessageBox.Show("DONE");
                                                return chkPass();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Deginarion Not Selected");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Salary Can Not be Empty");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Address Can Not be Empty");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Email Can Not be Empty");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Both Phone Can Not be Empty");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Blood Group Can Not be Empty");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gender Can Not be Empty");
                    }
                }
                else
                {
                    MessageBox.Show("NID Can Not be Empty");
                }
            }
            else
            {
                MessageBox.Show("Name Can Not be Empty");
            }
            return 0;
        }

        private void ucAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnSav_Click(object sender, EventArgs e)
        {
            if(chk() == 1)
            {
                addEmp();
                int i = addLogin();
                MessageBox.Show("" + i);
            }
            
        }
        private int chkPass()
        {
            if (txtUserName.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    if (txtPassword.Text.Equals(txtConfirmPassword.Text))
                    {
                        MessageBox.Show("DONE");
                        return 1;
                    }
                    else
                    {
                        MessageBox.Show("Paassword not matched");
                    }
                }
                else
                {
                    MessageBox.Show("Password Can Not be Empty");
                }
            }
            else
            {
                MessageBox.Show("Username Can Not be Empty");
            }
            return 0;
        }
        private int addEmp()
        {
            string s = txtName.Text;
            employeeBLL emp = new employeeBLL();
            try
            {
                long i = emp.addEmployee(txtName.Text, txtPersonal.Text, txtOffice.Text, richTxtAddress.Text, txtEmail.Text, Convert.ToDateTime(txtdateObirth.Text), Convert.ToInt64(txtSalarry.Text), cmbDesignation.Text, Convert.ToInt64(txtNid.Text), cmbBloodGroup.Text, cmbGender.Text);
                nxtId = i;
                if (i != 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        private int addLogin()
        {
            loginBLL log = new loginBLL();
           
            return log.logEmployee(nxtId,txtUserName.Text, txtPassword.Text);
              

        }
    }
}
