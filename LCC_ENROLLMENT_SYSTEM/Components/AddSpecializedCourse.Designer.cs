namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class AddSpecializedCourse
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
            this.textBoxName = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomTextBox();
            this.customLabel3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.textBoxDescription = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomTextBox();
            this.formFooter1 = new LCC_ENROLLMENT_SYSTEM.Components.FormFooter();
            this.SuspendLayout();
            // 
            // topbar1
            // 
            this.topbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.topbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar1.Location = new System.Drawing.Point(0, 0);
            this.topbar1.Name = "topbar1";
            this.topbar1.Size = new System.Drawing.Size(675, 101);
            this.topbar1.TabIndex = 0;
            this.topbar1.TextSize = 18;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel1.FontSize = 12F;
            this.customLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel1.Location = new System.Drawing.Point(255, 117);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(176, 24);
            this.customLabel1.TabIndex = 1;
            this.customLabel1.Text = "Add Specialized Course";
            this.customLabel1.Click += new System.EventHandler(this.customLabel1_Click);
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel2.FontSize = 12F;
            this.customLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel2.Location = new System.Drawing.Point(75, 166);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(109, 24);
            this.customLabel2.TabIndex = 2;
            this.customLabel2.Text = "Course Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderColor = System.Drawing.Color.Gray;
            this.textBoxName.BorderFocusColor = System.Drawing.Color.Gray;
            this.textBoxName.BorderRadius = 0;
            this.textBoxName.BorderSize = 1;
            this.textBoxName.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.FontSize = 10F;
            this.textBoxName.FontStyle = System.Drawing.FontStyle.Regular;
            this.textBoxName.Location = new System.Drawing.Point(190, 166);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.textBoxName.PasswordChar = false;
            this.textBoxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.ReadOnly = false;
            this.textBoxName.Size = new System.Drawing.Size(391, 40);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Texts = "";
            this.textBoxName.UnderlinedStyle = false;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.FontSize = 12F;
            this.customLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel3.Location = new System.Drawing.Point(90, 243);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(94, 24);
            this.customLabel3.TabIndex = 2;
            this.customLabel3.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderColor = System.Drawing.Color.Gray;
            this.textBoxDescription.BorderFocusColor = System.Drawing.Color.Gray;
            this.textBoxDescription.BorderRadius = 0;
            this.textBoxDescription.BorderSize = 1;
            this.textBoxDescription.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.FontSize = 10F;
            this.textBoxDescription.FontStyle = System.Drawing.FontStyle.Regular;
            this.textBoxDescription.Location = new System.Drawing.Point(190, 243);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.textBoxDescription.PasswordChar = false;
            this.textBoxDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxDescription.PlaceholderText = "";
            this.textBoxDescription.ReadOnly = false;
            this.textBoxDescription.Size = new System.Drawing.Size(391, 129);
            this.textBoxDescription.TabIndex = 3;
            this.textBoxDescription.Texts = "";
            this.textBoxDescription.UnderlinedStyle = false;
            // 
            // formFooter1
            // 
            this.formFooter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formFooter1.Location = new System.Drawing.Point(0, 420);
            this.formFooter1.Name = "formFooter1";
            this.formFooter1.Size = new System.Drawing.Size(675, 58);
            this.formFooter1.TabIndex = 4;
            this.formFooter1.onBtnSaveClicked += new System.EventHandler(this.formFooter1_onBtnSaveClicked);
            this.formFooter1.onBtnCancelClicked += new System.EventHandler(this.formFooter1_onBtnCancelClicked);
            this.formFooter1.Load += new System.EventHandler(this.formFooter1_Load);
            // 
            // AddSpecializedCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 478);
            this.Controls.Add(this.formFooter1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.topbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddSpecializedCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSpecializedCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Topbar topbar1;
        private CustomControls.CustomLabel customLabel1;
        private CustomControls.CustomLabel customLabel2;
        private CustomControls.CustomTextBox textBoxName;
        private CustomControls.CustomLabel customLabel3;
        private CustomControls.CustomTextBox textBoxDescription;
        private FormFooter formFooter1;
    }
}