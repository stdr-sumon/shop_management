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
    public partial class ucAddProduct : UserControl
    {
        long nxtId;
        public ucAddProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            chk();


        }
        private int chk()
        {
            if (txtProductName.Text != "")
            {
                if (cmbUnitType.Text != "")
                {
                    if (txtProductPrice.Text != "")
                    {
                        if (txtProductQuantity.Text != "")
                        {
                            MessageBox.Show("DONE");
                            return addProductNow();
                        }
                        else
                        {
                            MessageBox.Show("Quantity Can Not be Empty");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Price Can Not be Empty");
                    }
                }
                else
                {
                    MessageBox.Show("Unit Type Can Not be Empty");
                }
            }
            else
            {
                MessageBox.Show("Product Name Can Not be Empty");
            }
            return 0;
        }
        private int addProductNow()
        {
            productBLL product = new productBLL();
            try
            {
                //long pr_id, string pr_name, string unit_type, long unit_price, long quantity
                long i = product.addProduct(txtProductName.Text, cmbUnitType.Text, Convert.ToInt64(txtProductPrice.Text), Convert.ToInt64(txtProductQuantity.Text));
                if (i != 0)
                {
                    //login(i);
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
    }
}
