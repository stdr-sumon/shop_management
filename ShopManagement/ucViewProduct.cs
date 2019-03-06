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
    public partial class ucViewProduct : UserControl
    {
        string search, orderby, asc;
        public ucViewProduct()
        {
            InitializeComponent();
            cmbAsc.SelectedIndex = 0;
            cmbOrder.SelectedIndex = 0;
            viewAllProduct();
        }
        public void viewAllProduct()
        {
            search = txtSearch.Text;
            if (cmbOrder.Text == "NAME")
            {
                orderby = "pr_name";
            }
            else if (cmbOrder.Text == "ID")
            {
                orderby = "pr_id";
            }
            else if (cmbOrder.Text == "UNIT_TYPE")
            {
                orderby = "unit_type";
            }
            asc = cmbAsc.Text;
            try
            {
                productBLL prod = new productBLL();
                DataTable dt = prod.viewProduct(search, orderby, asc);
                int i = dt.Rows.Count;
                listView1.Items.Clear();
                for (int j = 0; j < i; j++)
                {

                    ListView item = new ListView();
                    String id = dt.Rows[j][0].ToString();
                    String name = dt.Rows[j][1].ToString();
                    String u_type = dt.Rows[j][2].ToString();
                    String u_price = dt.Rows[j][3].ToString();
                    String u_quantity = dt.Rows[j][4].ToString();

                    listView1.Items.Add(id);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(name);

                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(u_type);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(u_price);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(u_quantity);
                    //btnDetails.Enabled = false;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("error in data base");
            }
        }

        private void ucViewProduct_Load(object sender, EventArgs e)
        {
            viewAllProduct();
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewAllProduct();
        }

        private void cmbAsc_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewAllProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            viewAllProduct();
        }
    }
}
