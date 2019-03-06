namespace ShopManagement
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAdminTop = new MetroFramework.Controls.MetroPanel();
            this.lblAdminUserName = new MetroFramework.Controls.MetroLabel();
            this.lblAdminId = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAdminLogout = new MetroFramework.Controls.MetroButton();
            this.panelAdminLeft = new MetroFramework.Controls.MetroPanel();
            this.btnAdminSettings = new MetroFramework.Controls.MetroButton();
            this.btnAdminTransection = new MetroFramework.Controls.MetroButton();
            this.btnAdminAddEmployee = new MetroFramework.Controls.MetroButton();
            this.btnAdminAddProduct = new MetroFramework.Controls.MetroButton();
            this.btnAdminViewProduct = new MetroFramework.Controls.MetroButton();
            this.btnAdminViewEmp = new MetroFramework.Controls.MetroButton();
            this.btnAdminProfile = new MetroFramework.Controls.MetroButton();
            this.panelAdminMain = new MetroFramework.Controls.MetroPanel();
            this.panelAdminTop.SuspendLayout();
            this.panelAdminLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdminTop
            // 
            this.panelAdminTop.Controls.Add(this.lblAdminUserName);
            this.panelAdminTop.Controls.Add(this.lblAdminId);
            this.panelAdminTop.Controls.Add(this.metroLabel2);
            this.panelAdminTop.Controls.Add(this.metroLabel1);
            this.panelAdminTop.Controls.Add(this.btnAdminLogout);
            this.panelAdminTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminTop.HorizontalScrollbarBarColor = true;
            this.panelAdminTop.HorizontalScrollbarHighlightOnWheel = false;
            this.panelAdminTop.HorizontalScrollbarSize = 10;
            this.panelAdminTop.Location = new System.Drawing.Point(20, 60);
            this.panelAdminTop.Name = "panelAdminTop";
            this.panelAdminTop.Size = new System.Drawing.Size(1324, 77);
            this.panelAdminTop.TabIndex = 0;
            this.panelAdminTop.VerticalScrollbarBarColor = true;
            this.panelAdminTop.VerticalScrollbarHighlightOnWheel = false;
            this.panelAdminTop.VerticalScrollbarSize = 10;
            this.panelAdminTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdminTop_Paint);
            // 
            // lblAdminUserName
            // 
            this.lblAdminUserName.AutoSize = true;
            this.lblAdminUserName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAdminUserName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAdminUserName.Location = new System.Drawing.Point(155, 43);
            this.lblAdminUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminUserName.Name = "lblAdminUserName";
            this.lblAdminUserName.Size = new System.Drawing.Size(95, 25);
            this.lblAdminUserName.TabIndex = 1;
            this.lblAdminUserName.Text = "username";
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAdminId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAdminId.Location = new System.Drawing.Point(155, 18);
            this.lblAdminId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(29, 25);
            this.lblAdminId.TabIndex = 1;
            this.lblAdminId.Text = "Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(26, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(123, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "USER_NAME:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(60, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "USER_ID:";
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdminLogout.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdminLogout.Location = new System.Drawing.Point(1175, 7);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(122, 54);
            this.btnAdminLogout.TabIndex = 1;
            this.btnAdminLogout.Text = "LOG&OUT";
            this.btnAdminLogout.UseSelectable = true;
            // 
            // panelAdminLeft
            // 
            this.panelAdminLeft.Controls.Add(this.btnAdminSettings);
            this.panelAdminLeft.Controls.Add(this.btnAdminTransection);
            this.panelAdminLeft.Controls.Add(this.btnAdminAddEmployee);
            this.panelAdminLeft.Controls.Add(this.btnAdminAddProduct);
            this.panelAdminLeft.Controls.Add(this.btnAdminViewProduct);
            this.panelAdminLeft.Controls.Add(this.btnAdminViewEmp);
            this.panelAdminLeft.Controls.Add(this.btnAdminProfile);
            this.panelAdminLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminLeft.HorizontalScrollbarBarColor = true;
            this.panelAdminLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.panelAdminLeft.HorizontalScrollbarSize = 10;
            this.panelAdminLeft.Location = new System.Drawing.Point(20, 137);
            this.panelAdminLeft.Name = "panelAdminLeft";
            this.panelAdminLeft.Size = new System.Drawing.Size(170, 569);
            this.panelAdminLeft.TabIndex = 1;
            this.panelAdminLeft.VerticalScrollbarBarColor = true;
            this.panelAdminLeft.VerticalScrollbarHighlightOnWheel = false;
            this.panelAdminLeft.VerticalScrollbarSize = 10;
            // 
            // btnAdminSettings
            // 
            this.btnAdminSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdminSettings.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdminSettings.Location = new System.Drawing.Point(26, 489);
            this.btnAdminSettings.Name = "btnAdminSettings";
            this.btnAdminSettings.Size = new System.Drawing.Size(122, 54);
            this.btnAdminSettings.TabIndex = 1;
            this.btnAdminSettings.Text = "&SETTINGS";
            this.btnAdminSettings.UseSelectable = true;
            // 
            // btnAdminTransection
            // 
            this.btnAdminTransection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdminTransection.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdminTransection.Location = new System.Drawing.Point(26, 416);
            this.btnAdminTransection.Name = "btnAdminTransection";
            this.btnAdminTransection.Size = new System.Drawing.Size(122, 54);
            this.btnAdminTransection.TabIndex = 1;
            this.btnAdminTransection.Text = "&TRANSECTION";
            this.btnAdminTransection.UseSelectable = true;
            // 
            // btnAdminAddEmployee
            // 
            this.btnAdminAddEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdminAddEmployee.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdminAddEmployee.Location = new System.Drawing.Point(26, 195);
            this.btnAdminAddEmployee.Name = "btnAdminAddEmployee";
            this.btnAdminAddEmployee.Size = new System.Drawing.Size(122, 54);
            this.btnAdminAddEmployee.TabIndex = 1;
            this.btnAdminAddEmployee.Text = "ADD &EMPLOYEE";
            this.btnAdminAddEmployee.UseSelectable = true;
            this.btnAdminAddEmployee.Click += new System.EventHandler(this.btnAdminAddEmployee_Click);
            // 
            // btnAdminAddProduct
            // 
            this.btnAdminAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdminAddProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdminAddProduct.Location = new System.Drawing.Point(26, 344);
            this.btnAdminAddProduct.Name = "btnAdminAddProduct";
            this.btnAdminAddProduct.Size = new System.Drawing.Size(122, 54);
            this.btnAdminAddProduct.TabIndex = 1;
            this.btnAdminAddProduct.Text = "ADD &PRODUCT";
            this.btnAdminAddProduct.UseSelectable = true;
            this.btnAdminAddProduct.Click += new System.EventHandler(this.btnAdminAddProduct_Click);
            // 
            // btnAdminViewProduct
            // 
            this.btnAdminViewProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdminViewProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdminViewProduct.Location = new System.Drawing.Point(26, 267);
            this.btnAdminViewProduct.Name = "btnAdminViewProduct";
            this.btnAdminViewProduct.Size = new System.Drawing.Size(122, 54);
            this.btnAdminViewProduct.TabIndex = 1;
            this.btnAdminViewProduct.Text = "VIEW &PRODUCT";
            this.btnAdminViewProduct.UseSelectable = true;
            this.btnAdminViewProduct.Click += new System.EventHandler(this.btnAdminViewProduct_Click);
            // 
            // btnAdminViewEmp
            // 
            this.btnAdminViewEmp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdminViewEmp.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdminViewEmp.Location = new System.Drawing.Point(26, 117);
            this.btnAdminViewEmp.Name = "btnAdminViewEmp";
            this.btnAdminViewEmp.Size = new System.Drawing.Size(122, 54);
            this.btnAdminViewEmp.TabIndex = 1;
            this.btnAdminViewEmp.Text = "VIEW &EMPLOYEE";
            this.btnAdminViewEmp.UseSelectable = true;
            this.btnAdminViewEmp.Click += new System.EventHandler(this.btnAdminViewEmp_Click);
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdminProfile.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdminProfile.Location = new System.Drawing.Point(26, 42);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(122, 54);
            this.btnAdminProfile.TabIndex = 1;
            this.btnAdminProfile.Text = "&PROFLE";
            this.btnAdminProfile.UseSelectable = true;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            // 
            // panelAdminMain
            // 
            this.panelAdminMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminMain.HorizontalScrollbarBarColor = true;
            this.panelAdminMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelAdminMain.HorizontalScrollbarSize = 10;
            this.panelAdminMain.Location = new System.Drawing.Point(190, 137);
            this.panelAdminMain.Name = "panelAdminMain";
            this.panelAdminMain.Size = new System.Drawing.Size(1154, 569);
            this.panelAdminMain.TabIndex = 1;
            this.panelAdminMain.VerticalScrollbarBarColor = true;
            this.panelAdminMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelAdminMain.VerticalScrollbarSize = 10;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 726);
            this.Controls.Add(this.panelAdminMain);
            this.Controls.Add(this.panelAdminLeft);
            this.Controls.Add(this.panelAdminTop);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "frmAdmin";
            this.Text = "ADMIN PANEL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panelAdminTop.ResumeLayout(false);
            this.panelAdminTop.PerformLayout();
            this.panelAdminLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelAdminTop;
        private MetroFramework.Controls.MetroLabel lblAdminUserName;
        private MetroFramework.Controls.MetroLabel lblAdminId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAdminLogout;
        private MetroFramework.Controls.MetroPanel panelAdminLeft;
        private MetroFramework.Controls.MetroButton btnAdminSettings;
        private MetroFramework.Controls.MetroButton btnAdminTransection;
        private MetroFramework.Controls.MetroButton btnAdminAddEmployee;
        private MetroFramework.Controls.MetroButton btnAdminAddProduct;
        private MetroFramework.Controls.MetroButton btnAdminViewProduct;
        private MetroFramework.Controls.MetroButton btnAdminViewEmp;
        private MetroFramework.Controls.MetroButton btnAdminProfile;
        private MetroFramework.Controls.MetroPanel panelAdminMain;
    }
}