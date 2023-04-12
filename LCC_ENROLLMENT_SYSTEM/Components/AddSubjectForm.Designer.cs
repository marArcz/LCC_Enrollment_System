namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class AddSubjectForm
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
            this.textBoxSubject = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomTextBox();
            this.customLabel3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.textBoxDescription = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomTextBox();
            this.customLabel4 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.customButton1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.btnSave = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbar1
            // 
            this.topbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.topbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar1.Location = new System.Drawing.Point(0, 0);
            this.topbar1.Name = "topbar1";
            this.topbar1.Size = new System.Drawing.Size(759, 114);
            this.topbar1.TabIndex = 0;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel1.FontSize = 12F;
            this.customLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel1.Location = new System.Drawing.Point(339, 134);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(130, 24);
            this.customLabel1.TabIndex = 1;
            this.customLabel1.Text = "Add New Subject";
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Heebo", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel2.FontSize = 11F;
            this.customLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel2.Location = new System.Drawing.Point(134, 189);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(64, 22);
            this.customLabel2.TabIndex = 2;
            this.customLabel2.Text = "Subject:";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubject.BackColor = System.Drawing.Color.White;
            this.textBoxSubject.BorderColor = System.Drawing.Color.DodgerBlue;
            this.textBoxSubject.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxSubject.BorderRadius = 0;
            this.textBoxSubject.BorderSize = 1;
            this.textBoxSubject.Location = new System.Drawing.Point(217, 184);
            this.textBoxSubject.Multiline = false;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxSubject.PasswordChar = false;
            this.textBoxSubject.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSubject.PlaceholderText = "";
            this.textBoxSubject.Size = new System.Drawing.Size(465, 30);
            this.textBoxSubject.TabIndex = 3;
            this.textBoxSubject.Texts = "";
            this.textBoxSubject.UnderlinedStyle = false;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.FontSize = 11F;
            this.customLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel3.Location = new System.Drawing.Point(107, 253);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(91, 22);
            this.customLabel3.TabIndex = 2;
            this.customLabel3.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderColor = System.Drawing.Color.DodgerBlue;
            this.textBoxDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxDescription.BorderRadius = 0;
            this.textBoxDescription.BorderSize = 1;
            this.textBoxDescription.Location = new System.Drawing.Point(217, 253);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxDescription.PasswordChar = false;
            this.textBoxDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxDescription.PlaceholderText = "";
            this.textBoxDescription.Size = new System.Drawing.Size(465, 86);
            this.textBoxDescription.TabIndex = 3;
            this.textBoxDescription.Texts = "";
            this.textBoxDescription.UnderlinedStyle = false;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Heebo", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel4.FontSize = 11F;
            this.customLabel4.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel4.Location = new System.Drawing.Point(149, 361);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(49, 22);
            this.customLabel4.TabIndex = 2;
            this.customLabel4.Text = "Level:";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Location = new System.Drawing.Point(217, 362);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(465, 23);
            this.comboBoxLevel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 68);
            this.panel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.FontSize = 10F;
            this.btnCancel.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.close;
            this.btnCancel.Location = new System.Drawing.Point(12, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 44);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 5;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton1.FontSize = 10F;
            this.customButton1.FontStyle = System.Drawing.FontStyle.Regular;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.undo_arrow;
            this.customButton1.Location = new System.Drawing.Point(597, 12);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(63, 44);
            this.customButton1.TabIndex = 0;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.FontSize = 10F;
            this.btnSave.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.diskette__1_;
            this.btnSave.Location = new System.Drawing.Point(684, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.topbar1);
            this.Name = "AddSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubjectForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Topbar topbar1;
        private CustomControls.CustomLabel customLabel1;
        private CustomControls.CustomLabel customLabel2;
        private CustomControls.CustomTextBox textBoxSubject;
        private CustomControls.CustomLabel customLabel3;
        private CustomControls.CustomTextBox textBoxDescription;
        private CustomControls.CustomLabel customLabel4;
        private ComboBox comboBoxLevel;
        private Panel panel1;
        private CustomControls.CustomButton btnSave;
        private CustomControls.CustomButton btnCancel;
        private CustomControls.CustomButton customButton1;
    }
}