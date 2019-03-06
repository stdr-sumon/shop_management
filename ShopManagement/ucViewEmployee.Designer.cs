namespace ShopManagement
{
    partial class ucViewEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listView1 = new MetroFramework.Controls.MetroListView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDetails = new MetroFramework.Controls.MetroButton();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PERSONAL_NO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OFFICE_NO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMAIL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JOIN_DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DESIGNATION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STATUS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GENDER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbAsc = new MetroFramework.Controls.MetroComboBox();
            this.cmbOrder = new MetroFramework.Controls.MetroComboBox();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NAME,
            this.PERSONAL_NO,
            this.OFFICE_NO,
            this.EMAIL,
            this.BG,
            this.GENDER,
            this.JOIN_DATE,
            this.DESIGNATION,
            this.STATUS});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(3, 73);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(1148, 457);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseSelectable = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(156, 26);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ALL EMPLOYEES";
            // 
            // btnDetails
            // 
            this.btnDetails.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDetails.Location = new System.Drawing.Point(1062, 536);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(89, 30);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "&Details";
            this.btnDetails.UseSelectable = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 86;
            // 
            // NAME
            // 
            this.NAME.Text = "NAME";
            this.NAME.Width = 137;
            // 
            // PERSONAL_NO
            // 
            this.PERSONAL_NO.Text = "PERSONAL_NO";
            this.PERSONAL_NO.Width = 136;
            // 
            // OFFICE_NO
            // 
            this.OFFICE_NO.Text = "OFFICE_NO";
            this.OFFICE_NO.Width = 121;
            // 
            // EMAIL
            // 
            this.EMAIL.Text = "EMAIL";
            this.EMAIL.Width = 163;
            // 
            // JOIN_DATE
            // 
            this.JOIN_DATE.Text = "JOIN_DATE";
            this.JOIN_DATE.Width = 121;
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.Text = "DESIGNATION";
            this.DESIGNATION.Width = 116;
            // 
            // STATUS
            // 
            this.STATUS.Text = "STATUS";
            this.STATUS.Width = 78;
            // 
            // BG
            // 
            this.BG.Text = "B. GROUP";
            this.BG.Width = 88;
            // 
            // GENDER
            // 
            this.GENDER.Text = "GENDER";
            this.GENDER.Width = 77;
            // 
            // cmbAsc
            // 
            this.cmbAsc.FormattingEnabled = true;
            this.cmbAsc.ItemHeight = 23;
            this.cmbAsc.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.cmbAsc.Location = new System.Drawing.Point(1089, 38);
            this.cmbAsc.Name = "cmbAsc";
            this.cmbAsc.Size = new System.Drawing.Size(62, 29);
            this.cmbAsc.TabIndex = 12;
            this.cmbAsc.UseSelectable = true;
            this.cmbAsc.SelectedIndexChanged += new System.EventHandler(this.cmbAsc_SelectedIndexChanged);
            // 
            // cmbOrder
            // 
            this.cmbOrder.DisplayMember = "NONE";
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.ItemHeight = 23;
            this.cmbOrder.Items.AddRange(new object[] {
            "ID",
            "NAME",
            "JOINDATE",
            "STATUS"});
            this.cmbOrder.Location = new System.Drawing.Point(962, 37);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(121, 29);
            this.cmbOrder.TabIndex = 13;
            this.cmbOrder.UseSelectable = true;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRefresh.Location = new System.Drawing.Point(94, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 30);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseSelectable = true;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(728, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSearch.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(189, 37);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "&Search Employee";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(756, 30);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "&Search Employee";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(962, 8);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 26);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Sorted By:";
            // 
            // ucViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbAsc);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listView1);
            this.Name = "ucViewEmployee";
            this.Size = new System.Drawing.Size(1154, 569);
            this.Load += new System.EventHandler(this.ucViewEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader PERSONAL_NO;
        private System.Windows.Forms.ColumnHeader OFFICE_NO;
        private System.Windows.Forms.ColumnHeader EMAIL;
        private System.Windows.Forms.ColumnHeader BG;
        private System.Windows.Forms.ColumnHeader GENDER;
        private System.Windows.Forms.ColumnHeader JOIN_DATE;
        private System.Windows.Forms.ColumnHeader DESIGNATION;
        private System.Windows.Forms.ColumnHeader STATUS;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnDetails;
        private MetroFramework.Controls.MetroComboBox cmbAsc;
        private MetroFramework.Controls.MetroComboBox cmbOrder;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
