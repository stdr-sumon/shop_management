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
    public partial class frmSalesman : MetroFramework.Forms.MetroForm
    {
        long id;
        public frmSalesman(long id, string name)
        {
            InitializeComponent();
            this.id = id;
            lblSalesmanId.Text = id.ToString();
            lblSalesmanUserName.Text = name;
        }

        private void frmSalesman_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalesmanProfile_Click(object sender, EventArgs e)
        {
            panelSalesmanMain.Controls.Clear();
            panelSalesmanMain.Controls.Add(new ucProfile(id));
        }

        private void btnSalesmanSale_Click(object sender, EventArgs e)
        {
            panelSalesmanMain.Controls.Clear();
            panelSalesmanMain.Controls.Add(new ucSale());
        }
    }
}
