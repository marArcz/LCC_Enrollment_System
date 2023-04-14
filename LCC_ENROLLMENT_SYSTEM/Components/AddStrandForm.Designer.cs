namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class AddStrandForm
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
            this.comboBoxTrack = new System.Windows.Forms.ComboBox();
            this.customLabel3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.textBoxStrand = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomTextBox();
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
            this.topbar1.Size = new System.Drawing.Size(800, 113);
            this.topbar1.TabIndex = 0;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customLabel1.FontSize = 12F;
            this.customLabel1.FontStyle = System.Drawing.FontStyle.Bold;
            this.customLabel1.Location = new System.Drawing.Point(340, 132);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(138, 24);
            this.customLabel1.TabIndex = 1;
            this.customLabel1.Text = "Add New Strand";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel2.FontSize = 10F;
            this.customLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel2.Location = new System.Drawing.Point(158, 182);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(48, 21);
            this.customLabel2.TabIndex = 2;
            this.customLabel2.Text = "Track:";
            // 
            // comboBoxTrack
            // 
            this.comboBoxTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTrack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTrack.FormattingEnabled = true;
            this.comboBoxTrack.Location = new System.Drawing.Point(158, 211);
            this.comboBoxTrack.Name = "comboBoxTrack";
            this.comboBoxTrack.Size = new System.Drawing.Size(476, 25);
            this.comboBoxTrack.TabIndex = 3;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.FontSize = 10F;
            this.customLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel3.Location = new System.Drawing.Point(158, 256);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(55, 21);
            this.customLabel3.TabIndex = 2;
            this.customLabel3.Text = "Strand:";
            // 
            // textBoxStrand
            // 
            this.textBoxStrand.BackColor = System.Drawing.Color.White;
            this.textBoxStrand.BorderColor = System.Drawing.Color.DarkGray;
            this.textBoxStrand.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxStrand.BorderRadius = 0;
            this.textBoxStrand.BorderSize = 1;
            this.textBoxStrand.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStrand.FontSize = 10F;
            this.textBoxStrand.FontStyle = System.Drawing.FontStyle.Regular;
            this.textBoxStrand.Location = new System.Drawing.Point(159, 284);
            this.textBoxStrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStrand.Multiline = false;
            this.textBoxStrand.Name = "textBoxStrand";
            this.textBoxStrand.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.textBoxStrand.PasswordChar = false;
            this.textBoxStrand.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxStrand.PlaceholderText = "";
            this.textBoxStrand.Size = new System.Drawing.Size(476, 40);
            this.textBoxStrand.TabIndex = 4;
            this.textBoxStrand.Texts = "";
            this.textBoxStrand.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 68);
            this.panel1.TabIndex = 6;
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.customButton1.Location = new System.Drawing.Point(619, 12);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(63, 44);
            this.customButton1.TabIndex = 0;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
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
            this.btnSave.Location = new System.Drawing.Point(713, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddStrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxStrand);
            this.Controls.Add(this.comboBoxTrack);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.topbar1);
            this.Name = "AddStrandForm";
            this.Text = "AddStrandForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Topbar topbar1;
        private CustomControls.CustomLabel customLabel1;
        private CustomControls.CustomLabel customLabel2;
        private ComboBox comboBoxTrack;
        private CustomControls.CustomLabel customLabel3;
        private CustomControls.CustomTextBox textBoxStrand;
        private Panel panel1;
        private CustomControls.CustomButton btnCancel;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomButton btnSave;
    }
}