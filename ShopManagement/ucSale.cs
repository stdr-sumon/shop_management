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
    public partial class ucSale : UserControl
    {
        string search;
        long p, q, qty,total,i;
        public ucSale()
        {
            InitializeComponent();
            viewAllProduct();
            listView2.Items.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucSale_Load(object sender, EventArgs e)
        {

        }
        public void viewAllProduct()
        {
            search = txtSearch.Text;
            try
            {
                productBLL prod = new productBLL();
                DataTable dt = prod.viewProduct(search,"pr_name","asc");
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
        private void addToCart()
        {
            string id = listView1.SelectedItems[0].SubItems[0].Text;
            string name = listView1.SelectedItems[0].SubItems[1].Text;
            string type = listView1.SelectedItems[0].SubItems[2].Text;
            string price = listView1.SelectedItems[0].SubItems[3].Text;
            string quantity = listView1.SelectedItems[0].SubItems[4].Text;
            if (txtQty.Text != "")
            {
                p = Convert.ToInt64(price);
                q = Convert.ToInt64(txtQty.Text);
                qty = Convert.ToInt64(quantity);
                for (int i = 0; i < listView2.Items.Count;i++)
                {
                    if(id.Equals(listView2.Items[i].SubItems[0].Text))
                    {
                        q += Convert.ToInt64(listView2.Items[i].SubItems[3].Text);

                        listView2.Items[i].Remove();
                        break;
                    }
                }
                    if (qty - Convert.ToInt64(txtQty.Text) >= 0)
                    {
                        listView2.Items.Add(id);
                        listView2.Items[listView2.Items.Count - 1].SubItems.Add(name);

                        listView2.Items[listView2.Items.Count - 1].SubItems.Add(price);
                        listView2.Items[listView2.Items.Count - 1].SubItems.Add(q.ToString());
                        listView2.Items[listView2.Items.Count - 1].SubItems.Add((p * q).ToString());
                    }
                    else
                    {
                        MessageBox.Show("Quantity not available");
                    }
            }
            else
            {
                MessageBox.Show("Enter Valid Quantity");
            }


           // MessageBox.Show("id " + id + " name " + name + " type " + type + " price " + price + " qunty " + quantity);

            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            addToCart();
        }

    }
}
