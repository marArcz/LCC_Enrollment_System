namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class AddSeniorHighEnrollment
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
            this.customLabel11 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel10 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel9 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.comboBoxTracks = new System.Windows.Forms.ComboBox();
            this.comboBoxStrands = new System.Windows.Forms.ComboBox();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
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
            this.customLabel12 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.comboBoxAdvisers = new System.Windows.Forms.ComboBox();
            this.btnNewAdvisers = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
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
            this.panel1.TabIndex = 1;
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
            this.panel2.TabIndex = 2;
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
            this.btnClear.Location = new System.Drawing.Point(504, 608);
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
            this.groupBox3.Location = new System.Drawing.Point(11, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 171);
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
            this.checkedListSubjects.Location = new System.Drawing.Point(16, 31);
            this.checkedListSubjects.MultiColumn = true;
            this.checkedListSubjects.Name = "checkedListSubjects";
            this.checkedListSubjects.Size = new System.Drawing.Size(629, 120);
            this.checkedListSubjects.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customLabel11);
            this.groupBox1.Controls.Add(this.customLabel10);
            this.groupBox1.Controls.Add(this.customLabel9);
            this.groupBox1.Controls.Add(this.comboBoxTracks);
            this.groupBox1.Controls.Add(this.comboBoxStrands);
            this.groupBox1.Controls.Add(this.comboBoxCourses);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.customLabel4);
            this.groupBox1.Location = new System.Drawing.Point(11, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 316);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // customLabel11
            // 
            this.customLabel11.AutoSize = true;
            this.customLabel11.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel11.FontSize = 9F;
            this.customLabel11.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel11.Location = new System.Drawing.Point(459, 233);
            this.customLabel11.Name = "customLabel11";
            this.customLabel11.Size = new System.Drawing.Size(110, 18);
            this.customLabel11.TabIndex = 4;
            this.customLabel11.Text = "Specialized Course";
            // 
            // customLabel10
            // 
            this.customLabel10.AutoSize = true;
            this.customLabel10.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel10.FontSize = 9F;
            this.customLabel10.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel10.Location = new System.Drawing.Point(239, 233);
            this.customLabel10.Name = "customLabel10";
            this.customLabel10.Size = new System.Drawing.Size(47, 18);
            this.customLabel10.TabIndex = 4;
            this.customLabel10.Text = "Strand:";
            // 
            // customLabel9
            // 
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel9.FontSize = 9F;
            this.customLabel9.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel9.Location = new System.Drawing.Point(17, 233);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(41, 18);
            this.customLabel9.TabIndex = 4;
            this.customLabel9.Text = "Track:";
            // 
            // comboBoxTracks
            // 
            this.comboBoxTracks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTracks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTracks.FormattingEnabled = true;
            this.comboBoxTracks.Location = new System.Drawing.Point(17, 257);
            this.comboBoxTracks.Name = "comboBoxTracks";
            this.comboBoxTracks.Size = new System.Drawing.Size(198, 25);
            this.comboBoxTracks.TabIndex = 1;
            this.comboBoxTracks.SelectedIndexChanged += new System.EventHandler(this.comboBoxTracks_SelectedIndexChanged);
            // 
            // comboBoxStrands
            // 
            this.comboBoxStrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStrands.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStrands.FormattingEnabled = true;
            this.comboBoxStrands.Location = new System.Drawing.Point(241, 257);
            this.comboBoxStrands.Name = "comboBoxStrands";
            this.comboBoxStrands.Size = new System.Drawing.Size(195, 25);
            this.comboBoxStrands.TabIndex = 1;
            this.comboBoxStrands.SelectedIndexChanged += new System.EventHandler(this.comboBoxStrands_SelectedIndexChanged);
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourses.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(459, 257);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(186, 25);
            this.comboBoxCourses.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnNewAdvisers);
            this.groupBox2.Controls.Add(this.btnAddSection);
            this.groupBox2.Controls.Add(this.comboBoxAdvisers);
            this.groupBox2.Controls.Add(this.customLabel12);
            this.groupBox2.Controls.Add(this.comboBoxSection);
            this.groupBox2.Controls.Add(this.customLabel6);
            this.groupBox2.Controls.Add(this.comboBoxSchoolYears);
            this.groupBox2.Controls.Add(this.customLabel8);
            this.groupBox2.Controls.Add(this.comboBoxLevel);
            this.groupBox2.Controls.Add(this.customLabel5);
            this.groupBox2.Location = new System.Drawing.Point(17, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 135);
            this.groupBox2.TabIndex = 3;
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
            this.textBoxName.Size = new System.Drawing.Size(583, 25);
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
            this.customLabel7.Text = "Senior Highschool";
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
            // customLabel12
            // 
            this.customLabel12.AutoSize = true;
            this.customLabel12.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel12.FontSize = 9F;
            this.customLabel12.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel12.Location = new System.Drawing.Point(279, 90);
            this.customLabel12.Name = "customLabel12";
            this.customLabel12.Size = new System.Drawing.Size(48, 18);
            this.customLabel12.TabIndex = 0;
            this.customLabel12.Text = "Adviser";
            // 
            // comboBoxAdvisers
            // 
            this.comboBoxAdvisers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdvisers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAdvisers.FormattingEnabled = true;
            this.comboBoxAdvisers.Location = new System.Drawing.Point(333, 88);
            this.comboBoxAdvisers.Name = "comboBoxAdvisers";
            this.comboBoxAdvisers.Size = new System.Drawing.Size(227, 25);
            this.comboBoxAdvisers.TabIndex = 1;
            // 
            // btnNewAdvisers
            // 
            this.btnNewAdvisers.BackColor = System.Drawing.Color.White;
            this.btnNewAdvisers.BackgroundColor = System.Drawing.Color.White;
            this.btnNewAdvisers.BorderColor = System.Drawing.Color.Green;
            this.btnNewAdvisers.BorderRadius = 3;
            this.btnNewAdvisers.BorderSize = 1;
            this.btnNewAdvisers.FlatAppearance.BorderSize = 0;
            this.btnNewAdvisers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAdvisers.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewAdvisers.FontSize = 9F;
            this.btnNewAdvisers.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnNewAdvisers.ForeColor = System.Drawing.Color.Green;
            this.btnNewAdvisers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewAdvisers.Location = new System.Drawing.Point(569, 87);
            this.btnNewAdvisers.Name = "btnNewAdvisers";
            this.btnNewAdvisers.Size = new System.Drawing.Size(43, 26);
            this.btnNewAdvisers.TabIndex = 3;
            this.btnNewAdvisers.Text = "New";
            this.btnNewAdvisers.TextColor = System.Drawing.Color.Green;
            this.btnNewAdvisers.UseVisualStyleBackColor = false;
            this.btnNewAdvisers.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // AddSeniorHighEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddSeniorHighEnrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSeniorHighEnrollment";
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
        private DataGridView dataGridViewStudents;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn id_no;
        private DataGridViewTextBoxColumn Fullname;
        private TextBox textBoxSearch;
        public CustomControls.CustomLabel customLabel2;
        public CustomControls.CustomLabel customLabel1;
        private Panel panel2;
        public Button btnSave;
        public Button btnClear;
        public Button btnCancel;
        public GroupBox groupBox3;
        public CheckedListBox checkedListSubjects;
        private GroupBox groupBox1;
        public GroupBox groupBox2;
        private CustomControls.CustomButton btnAddSection;
        public ComboBox comboBoxSection;
        public CustomControls.CustomLabel customLabel6;
        public ComboBox comboBoxSchoolYears;
        public CustomControls.CustomLabel customLabel8;
        public ComboBox comboBoxLevel;
        public CustomControls.CustomLabel customLabel5;
        public TextBox textBoxName;
        private CustomControls.CustomLabel customLabel4;
        public CustomControls.CustomLabel customLabel7;
        public CustomControls.CustomLabel customLabel3;
        private CustomControls.CustomLabel customLabel11;
        private CustomControls.CustomLabel customLabel10;
        private CustomControls.CustomLabel customLabel9;
        public ComboBox comboBoxCourses;
        public ComboBox comboBoxTracks;
        public ComboBox comboBoxStrands;
        private CustomControls.CustomButton btnNewAdvisers;
        public ComboBox comboBoxAdvisers;
        public CustomControls.CustomLabel customLabel12;
    }
}