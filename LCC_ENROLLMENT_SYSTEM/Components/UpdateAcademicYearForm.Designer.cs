namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class UpdateAcademicYearForm
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
            this.formFooter1 = new LCC_ENROLLMENT_SYSTEM.Components.FormFooter();
            this.textBoxTo = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomTextBox();
            this.textBoxFrom = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomTextBox();
            this.customLabel3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel2 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.topbar1 = new LCC_ENROLLMENT_SYSTEM.Components.Topbar();
            this.SuspendLayout();
            // 
            // formFooter1
            // 
            this.formFooter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formFooter1.Location = new System.Drawing.Point(0, 401);
            this.formFooter1.Name = "formFooter1";
            this.formFooter1.Size = new System.Drawing.Size(607, 61);
            this.formFooter1.TabIndex = 11;
            this.formFooter1.onBtnSaveClicked += new System.EventHandler(this.formFooter1_onBtnSaveClicked);
            this.formFooter1.onBtnResetClicked += new System.EventHandler(this.formFooter1_onBtnResetClicked);
            this.formFooter1.onBtnCancelClicked += new System.EventHandler(this.formFooter1_onBtnCancelClicked);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTo.BackColor = System.Drawing.Color.White;
            this.textBoxTo.BorderColor = System.Drawing.Color.Silver;
            this.textBoxTo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTo.BorderRadius = 0;
            this.textBoxTo.BorderSize = 1;
            this.textBoxTo.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTo.FontSize = 10F;
            this.textBoxTo.FontStyle = System.Drawing.FontStyle.Regular;
            this.textBoxTo.Location = new System.Drawing.Point(175, 283);
            this.textBoxTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTo.Multiline = false;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.textBoxTo.PasswordChar = false;
            this.textBoxTo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxTo.PlaceholderText = "";
            this.textBoxTo.ReadOnly = false;
            this.textBoxTo.Size = new System.Drawing.Size(327, 40);
            this.textBoxTo.TabIndex = 9;
            this.textBoxTo.Texts = "";
            this.textBoxTo.UnderlinedStyle = false;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFrom.BackColor = System.Drawing.Color.White;
            this.textBoxFrom.BorderColor = System.Drawing.Color.Silver;
            this.textBoxFrom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxFrom.BorderRadius = 0;
            this.textBoxFrom.BorderSize = 1;
            this.textBoxFrom.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFrom.FontSize = 10F;
            this.textBoxFrom.FontStyle = System.Drawing.FontStyle.Regular;
            this.textBoxFrom.Location = new System.Drawing.Point(175, 197);
            this.textBoxFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFrom.Multiline = false;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.textBoxFrom.PasswordChar = false;
            this.textBoxFrom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxFrom.PlaceholderText = "";
            this.textBoxFrom.ReadOnly = false;
            this.textBoxFrom.Size = new System.Drawing.Size(327, 40);
            this.textBoxFrom.TabIndex = 10;
            this.textBoxFrom.Texts = "";
            this.textBoxFrom.UnderlinedStyle = false;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.FontSize = 11F;
            this.customLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel3.Location = new System.Drawing.Point(126, 283);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(32, 22);
            this.customLabel3.TabIndex = 7;
            this.customLabel3.Text = "To:";
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Heebo", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel2.FontSize = 11F;
            this.customLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel2.Location = new System.Drawing.Point(109, 197);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(49, 22);
            this.customLabel2.TabIndex = 8;
            this.customLabel2.Text = "From:";
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel1.FontSize = 12F;
            this.customLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel1.Location = new System.Drawing.Point(242, 133);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(170, 24);
            this.customLabel1.TabIndex = 6;
            this.customLabel1.Text = "Update Academic Year";
            // 
            // topbar1
            // 
            this.topbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.topbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar1.Location = new System.Drawing.Point(0, 0);
            this.topbar1.Name = "topbar1";
            this.topbar1.Size = new System.Drawing.Size(607, 108);
            this.topbar1.TabIndex = 5;
            this.topbar1.TextSize = 18;
            // 
            // UpdateAcademicYearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 462);
            this.Controls.Add(this.formFooter1);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.topbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateAcademicYearForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAcademicYearForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormFooter formFooter1;
        private CustomControls.CustomTextBox textBoxTo;
        private CustomControls.CustomTextBox textBoxFrom;
        private CustomControls.CustomLabel customLabel3;
        private CustomControls.CustomLabel customLabel2;
        private CustomControls.CustomLabel customLabel1;
        private Topbar topbar1;
    }
}