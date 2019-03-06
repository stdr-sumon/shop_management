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
    public partial class frmAdmin : MetroFramework.Forms.MetroForm
    {
        long id;
        public frmAdmin(long id, string name)
        {
            InitializeComponent();
            this.id = id;
            lblAdminId.Text = id.ToString();
            lblAdminUserName.Text = name;
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelAdminTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            panelAdminMain.Controls.Clear();
            panelAdminMain.Controls.Add(new ucProfile(id));
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            panelAdminMain.Controls.Clear();
            panelAdminMain.Controls.Add(new ucProfile(id));
        }

        private void btnAdminAddEmployee_Click(object sender, EventArgs e)
        {
            panelAdminMain.Controls.Clear();
            panelAdminMain.Controls.Add( new ucAddEmployee());
        }

        private void btnAdminAddProduct_Click(object sender, EventArgs e)
        {
            panelAdminMain.Controls.Clear();
            panelAdminMain.Controls.Add(new ucAddProduct());
        }

        private void btnAdminViewEmp_Click(object sender, EventArgs e)
        {
            panelAdminMain.Controls.Clear();
            panelAdminMain.Controls.Add(new ucViewEmployee());
        }

        private void btnAdminViewProduct_Click(object sender, EventArgs e)
        {
            panelAdminMain.Controls.Clear();
            panelAdminMain.Controls.Add(new ucViewProduct());
        }
    }
}
