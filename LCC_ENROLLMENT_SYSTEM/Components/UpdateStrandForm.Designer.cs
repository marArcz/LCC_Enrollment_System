namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class UpdateStrandForm
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
            this.textBoxStrand = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomTextBox();
            this.comboBoxTrack = new System.Windows.Forms.ComboBox();
            this.customLabel3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel2 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbar1
            // 
            this.topbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.topbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar1.Location = new System.Drawing.Point(0, 0);
            this.topbar1.Name = "topbar1";
            this.topbar1.Size = new System.Drawing.Size(687, 100);
            this.topbar1.TabIndex = 0;
            this.topbar1.TextSize = 22;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel1.FontSize = 12F;
            this.customLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel1.Location = new System.Drawing.Point(292, 124);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(111, 24);
            this.customLabel1.TabIndex = 1;
            this.customLabel1.Text = "Update Strand";
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
            this.textBoxStrand.Location = new System.Drawing.Point(121, 280);
            this.textBoxStrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStrand.Multiline = false;
            this.textBoxStrand.Name = "textBoxStrand";
            this.textBoxStrand.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.textBoxStrand.PasswordChar = false;
            this.textBoxStrand.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxStrand.PlaceholderText = "";
            this.textBoxStrand.Size = new System.Drawing.Size(476, 40);
            this.textBoxStrand.TabIndex = 8;
            this.textBoxStrand.Texts = "";
            this.textBoxStrand.UnderlinedStyle = false;
            // 
            // comboBoxTrack
            // 
            this.comboBoxTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTrack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTrack.FormattingEnabled = true;
            this.comboBoxTrack.Location = new System.Drawing.Point(120, 207);
            this.comboBoxTrack.Name = "comboBoxTrack";
            this.comboBoxTrack.Size = new System.Drawing.Size(476, 25);
            this.comboBoxTrack.TabIndex = 7;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.FontSize = 10F;
            this.customLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel3.Location = new System.Drawing.Point(120, 252);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(55, 21);
            this.customLabel3.TabIndex = 5;
            this.customLabel3.Text = "Strand:";
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel2.FontSize = 10F;
            this.customLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel2.Location = new System.Drawing.Point(120, 178);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(48, 21);
            this.customLabel2.TabIndex = 6;
            this.customLabel2.Text = "Track:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 72);
            this.panel1.TabIndex = 9;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.undo_arrow;
            this.btnReset.Location = new System.Drawing.Point(521, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 66);
            this.btnReset.TabIndex = 0;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.diskette__1_;
            this.btnSave.Location = new System.Drawing.Point(611, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 66);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 66);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // UpdateStrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxStrand);
            this.Controls.Add(this.comboBoxTrack);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.topbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateStrandForm";
            this.Text = "UpdateStrandForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Topbar topbar1;
        private CustomControls.CustomLabel customLabel1;
        private CustomControls.CustomTextBox textBoxStrand;
        private ComboBox comboBoxTrack;
        private CustomControls.CustomLabel customLabel3;
        private CustomControls.CustomLabel customLabel2;
        private Panel panel1;
        private Button btnSave;
        private Button btnClose;
        private Button btnReset;
    }
}