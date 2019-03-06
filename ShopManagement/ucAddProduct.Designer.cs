namespace ShopManagement
{
    partial class ucAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddProduct));
            this.panelProductImg = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.txtProductPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtProductQuantity = new MetroFramework.Controls.MetroTextBox();
            this.cmbUnitType = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.panelProductImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProductImg
            // 
            this.panelProductImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelProductImg.BackgroundImage")));
            this.panelProductImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelProductImg.Controls.Add(this.btnSave);
            this.panelProductImg.Controls.Add(this.cmbUnitType);
            this.panelProductImg.Controls.Add(this.txtProductQuantity);
            this.panelProductImg.Controls.Add(this.txtProductPrice);
            this.panelProductImg.Controls.Add(this.txtProductName);
            this.panelProductImg.Controls.Add(this.metroLabel4);
            this.panelProductImg.Controls.Add(this.metroLabel3);
            this.panelProductImg.Controls.Add(this.metroLabel2);
            this.panelProductImg.Controls.Add(this.metroLabel1);
            this.panelProductImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductImg.HorizontalScrollbarBarColor = true;
            this.panelProductImg.HorizontalScrollbarHighlightOnWheel = false;
            this.panelProductImg.HorizontalScrollbarSize = 10;
            this.panelProductImg.Location = new System.Drawing.Point(0, 0);
            this.panelProductImg.Name = "panelProductImg";
            this.panelProductImg.Size = new System.Drawing.Size(1154, 569);
            this.panelProductImg.TabIndex = 0;
            this.panelProductImg.VerticalScrollbarBarColor = true;
            this.panelProductImg.VerticalScrollbarHighlightOnWheel = false;
            this.panelProductImg.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(84, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(134, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Product Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(124, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Unit Type";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(123, 224);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Unit Price";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(132, 296);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Quantity";
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(247, 96);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PromptText = "Product Name";
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(149, 23);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMark = "Product Name";
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductPrice
            // 
            // 
            // 
            // 
            this.txtProductPrice.CustomButton.Image = null;
            this.txtProductPrice.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtProductPrice.CustomButton.Name = "";
            this.txtProductPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductPrice.CustomButton.TabIndex = 1;
            this.txtProductPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductPrice.CustomButton.UseSelectable = true;
            this.txtProductPrice.CustomButton.Visible = false;
            this.txtProductPrice.Lines = new string[0];
            this.txtProductPrice.Location = new System.Drawing.Point(247, 226);
            this.txtProductPrice.MaxLength = 32767;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.PasswordChar = '\0';
            this.txtProductPrice.PromptText = "Product Price";
            this.txtProductPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductPrice.SelectedText = "";
            this.txtProductPrice.SelectionLength = 0;
            this.txtProductPrice.SelectionStart = 0;
            this.txtProductPrice.ShortcutsEnabled = true;
            this.txtProductPrice.Size = new System.Drawing.Size(149, 23);
            this.txtProductPrice.TabIndex = 3;
            this.txtProductPrice.UseSelectable = true;
            this.txtProductPrice.WaterMark = "Product Price";
            this.txtProductPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductQuantity
            // 
            // 
            // 
            // 
            this.txtProductQuantity.CustomButton.Image = null;
            this.txtProductQuantity.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtProductQuantity.CustomButton.Name = "";
            this.txtProductQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductQuantity.CustomButton.TabIndex = 1;
            this.txtProductQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductQuantity.CustomButton.UseSelectable = true;
            this.txtProductQuantity.CustomButton.Visible = false;
            this.txtProductQuantity.Lines = new string[0];
            this.txtProductQuantity.Location = new System.Drawing.Point(247, 296);
            this.txtProductQuantity.MaxLength = 32767;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.PasswordChar = '\0';
            this.txtProductQuantity.PromptText = "Quantity";
            this.txtProductQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductQuantity.SelectedText = "";
            this.txtProductQuantity.SelectionLength = 0;
            this.txtProductQuantity.SelectionStart = 0;
            this.txtProductQuantity.ShortcutsEnabled = true;
            this.txtProductQuantity.Size = new System.Drawing.Size(149, 23);
            this.txtProductQuantity.TabIndex = 3;
            this.txtProductQuantity.UseSelectable = true;
            this.txtProductQuantity.WaterMark = "Quantity";
            this.txtProductQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.ItemHeight = 23;
            this.cmbUnitType.Items.AddRange(new object[] {
            "liter",
            "kg",
            "pcs"});
            this.cmbUnitType.Location = new System.Drawing.Point(247, 168);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(149, 29);
            this.cmbUnitType.TabIndex = 4;
            this.cmbUnitType.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(302, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProductImg);
            this.Name = "ucAddProduct";
            this.Size = new System.Drawing.Size(1154, 569);
            this.panelProductImg.ResumeLayout(false);
            this.panelProductImg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelProductImg;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroComboBox cmbUnitType;
        private MetroFramework.Controls.MetroTextBox txtProductQuantity;
        private MetroFramework.Controls.MetroTextBox txtProductPrice;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
