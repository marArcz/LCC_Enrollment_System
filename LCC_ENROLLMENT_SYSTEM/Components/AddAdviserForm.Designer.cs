namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class AddAdviserForm
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
            this.topbar1 = new LCC_ENROLLMENT_SYSTEM.Components.Topbar();
            this.customLabel1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel2 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.textBoxFirstname = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomTextBox();
            this.customLabel3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.textBoxMiddlename = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomTextBox();
            this.customLabel4 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.textBoxLastname = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomTextBox();
            this.formFooter1 = new LCC_ENROLLMENT_SYSTEM.Components.FormFooter();
            this.SuspendLayout();
            // 
            // topbar1
            // 
            this.topbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar1.Location = new System.Drawing.Point(0, 0);
            this.topbar1.Name = "topbar1";
            this.topbar1.Size = new System.Drawing.Size(555, 83);
            this.topbar1.TabIndex = 1;
            this.topbar1.TextSize = 16;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Heebo", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel1.FontSize = 11F;
            this.customLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel1.Location = new System.Drawing.Point(219, 103);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(124, 22);
            this.customLabel1.TabIndex = 2;
            this.customLabel1.Text = "Add New Adviser";
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel2.FontSize = 10F;
            this.customLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel2.Location = new System.Drawing.Point(32, 146);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(73, 21);
            this.customLabel2.TabIndex = 3;
            this.customLabel2.Text = "Firstname";
            this.customLabel2.Click += new System.EventHandler(this.customLabel2_Click);
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstname.BackColor = System.Drawing.Color.White;
            this.textBoxFirstname.BorderColor = System.Drawing.Color.Silver;
            this.textBoxFirstname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxFirstname.BorderRadius = 0;
            this.textBoxFirstname.BorderSize = 1;
            this.textBoxFirstname.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFirstname.FontSize = 10F;
            this.textBoxFirstname.FontStyle = System.Drawing.FontStyle.Regular;
            this.textBoxFirstname.Location = new System.Drawing.Point(32, 172);
            this.textBoxFirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstname.Multiline = false;
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.textBoxFirstname.PasswordChar = false;
            this.textBoxFirstname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxFirstname.PlaceholderText = "";
            this.textBoxFirstname.ReadOnly = false;
            this.textBoxFirstname.Size = new System.Drawing.Size(492, 40);
            this.textBoxFirstname.TabIndex = 4;
            this.textBoxFirstname.Texts = "";
            this.textBoxFirstname.UnderlinedStyle = false;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.FontSize = 10F;
            this.customLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel3.Location = new System.Drawing.Point(32, 232);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(86, 21);
            this.customLabel3.TabIndex = 3;
            this.customLabel3.Text = "Middlename";
            this.customLabel3.Click += new System.EventHandler(this.customLabel2_Click);
            // 
            // textBoxMiddlename
            // 
            this.textBoxMiddlename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMiddlename.BackColor = System.Drawing.Color.White;
            this.textBoxMiddlename.BorderColor = System.Drawing.Color.Silver;
            this.textBoxMiddlename.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMiddlename.BorderRadius = 0;
            this.textBoxMiddlename.BorderSize = 1;
            this.textBoxMiddlename.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMiddlename.FontSize = 10F;
            this.textBoxMiddlename.FontStyle = System.Drawing.FontStyle.Regular;
            this.textBoxMiddlename.Location = new System.Drawing.Point(32, 258);
            this.textBoxMiddlename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMiddlename.Multiline = false;
            this.textBoxMiddlename.Name = "textBoxMiddlename";
            this.textBoxMiddlename.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.textBoxMiddlename.PasswordChar = false;
            this.textBoxMiddlename.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxMiddlename.PlaceholderText = "";
            this.textBoxMiddlename.ReadOnly = false;
            this.textBoxMiddlename.Size = new System.Drawing.Size(492, 40);
            this.textBoxMiddlename.TabIndex = 4;
            this.textBoxMiddlename.Texts = "";
            this.textBoxMiddlename.UnderlinedStyle = false;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel4.FontSize = 10F;
            this.customLabel4.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel4.Location = new System.Drawing.Point(32, 311);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(73, 21);
            this.customLabel4.TabIndex = 3;
            this.customLabel4.Text = "Lastname";
            this.customLabel4.Click += new System.EventHandler(this.customLabel2_Click);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastname.BackColor = System.Drawing.Color.White;
            this.textBoxLastname.BorderColor = System.Drawing.Color.Silver;
            this.textBoxLastname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxLastname.BorderRadius = 0;
            this.textBoxLastname.BorderSize = 1;
            this.textBoxLastname.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastname.FontSize = 10F;
            this.textBoxLastname.FontStyle = System.Drawing.FontStyle.Regular;
            this.textBoxLastname.Location = new System.Drawing.Point(32, 337);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastname.Multiline = false;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.textBoxLastname.PasswordChar = false;
            this.textBoxLastname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxLastname.PlaceholderText = "";
            this.textBoxLastname.ReadOnly = false;
            this.textBoxLastname.Size = new System.Drawing.Size(492, 40);
            this.textBoxLastname.TabIndex = 4;
            this.textBoxLastname.Texts = "";
            this.textBoxLastname.UnderlinedStyle = false;
            // 
            // formFooter1
            // 
            this.formFooter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formFooter1.Location = new System.Drawing.Point(0, 425);
            this.formFooter1.Name = "formFooter1";
            this.formFooter1.Size = new System.Drawing.Size(555, 65);
            this.formFooter1.TabIndex = 5;
            this.formFooter1.onBtnSaveClicked += new System.EventHandler(this.formFooter1_onBtnSaveClicked);
            // 
            // AddAdviserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 490);
            this.Controls.Add(this.formFooter1);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.textBoxMiddlename);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.topbar1);
            this.Name = "AddAdviserForm";
            this.Text = "AddAdviserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Topbar topbar1;
        private CustomControls.CustomLabel customLabel1;
        private CustomControls.CustomLabel customLabel2;
        private CustomControls.CustomTextBox textBoxFirstname;
        private CustomControls.CustomLabel customLabel3;
        private CustomControls.CustomTextBox textBoxMiddlename;
        private CustomControls.CustomLabel customLabel4;
        private CustomControls.CustomTextBox textBoxLastname;
        private FormFooter formFooter1;
    }
}