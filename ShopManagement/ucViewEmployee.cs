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
    public partial class ucViewEmployee : UserControl
    {
        string search, orderby, asc;
        public ucViewEmployee()
        {
            InitializeComponent();
            cmbAsc.SelectedIndex = 0;
            cmbOrder.SelectedIndex = 0;
            viewALLEmployee();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void viewALLEmployee()
        {
            search = txtSearch.Text;
            if (cmbOrder.Text == "NAME")
            {
                orderby = "name";
            }
            else if (cmbOrder.Text == "ID")
            {
                orderby = "id";
            }
            else if (cmbOrder.Text == "STATUS")
            {
                orderby = "STATUS";
            }
            else if (cmbOrder.Text == "JOINDATE")
            {
                orderby = "JOIN_DATE";
            }
            asc = cmbAsc.Text;
            try
            {
                employeeBLL emp = new employeeBLL();
                DataTable dt = emp.viewEmp(search, orderby, asc);
                int i = dt.Rows.Count;
                //MessageBox.Show(i + "");
                string format = "dd-MM-yyyy";
                listView1.Items.Clear();
                for (int j = 0; j < i; j++)
                {

                    ListView item = new ListView();
                    String id = dt.Rows[j][0].ToString();
                    String name = dt.Rows[j][1].ToString();                   
                    String pp = dt.Rows[j][2].ToString();
                    String po = dt.Rows[j][3].ToString();
                    String email = dt.Rows[j][5].ToString();
                    String bl = dt.Rows[j][12].ToString();
                    String gender = dt.Rows[j][13].ToString();
                    DateTime joindate = Convert.ToDateTime(dt.Rows[j][8]);
                    string join = joindate.ToString(format);
                    String status = dt.Rows[j][10].ToString();
                    String des = dt.Rows[j][9].ToString();

                    listView1.Items.Add(id);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(name);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(pp);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(po);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(email);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(bl);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(gender);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(join);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(des);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(status);
                    //btnDetails.Enabled = false;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("error in data base");
            }
        }

        private void ucViewEmployee_Load(object sender, EventArgs e)
        {
            viewALLEmployee();
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewALLEmployee();
        }

        private void cmbAsc_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewALLEmployee();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            viewALLEmployee();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                details();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no items clicked");
            }
        }
        private void details()
        {
            string st = listView1.SelectedItems[0].SubItems[0].Text;
            //string stt = st.Substring(1, 10);
            //MessageBox.Show(st);
            long id = Convert.ToInt64(st);
        }
    }
}
