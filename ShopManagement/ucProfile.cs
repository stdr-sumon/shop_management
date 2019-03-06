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
    public partial class ucProfile : UserControl
    {
        long id;
        public ucProfile(long id)
        {
            InitializeComponent();
            this.id = id;
            profile();
        }

        private void ucProfile_Load(object sender, EventArgs e)
        {

        }
        private void profile()
        {
            employeeBLL emp = new employeeBLL();
            DataTable dt = emp.profile(id);
            if (dt.Rows.Count == 1)
            {
                lblName.Text = dt.Rows[0][1].ToString();
                lblPersonalPhone.Text = dt.Rows[0][2].ToString();
                lblOfficePhone.Text = dt.Rows[0][3].ToString();
                lblAddress.Text = dt.Rows[0][4].ToString();
                lblEmail.Text = dt.Rows[0][5].ToString();
                DateTime dob = Convert.ToDateTime(dt.Rows[0][6]);
                string format = "dd-MM-yyyy";
                lblDateOfBirth.Text = dob.ToString(format);
                lblSalary.Text = dt.Rows[0][7].ToString();
                DateTime jd = Convert.ToDateTime(dt.Rows[0][8]);
                lblJoinDate.Text = jd.ToString(format);
                lblDepartment.Text = dt.Rows[0][9].ToString();
                lblNid.Text = dt.Rows[0][11].ToString();
                lblBloodGroup.Text = dt.Rows[0][12].ToString();
                lblGender.Text = dt.Rows[0][13].ToString();

            }
        }
    }
}
