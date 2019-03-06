namespace ShopManagement
{
    partial class ucSale
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.listView1 = new MetroFramework.Controls.MetroListView();
            this.Product_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCartcart = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnRmvCart = new MetroFramework.Controls.MetroButton();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.listView2 = new MetroFramework.Controls.MetroListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UNIT_PR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TOTAL_PRICE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtReturn = new MetroFramework.Controls.MetroTextBox();
            this.txtCash = new MetroFramework.Controls.MetroTextBox();
            this.txtTotalPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
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
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(3, 84);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(532, 449);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseSelectable = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Product_Id
            // 
            this.Product_Id.Text = "PRODUCT ID";
            this.Product_Id.Width = 104;
            // 
            // Product_Name
            // 
            this.Product_Name.Text = "PRODUCT NAME";
            this.Product_Name.Width = 132;
            // 
            // Unit_Type
            // 
            this.Unit_Type.Text = "UNIT TYPE";
            this.Unit_Type.Width = 88;
            // 
            // Unit_Price
            // 
            this.Unit_Price.Text = "UNIT PRICE";
            this.Unit_Price.Width = 94;
            // 
            // Quantity
            // 
            this.Quantity.Text = "QUANTITY";
            this.Quantity.Width = 92;
            // 
            // btnCartcart
            // 
            this.btnCartcart.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCartcart.Location = new System.Drawing.Point(414, 48);
            this.btnCartcart.Name = "btnCartcart";
            this.btnCartcart.Size = new System.Drawing.Size(98, 31);
            this.btnCartcart.TabIndex = 26;
            this.btnCartcart.Text = "ADD &CART";
            this.btnCartcart.UseSelectable = true;
            this.btnCartcart.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(652, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "CART &LIST";
            // 
            // btnRmvCart
            // 
            this.btnRmvCart.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRmvCart.Location = new System.Drawing.Point(976, 54);
            this.btnRmvCart.Name = "btnRmvCart";
            this.btnRmvCart.Size = new System.Drawing.Size(98, 31);
            this.btnRmvCart.TabIndex = 29;
            this.btnRmvCart.Text = "&REMOVE";
            this.btnRmvCart.UseSelectable = true;
            // 
            // btnPrint
            // 
            this.btnPrint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPrint.Location = new System.Drawing.Point(1027, 541);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 25);
            this.btnPrint.TabIndex = 30;
            this.btnPrint.Text = "&PRINT";
            this.btnPrint.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(3, 19);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(166, 25);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "AVAILABLE ITEMS";
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(3, 47);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(80, 30);
            this.metroButton1.TabIndex = 33;
            this.metroButton1.Text = "&Refresh";
            this.metroButton1.UseSelectable = true;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(191, 2);
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
            this.txtSearch.Location = new System.Drawing.Point(89, 47);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search &Product";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(219, 30);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search &Product";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(66, 2);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtQty.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(314, 47);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PromptText = "Search &Product";
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(94, 30);
            this.txtQty.TabIndex = 32;
            this.txtQty.UseSelectable = true;
            this.txtQty.WaterMark = "Search &Product";
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listView2
            // 
            this.listView2.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NAME,
            this.UNIT_PR,
            this.QTY,
            this.TOTAL_PRICE});
            this.listView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView2.Location = new System.Drawing.Point(652, 99);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.OwnerDraw = true;
            this.listView2.Size = new System.Drawing.Size(473, 341);
            this.listView2.TabIndex = 25;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.UseSelectable = true;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 67;
            // 
            // NAME
            // 
            this.NAME.Text = "NAME";
            this.NAME.Width = 114;
            // 
            // UNIT_PR
            // 
            this.UNIT_PR.Text = "UNIT_PR";
            this.UNIT_PR.Width = 75;
            // 
            // QTY
            // 
            this.QTY.Text = "QTY";
            this.QTY.Width = 84;
            // 
            // TOTAL_PRICE
            // 
            this.TOTAL_PRICE.Text = "TOTAL_PRICE";
            this.TOTAL_PRICE.Width = 120;
            // 
            // txtReturn
            // 
            // 
            // 
            // 
            this.txtReturn.CustomButton.Image = null;
            this.txtReturn.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtReturn.CustomButton.Name = "";
            this.txtReturn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReturn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReturn.CustomButton.TabIndex = 1;
            this.txtReturn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReturn.CustomButton.UseSelectable = true;
            this.txtReturn.CustomButton.Visible = false;
            this.txtReturn.Lines = new string[0];
            this.txtReturn.Location = new System.Drawing.Point(1000, 501);
            this.txtReturn.MaxLength = 32767;
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.PasswordChar = '\0';
            this.txtReturn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReturn.SelectedText = "";
            this.txtReturn.SelectionLength = 0;
            this.txtReturn.SelectionStart = 0;
            this.txtReturn.ShortcutsEnabled = true;
            this.txtReturn.Size = new System.Drawing.Size(125, 23);
            this.txtReturn.TabIndex = 39;
            this.txtReturn.UseSelectable = true;
            this.txtReturn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReturn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCash
            // 
            // 
            // 
            // 
            this.txtCash.CustomButton.Image = null;
            this.txtCash.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtCash.CustomButton.Name = "";
            this.txtCash.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCash.CustomButton.TabIndex = 1;
            this.txtCash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCash.CustomButton.UseSelectable = true;
            this.txtCash.CustomButton.Visible = false;
            this.txtCash.Lines = new string[0];
            this.txtCash.Location = new System.Drawing.Point(1000, 471);
            this.txtCash.MaxLength = 32767;
            this.txtCash.Name = "txtCash";
            this.txtCash.PasswordChar = '\0';
            this.txtCash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCash.SelectedText = "";
            this.txtCash.SelectionLength = 0;
            this.txtCash.SelectionStart = 0;
            this.txtCash.ShortcutsEnabled = true;
            this.txtCash.Size = new System.Drawing.Size(125, 23);
            this.txtCash.TabIndex = 38;
            this.txtCash.UseSelectable = true;
            this.txtCash.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCash.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTotalPrice
            // 
            // 
            // 
            // 
            this.txtTotalPrice.CustomButton.Image = null;
            this.txtTotalPrice.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtTotalPrice.CustomButton.Name = "";
            this.txtTotalPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPrice.CustomButton.TabIndex = 1;
            this.txtTotalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPrice.CustomButton.UseSelectable = true;
            this.txtTotalPrice.CustomButton.Visible = false;
            this.txtTotalPrice.Lines = new string[0];
            this.txtTotalPrice.Location = new System.Drawing.Point(1000, 443);
            this.txtTotalPrice.MaxLength = 32767;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.SelectionLength = 0;
            this.txtTotalPrice.SelectionStart = 0;
            this.txtTotalPrice.ShortcutsEnabled = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(125, 23);
            this.txtTotalPrice.TabIndex = 37;
            this.txtTotalPrice.UseSelectable = true;
            this.txtTotalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(916, 443);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Total &Price";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(930, 500);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "&Return";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(943, 474);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "&Cash";
            // 
            // ucSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtReturn);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRmvCart);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnCartcart);
            this.Controls.Add(this.listView1);
            this.Name = "ucSale";
            this.Size = new System.Drawing.Size(1154, 569);
            this.Load += new System.EventHandler(this.ucSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView listView1;
        private System.Windows.Forms.ColumnHeader Product_Id;
        private System.Windows.Forms.ColumnHeader Product_Name;
        private System.Windows.Forms.ColumnHeader Unit_Type;
        private System.Windows.Forms.ColumnHeader Unit_Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private MetroFramework.Controls.MetroButton btnCartcart;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnRmvCart;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroTextBox txtQty;
        private MetroFramework.Controls.MetroListView listView2;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader UNIT_PR;
        private System.Windows.Forms.ColumnHeader QTY;
        private System.Windows.Forms.ColumnHeader TOTAL_PRICE;
        private MetroFramework.Controls.MetroTextBox txtReturn;
        private MetroFramework.Controls.MetroTextBox txtCash;
        private MetroFramework.Controls.MetroTextBox txtTotalPrice;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
