﻿namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class AddJuniorHighEnrollmentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.customLabel2 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListSubjects = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewAdviser = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.comboBoxAdvisers = new System.Windows.Forms.ComboBox();
            this.customLabel9 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.btnAddSection = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.customLabel6 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.comboBoxSchoolYears = new System.Windows.Forms.ComboBox();
            this.customLabel8 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.customLabel5 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.customLabel4 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel7 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.dataGridViewStudents);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.customLabel2);
            this.panel1.Controls.Add(this.customLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 647);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_no,
            this.Fullname});
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 114);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowTemplate.Height = 25;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(257, 521);
            this.dataGridViewStudents.TabIndex = 5;
            this.dataGridViewStudents.SelectionChanged += new System.EventHandler(this.dataGridViewStudents_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // id_no
            // 
            this.id_no.HeaderText = "ID NO";
            this.id_no.Name = "id_no";
            this.id_no.ReadOnly = true;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "FULLNAME";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(11, 85);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(258, 23);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel2.FontSize = 9F;
            this.customLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel2.Location = new System.Drawing.Point(10, 57);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(110, 18);
            this.customLabel2.TabIndex = 3;
            this.customLabel2.Text = "Search for student:";
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customLabel1.FontSize = 12F;
            this.customLabel1.FontStyle = System.Drawing.FontStyle.Bold;
            this.customLabel1.Location = new System.Drawing.Point(10, 17);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(138, 24);
            this.customLabel1.TabIndex = 2;
            this.customLabel1.Text = "List of Students";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.customLabel7);
            this.panel2.Controls.Add(this.customLabel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(282, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 647);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(600, 608);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(498, 608);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(11, 608);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkedListSubjects);
            this.groupBox3.Location = new System.Drawing.Point(11, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 249);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subjects";
            // 
            // checkedListSubjects
            // 
            this.checkedListSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListSubjects.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListSubjects.FormattingEnabled = true;
            this.checkedListSubjects.Location = new System.Drawing.Point(16, 27);
            this.checkedListSubjects.MultiColumn = true;
            this.checkedListSubjects.Name = "checkedListSubjects";
            this.checkedListSubjects.Size = new System.Drawing.Size(630, 200);
            this.checkedListSubjects.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.customLabel4);
            this.groupBox1.Location = new System.Drawing.Point(11, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 241);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnNewAdviser);
            this.groupBox2.Controls.Add(this.comboBoxAdvisers);
            this.groupBox2.Controls.Add(this.customLabel9);
            this.groupBox2.Controls.Add(this.btnAddSection);
            this.groupBox2.Controls.Add(this.comboBoxSection);
            this.groupBox2.Controls.Add(this.customLabel6);
            this.groupBox2.Controls.Add(this.comboBoxSchoolYears);
            this.groupBox2.Controls.Add(this.customLabel8);
            this.groupBox2.Controls.Add(this.comboBoxLevel);
            this.groupBox2.Controls.Add(this.customLabel5);
            this.groupBox2.Location = new System.Drawing.Point(17, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 142);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade or Year Level";
            // 
            // btnNewAdviser
            // 
            this.btnNewAdviser.BackColor = System.Drawing.Color.White;
            this.btnNewAdviser.BackgroundColor = System.Drawing.Color.White;
            this.btnNewAdviser.BorderColor = System.Drawing.Color.Green;
            this.btnNewAdviser.BorderRadius = 3;
            this.btnNewAdviser.BorderSize = 1;
            this.btnNewAdviser.FlatAppearance.BorderSize = 0;
            this.btnNewAdviser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAdviser.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewAdviser.FontSize = 9F;
            this.btnNewAdviser.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnNewAdviser.ForeColor = System.Drawing.Color.Green;
            this.btnNewAdviser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewAdviser.Location = new System.Drawing.Point(569, 88);
            this.btnNewAdviser.Name = "btnNewAdviser";
            this.btnNewAdviser.Size = new System.Drawing.Size(43, 26);
            this.btnNewAdviser.TabIndex = 6;
            this.btnNewAdviser.Text = "New";
            this.btnNewAdviser.TextColor = System.Drawing.Color.Green;
            this.btnNewAdviser.UseVisualStyleBackColor = false;
            this.btnNewAdviser.Click += new System.EventHandler(this.btnNewAdviser_Click);
            // 
            // comboBoxAdvisers
            // 
            this.comboBoxAdvisers.BackColor = System.Drawing.Color.White;
            this.comboBoxAdvisers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdvisers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAdvisers.FormattingEnabled = true;
            this.comboBoxAdvisers.Location = new System.Drawing.Point(333, 88);
            this.comboBoxAdvisers.Name = "comboBoxAdvisers";
            this.comboBoxAdvisers.Size = new System.Drawing.Size(227, 25);
            this.comboBoxAdvisers.TabIndex = 5;
            // 
            // customLabel9
            // 
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel9.FontSize = 9F;
            this.customLabel9.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel9.Location = new System.Drawing.Point(279, 90);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(51, 18);
            this.customLabel9.TabIndex = 4;
            this.customLabel9.Text = "Adviser:";
            // 
            // btnAddSection
            // 
            this.btnAddSection.BackColor = System.Drawing.Color.White;
            this.btnAddSection.BackgroundColor = System.Drawing.Color.White;
            this.btnAddSection.BorderColor = System.Drawing.Color.Green;
            this.btnAddSection.BorderRadius = 3;
            this.btnAddSection.BorderSize = 1;
            this.btnAddSection.FlatAppearance.BorderSize = 0;
            this.btnAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSection.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSection.FontSize = 9F;
            this.btnAddSection.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddSection.ForeColor = System.Drawing.Color.Green;
            this.btnAddSection.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSection.Location = new System.Drawing.Point(569, 38);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(43, 26);
            this.btnAddSection.TabIndex = 3;
            this.btnAddSection.Text = "New";
            this.btnAddSection.TextColor = System.Drawing.Color.Green;
            this.btnAddSection.UseVisualStyleBackColor = false;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(333, 39);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(227, 25);
            this.comboBoxSection.TabIndex = 1;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel6.FontSize = 9F;
            this.customLabel6.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel6.Location = new System.Drawing.Point(279, 41);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(48, 18);
            this.customLabel6.TabIndex = 0;
            this.customLabel6.Text = "Section";
            // 
            // comboBoxSchoolYears
            // 
            this.comboBoxSchoolYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSchoolYears.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSchoolYears.FormattingEnabled = true;
            this.comboBoxSchoolYears.Location = new System.Drawing.Point(97, 91);
            this.comboBoxSchoolYears.Name = "comboBoxSchoolYears";
            this.comboBoxSchoolYears.Size = new System.Drawing.Size(152, 25);
            this.comboBoxSchoolYears.TabIndex = 1;
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel8.FontSize = 9F;
            this.customLabel8.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel8.Location = new System.Drawing.Point(16, 95);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(75, 18);
            this.customLabel8.TabIndex = 0;
            this.customLabel8.Text = "School Year:";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Location = new System.Drawing.Point(58, 39);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(191, 25);
            this.comboBoxLevel.TabIndex = 1;
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel5.FontSize = 9F;
            this.customLabel5.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel5.Location = new System.Drawing.Point(16, 42);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(38, 18);
            this.customLabel5.TabIndex = 0;
            this.customLabel5.Text = "Level:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(65, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(580, 25);
            this.textBoxName.TabIndex = 2;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel4.FontSize = 9F;
            this.customLabel4.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel4.Location = new System.Drawing.Point(13, 42);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(44, 18);
            this.customLabel4.TabIndex = 0;
            this.customLabel4.Text = "Name:";
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customLabel7.FontSize = 12F;
            this.customLabel7.FontStyle = System.Drawing.FontStyle.Bold;
            this.customLabel7.Location = new System.Drawing.Point(6, 17);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(156, 24);
            this.customLabel7.TabIndex = 1;
            this.customLabel7.Text = "Junior Highschool";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.FontSize = 10F;
            this.customLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel3.Location = new System.Drawing.Point(7, 48);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(126, 21);
            this.customLabel3.TabIndex = 2;
            this.customLabel3.Text = "ENROLL STUDENT";
            // 
            // AddJuniorHighEnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddJuniorHighEnrollmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddJuniorHighEnrollmentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        public CustomControls.CustomLabel customLabel2;
        public CustomControls.CustomLabel customLabel1;
        private TextBox textBoxSearch;
        private DataGridView dataGridViewStudents;
        public CustomControls.CustomLabel customLabel7;
        public CustomControls.CustomLabel customLabel3;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn id_no;
        private DataGridViewTextBoxColumn Fullname;
        private GroupBox groupBox1;
        private CustomControls.CustomLabel customLabel4;
        public TextBox textBoxName;
        public GroupBox groupBox2;
        public ComboBox comboBoxSection;
        public CustomControls.CustomLabel customLabel6;
        public ComboBox comboBoxLevel;
        public CustomControls.CustomLabel customLabel5;
        public GroupBox groupBox3;
        public CheckedListBox checkedListSubjects;
        public Button btnSave;
        public Button btnClear;
        public Button btnCancel;
        public ComboBox comboBoxSchoolYears;
        public CustomControls.CustomLabel customLabel8;
        private CustomControls.CustomButton btnAddSection;
        private CustomControls.CustomButton btnNewAdviser;
        public ComboBox comboBoxAdvisers;
        public CustomControls.CustomLabel customLabel9;
    }
}