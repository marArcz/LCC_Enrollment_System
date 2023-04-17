namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class AddElementaryEnrollment
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.dataGridViewStudents);
            this.panel1.Controls.Add(this.customLabel2);
            this.panel1.Controls.Add(this.customLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 647);
            this.panel1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(12, 73);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(265, 25);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
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
            this.idNo,
            this.fullname});
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 102);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowTemplate.Height = 25;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(265, 533);
            this.dataGridViewStudents.TabIndex = 3;
            this.dataGridViewStudents.SelectionChanged += new System.EventHandler(this.dataGridViewStudents_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // idNo
            // 
            this.idNo.HeaderText = "ID NO";
            this.idNo.Name = "idNo";
            this.idNo.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "FULLNAME";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel2.FontSize = 9F;
            this.customLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel2.Location = new System.Drawing.Point(11, 52);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(109, 15);
            this.customLabel2.TabIndex = 1;
            this.customLabel2.Text = "Search for student:";
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customLabel1.FontSize = 12F;
            this.customLabel1.FontStyle = System.Drawing.FontStyle.Bold;
            this.customLabel1.Location = new System.Drawing.Point(11, 12);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(137, 20);
            this.customLabel1.TabIndex = 0;
            this.customLabel1.Text = "List of Students";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.customLabel7);
            this.panel2.Controls.Add(this.customLabel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(294, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 647);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(590, 608);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(497, 608);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(8, 608);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 3;
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
            this.groupBox3.Location = new System.Drawing.Point(8, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(655, 228);
            this.groupBox3.TabIndex = 2;
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
            this.checkedListSubjects.Size = new System.Drawing.Size(622, 120);
            this.checkedListSubjects.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.customLabel4);
            this.groupBox1.Location = new System.Drawing.Point(8, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAddSection);
            this.groupBox2.Controls.Add(this.comboBoxSection);
            this.groupBox2.Controls.Add(this.customLabel6);
            this.groupBox2.Controls.Add(this.comboBoxSchoolYears);
            this.groupBox2.Controls.Add(this.customLabel8);
            this.groupBox2.Controls.Add(this.comboBoxLevel);
            this.groupBox2.Controls.Add(this.customLabel5);
            this.groupBox2.Location = new System.Drawing.Point(16, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 165);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade or Year Level";
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
            this.btnAddSection.Location = new System.Drawing.Point(560, 39);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(43, 26);
            this.btnAddSection.TabIndex = 2;
            this.btnAddSection.Text = "New";
            this.btnAddSection.TextColor = System.Drawing.Color.Green;
            this.btnAddSection.UseVisualStyleBackColor = false;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.BackColor = System.Drawing.Color.White;
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(352, 40);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(202, 25);
            this.comboBoxSection.TabIndex = 1;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel6.FontSize = 9F;
            this.customLabel6.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel6.Location = new System.Drawing.Point(298, 42);
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
            this.comboBoxSchoolYears.Location = new System.Drawing.Point(97, 85);
            this.comboBoxSchoolYears.Name = "comboBoxSchoolYears";
            this.comboBoxSchoolYears.Size = new System.Drawing.Size(175, 25);
            this.comboBoxSchoolYears.TabIndex = 1;
            this.comboBoxSchoolYears.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel8.FontSize = 9F;
            this.customLabel8.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel8.Location = new System.Drawing.Point(16, 88);
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
            this.comboBoxLevel.Size = new System.Drawing.Size(214, 25);
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
            this.textBoxName.Location = new System.Drawing.Point(67, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(580, 25);
            this.textBoxName.TabIndex = 1;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel4.FontSize = 9F;
            this.customLabel4.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel4.Location = new System.Drawing.Point(16, 31);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(44, 15);
            this.customLabel4.TabIndex = 0;
            this.customLabel4.Text = "Name:";
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customLabel7.FontSize = 12F;
            this.customLabel7.FontStyle = System.Drawing.FontStyle.Bold;
            this.customLabel7.Location = new System.Drawing.Point(8, 14);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(99, 20);
            this.customLabel7.TabIndex = 0;
            this.customLabel7.Text = "Elementary";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.FontSize = 10F;
            this.customLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel3.Location = new System.Drawing.Point(9, 45);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(134, 17);
            this.customLabel3.TabIndex = 0;
            this.customLabel3.Text = "ENROLL STUDENT";
            // 
            // AddElementaryEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddElementaryEnrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddElementaryEnrollment";
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

        public Panel panel1;
        public CustomControls.CustomLabel customLabel2;
        public CustomControls.CustomLabel customLabel1;
        public DataGridView dataGridViewStudents;
        public DataGridViewTextBoxColumn id;
        public DataGridViewTextBoxColumn idNo;
        public DataGridViewTextBoxColumn fullname;
        public Panel panel2;
        public GroupBox groupBox3;
        public GroupBox groupBox1;
        public GroupBox groupBox2;
        public ComboBox comboBoxSection;
        public CustomControls.CustomLabel customLabel6;
        public ComboBox comboBoxLevel;
        public CustomControls.CustomLabel customLabel5;
        public TextBox textBoxName;
        public CustomControls.CustomLabel customLabel4;
        public CustomControls.CustomLabel customLabel3;
        public CheckedListBox checkedListSubjects;
        public Button btnSave;
        public Button btnClear;
        public Button btnCancel;
        public CustomControls.CustomLabel customLabel7;
        public TextBox textBoxSearch;
        public ComboBox comboBoxSchoolYears;
        public CustomControls.CustomLabel customLabel8;
        private CustomControls.CustomButton btnAddSection;
    }
}