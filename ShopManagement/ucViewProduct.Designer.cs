namespace ShopManagement
{
    partial class ucViewProduct
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            this.cmbAsc = new MetroFramework.Controls.MetroComboBox();
            this.cmbOrder = new MetroFramework.Controls.MetroComboBox();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listView1 = new MetroFramework.Controls.MetroListView();
            this.Product_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmbAsc
            // 
            this.cmbAsc.FormattingEnabled = true;
            this.cmbAsc.ItemHeight = 23;
            this.cmbAsc.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.cmbAsc.Location = new System.Drawing.Point(614, 38);
            this.cmbAsc.Name = "cmbAsc";
            this.cmbAsc.Size = new System.Drawing.Size(62, 29);
            this.cmbAsc.TabIndex = 19;
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
            "UNIT_TYPE"});
            this.cmbOrder.Location = new System.Drawing.Point(487, 39);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(121, 29);
            this.cmbOrder.TabIndex = 20;
            this.cmbOrder.UseSelectable = true;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRefresh.Location = new System.Drawing.Point(3, 39);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 30);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseSelectable = true;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(355, 2);
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
            this.txtSearch.Location = new System.Drawing.Point(98, 39);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search &Product";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(383, 30);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search &Product";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(528, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 26);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Sorted By:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(156, 26);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "ALL PRODUCT";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product_Id,
            this.Product_Name,
            this.Unit_Type,
            this.Unit_Price,
            this.Quantity});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(98, 73);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(578, 493);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseSelectable = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Product_Name
            // 
            this.Product_Name.Text = "PRODUCT NAME";
            this.Product_Name.Width = 165;
            // 
            // Unit_Type
            // 
            this.Unit_Type.Text = "UNIT TYPE";
            this.Unit_Type.Width = 99;
            // 
            // Unit_Price
            // 
            this.Unit_Price.Text = "UNIT PRICE";
            this.Unit_Price.Width = 95;
            // 
            // Quantity
            // 
            this.Quantity.Text = "QUANTITY";
            this.Quantity.Width = 112;
            // 
            // Product_Id
            // 
            this.Product_Id.Text = "PRODUCT ID";
            this.Product_Id.Width = 109;
            // 
            // ucViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbAsc);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ucViewProduct";
            this.Size = new System.Drawing.Size(1154, 569);
            this.Load += new System.EventHandler(this.ucViewProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbAsc;
        private MetroFramework.Controls.MetroComboBox cmbOrder;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroListView listView1;
        private System.Windows.Forms.ColumnHeader Product_Name;
        private System.Windows.Forms.ColumnHeader Unit_Type;
        private System.Windows.Forms.ColumnHeader Unit_Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Product_Id;
    }
}
