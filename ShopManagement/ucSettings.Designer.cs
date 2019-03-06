namespace ShopManagement
{
    partial class ucSettings
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
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.btn = new MetroFramework.Controls.MetroButton();
            this.btnChaneUserName = new MetroFramework.Controls.MetroButton();
            this.btnPassword = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel14
            // 
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(330, 50);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(81, 25);
            this.metroLabel14.TabIndex = 258;
            this.metroLabel14.Text = "Settings";
            // 
            // btn
            // 
            this.btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn.Location = new System.Drawing.Point(296, 136);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(160, 29);
            this.btn.TabIndex = 260;
            this.btn.Text = "Change Details";
            this.btn.UseSelectable = true;
            // 
            // btnChaneUserName
            // 
            this.btnChaneUserName.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnChaneUserName.Location = new System.Drawing.Point(296, 204);
            this.btnChaneUserName.Name = "btnChaneUserName";
            this.btnChaneUserName.Size = new System.Drawing.Size(160, 29);
            this.btnChaneUserName.TabIndex = 261;
            this.btnChaneUserName.Text = "Change User Name";
            this.btnChaneUserName.UseSelectable = true;
            // 
            // btnPassword
            // 
            this.btnPassword.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPassword.Location = new System.Drawing.Point(296, 275);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(160, 29);
            this.btnPassword.TabIndex = 263;
            this.btnPassword.Text = "Change Password";
            this.btnPassword.UseSelectable = true;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnChaneUserName);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.metroLabel14);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(1154, 569);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroButton btn;
        private MetroFramework.Controls.MetroButton btnChaneUserName;
        private MetroFramework.Controls.MetroButton btnPassword;
    }
}
