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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.customButton1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.btnSave = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.customLabel4 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.borderedPanel1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.BorderedPanel();
            this.checkedListLevels = new System.Windows.Forms.CheckedListBox();
            this.timePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.customLabel3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel5 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel6 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.timePickerTo = new System.Windows.Forms.DateTimePicker();
            this.customLabel7 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.borderedPanel2 = new LCC_ENROLLMENT_SYSTEM.CustomControls.BorderedPanel();
            this.checkedListDays = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.borderedPanel1.SuspendLayout();
            this.borderedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbar1
            // 
            this.topbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.topbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar1.Location = new System.Drawing.Point(0, 0);
            this.topbar1.Name = "topbar1";
            this.topbar1.Size = new System.Drawing.Size(734, 89);
            this.topbar1.TabIndex = 0;
            this.topbar1.TextSize = 18;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel1.FontSize = 12F;
            this.customLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel1.Location = new System.Drawing.Point(321, 108);
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
            this.customLabel2.Location = new System.Drawing.Point(106, 157);
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
            this.textBoxSubject.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSubject.FontSize = 10F;
            this.textBoxSubject.FontStyle = System.Drawing.FontStyle.Regular;
            this.textBoxSubject.Location = new System.Drawing.Point(189, 152);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSubject.Multiline = false;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxSubject.PasswordChar = false;
            this.textBoxSubject.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSubject.PlaceholderText = "";
            this.textBoxSubject.ReadOnly = false;
            this.textBoxSubject.Size = new System.Drawing.Size(440, 36);
            this.textBoxSubject.TabIndex = 3;
            this.textBoxSubject.Texts = "";
            this.textBoxSubject.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 577);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 61);
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
            this.btnCancel.Location = new System.Drawing.Point(12, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 44);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.customButton1.Location = new System.Drawing.Point(564, 12);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(63, 44);
            this.customButton1.TabIndex = 0;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSave.Location = new System.Drawing.Point(650, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Heebo", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel4.FontSize = 11F;
            this.customLabel4.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel4.Location = new System.Drawing.Point(70, 214);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(100, 22);
            this.customLabel4.TabIndex = 2;
            this.customLabel4.Text = "Grade Levels:";
            this.customLabel4.Click += new System.EventHandler(this.customLabel4_Click);
            // 
            // borderedPanel1
            // 
            this.borderedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderedPanel1.BackColor = System.Drawing.Color.White;
            this.borderedPanel1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.borderedPanel1.BorderRadius = 0;
            this.borderedPanel1.BorderSize = 1;
            this.borderedPanel1.Controls.Add(this.checkedListLevels);
            this.borderedPanel1.ForeColor = System.Drawing.Color.Black;
            this.borderedPanel1.Location = new System.Drawing.Point(189, 214);
            this.borderedPanel1.Name = "borderedPanel1";
            this.borderedPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.borderedPanel1.Size = new System.Drawing.Size(440, 111);
            this.borderedPanel1.TabIndex = 6;
            // 
            // checkedListLevels
            // 
            this.checkedListLevels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListLevels.FormattingEnabled = true;
            this.checkedListLevels.Location = new System.Drawing.Point(10, 10);
            this.checkedListLevels.MultiColumn = true;
            this.checkedListLevels.Name = "checkedListLevels";
            this.checkedListLevels.Size = new System.Drawing.Size(420, 91);
            this.checkedListLevels.TabIndex = 0;
            // 
            // timePickerFrom
            // 
            this.timePickerFrom.CustomFormat = "hh:mm";
            this.timePickerFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.timePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerFrom.Location = new System.Drawing.Point(190, 376);
            this.timePickerFrom.Name = "timePickerFrom";
            this.timePickerFrom.ShowUpDown = true;
            this.timePickerFrom.Size = new System.Drawing.Size(184, 23);
            this.timePickerFrom.TabIndex = 7;
            this.timePickerFrom.Value = new System.DateTime(2023, 6, 5, 14, 26, 0, 0);
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.FontSize = 10F;
            this.customLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel3.Location = new System.Drawing.Point(341, 339);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(88, 21);
            this.customLabel3.TabIndex = 2;
            this.customLabel3.Text = "Set schedule";
            this.customLabel3.Click += new System.EventHandler(this.customLabel4_Click);
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel5.FontSize = 10F;
            this.customLabel5.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel5.Location = new System.Drawing.Point(124, 380);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(46, 21);
            this.customLabel5.TabIndex = 2;
            this.customLabel5.Text = "From:";
            this.customLabel5.Click += new System.EventHandler(this.customLabel4_Click);
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel6.FontSize = 10F;
            this.customLabel6.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel6.Location = new System.Drawing.Point(421, 377);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(29, 21);
            this.customLabel6.TabIndex = 2;
            this.customLabel6.Text = "To:";
            this.customLabel6.Click += new System.EventHandler(this.customLabel4_Click);
            // 
            // timePickerTo
            // 
            this.timePickerTo.CustomFormat = "hh:mm";
            this.timePickerTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.timePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerTo.Location = new System.Drawing.Point(455, 376);
            this.timePickerTo.Name = "timePickerTo";
            this.timePickerTo.ShowUpDown = true;
            this.timePickerTo.Size = new System.Drawing.Size(172, 23);
            this.timePickerTo.TabIndex = 7;
            this.timePickerTo.Value = new System.DateTime(2023, 6, 5, 14, 26, 0, 0);
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Heebo", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel7.FontSize = 11F;
            this.customLabel7.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel7.Location = new System.Drawing.Point(123, 438);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(47, 22);
            this.customLabel7.TabIndex = 2;
            this.customLabel7.Text = "Days:";
            this.customLabel7.Click += new System.EventHandler(this.customLabel4_Click);
            // 
            // borderedPanel2
            // 
            this.borderedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderedPanel2.BackColor = System.Drawing.Color.White;
            this.borderedPanel2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.borderedPanel2.BorderRadius = 0;
            this.borderedPanel2.BorderSize = 1;
            this.borderedPanel2.Controls.Add(this.checkedListDays);
            this.borderedPanel2.ForeColor = System.Drawing.Color.Black;
            this.borderedPanel2.Location = new System.Drawing.Point(190, 428);
            this.borderedPanel2.Name = "borderedPanel2";
            this.borderedPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.borderedPanel2.Size = new System.Drawing.Size(440, 111);
            this.borderedPanel2.TabIndex = 6;
            // 
            // checkedListDays
            // 
            this.checkedListDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListDays.FormattingEnabled = true;
            this.checkedListDays.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.checkedListDays.Location = new System.Drawing.Point(10, 10);
            this.checkedListDays.MultiColumn = true;
            this.checkedListDays.Name = "checkedListDays";
            this.checkedListDays.Size = new System.Drawing.Size(420, 91);
            this.checkedListDays.TabIndex = 0;
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 638);
            this.Controls.Add(this.timePickerTo);
            this.Controls.Add(this.timePickerFrom);
            this.Controls.Add(this.borderedPanel2);
            this.Controls.Add(this.borderedPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.topbar1);
            this.Name = "AddSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubjectForm";
            this.panel1.ResumeLayout(false);
            this.borderedPanel1.ResumeLayout(false);
            this.borderedPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Topbar topbar1;
        private CustomControls.CustomLabel customLabel1;
        private CustomControls.CustomLabel customLabel2;
        private CustomControls.CustomTextBox textBoxSubject;
        private Panel panel1;
        private CustomControls.CustomButton btnSave;
        private CustomControls.CustomButton btnCancel;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomLabel customLabel4;
        private CustomControls.BorderedPanel borderedPanel1;
        private CheckedListBox checkedListLevels;
        private DateTimePicker timePickerFrom;
        private CustomControls.CustomLabel customLabel3;
        private CustomControls.CustomLabel customLabel5;
        private CustomControls.CustomLabel customLabel6;
        private DateTimePicker timePickerTo;
        private CustomControls.CustomLabel customLabel7;
        private CustomControls.BorderedPanel borderedPanel2;
        private CheckedListBox checkedListDays;
    }
}