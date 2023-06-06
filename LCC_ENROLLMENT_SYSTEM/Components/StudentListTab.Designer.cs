namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class StudentListTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrev = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.btnNext = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.customButton3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.customButton1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.customLabel4 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.comboBoxRows = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customButton6 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelete = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.btnUpdate = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.customButton2 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.HeaderText = "ADDRESS";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "SEX";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // MiddleInitial
            // 
            this.MiddleInitial.HeaderText = "MIDDLE INITIAL";
            this.MiddleInitial.Name = "MiddleInitial";
            this.MiddleInitial.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "FIRST NAME";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "LAST NAME";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // id_no
            // 
            this.id_no.HeaderText = "IDNO";
            this.id_no.Name = "id_no";
            this.id_no.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Age
            // 
            this.Age.HeaderText = "AGE";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.customButton3);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.customLabel4);
            this.panel1.Controls.Add(this.customLabel3);
            this.panel1.Controls.Add(this.comboBoxRows);
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 42);
            this.panel1.TabIndex = 13;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPrev.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrev.BorderRadius = 0;
            this.btnPrev.BorderSize = 0;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.FontSize = 8F;
            this.btnPrev.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.prev;
            this.btnPrev.Location = new System.Drawing.Point(1443, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(56, 37);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.TextColor = System.Drawing.Color.White;
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 0;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.FontSize = 8F;
            this.btnNext.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.next__2_;
            this.btnNext.Location = new System.Drawing.Point(1510, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 37);
            this.btnNext.TabIndex = 16;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton3.BackColor = System.Drawing.Color.Transparent;
            this.customButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton3.BorderRadius = 0;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton3.FontSize = 8F;
            this.customButton3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.prev;
            this.customButton3.Location = new System.Drawing.Point(2101, 3);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(56, 37);
            this.customButton3.TabIndex = 12;
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton1.FontSize = 8F;
            this.customButton1.FontStyle = System.Drawing.FontStyle.Regular;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.next__2_;
            this.customButton1.Location = new System.Drawing.Point(2168, 2);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(56, 37);
            this.customButton1.TabIndex = 12;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel4.FontSize = 10F;
            this.customLabel4.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel4.Location = new System.Drawing.Point(170, 11);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(45, 21);
            this.customLabel4.TabIndex = 11;
            this.customLabel4.Text = "Rows";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.FontSize = 10F;
            this.customLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel3.Location = new System.Drawing.Point(6, 12);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(48, 21);
            this.customLabel3.TabIndex = 11;
            this.customLabel3.Text = "Show:";
            // 
            // comboBoxRows
            // 
            this.comboBoxRows.BackColor = System.Drawing.Color.White;
            this.comboBoxRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRows.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRows.FormattingEnabled = true;
            this.comboBoxRows.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100"});
            this.comboBoxRows.Location = new System.Drawing.Point(62, 7);
            this.comboBoxRows.Name = "comboBoxRows";
            this.comboBoxRows.Size = new System.Drawing.Size(94, 28);
            this.comboBoxRows.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.graduation;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_no,
            this.Lastname,
            this.Firstname,
            this.MiddleInitial,
            this.Sex,
            this.Age,
            this.Address});
            this.dataGridViewStudents.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewStudents.Location = new System.Drawing.Point(3, 125);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowTemplate.Height = 25;
            this.dataGridViewStudents.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(882, 530);
            this.dataGridViewStudents.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.customButton2);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(888, 76);
            this.panel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.customButton6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(442, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 29);
            this.panel2.TabIndex = 11;
            // 
            // customButton6
            // 
            this.customButton6.BackColor = System.Drawing.Color.White;
            this.customButton6.BackgroundColor = System.Drawing.Color.White;
            this.customButton6.BorderColor = System.Drawing.Color.DodgerBlue;
            this.customButton6.BorderRadius = 0;
            this.customButton6.BorderSize = 1;
            this.customButton6.Dock = System.Windows.Forms.DockStyle.Right;
            this.customButton6.FlatAppearance.BorderSize = 0;
            this.customButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton6.FontSize = 10F;
            this.customButton6.FontStyle = System.Drawing.FontStyle.Regular;
            this.customButton6.ForeColor = System.Drawing.Color.White;
            this.customButton6.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.search__2_;
            this.customButton6.Location = new System.Drawing.Point(1044, 0);
            this.customButton6.Name = "customButton6";
            this.customButton6.Size = new System.Drawing.Size(79, 29);
            this.customButton6.TabIndex = 8;
            this.customButton6.TextColor = System.Drawing.Color.White;
            this.customButton6.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 8, 8, 8);
            this.panel3.Size = new System.Drawing.Size(1123, 29);
            this.panel3.TabIndex = 7;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(24, -22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PlaceholderText = "Search for student name:";
            this.textBoxSearch.Size = new System.Drawing.Size(1227, 22);
            this.textBoxSearch.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(426, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 74);
            this.panel5.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundColor = System.Drawing.Color.White;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.FontSize = 10F;
            this.btnDelete.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(299, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 68);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.TextColor = System.Drawing.Color.Black;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.White;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.FontSize = 10F;
            this.btnUpdate.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(188, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 68);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.TextColor = System.Drawing.Color.Black;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.White;
            this.customButton2.BackgroundColor = System.Drawing.Color.White;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 5;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton2.FontSize = 10F;
            this.customButton2.FontStyle = System.Drawing.FontStyle.Regular;
            this.customButton2.ForeColor = System.Drawing.Color.Black;
            this.customButton2.Location = new System.Drawing.Point(77, 5);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(105, 68);
            this.customButton2.TabIndex = 2;
            this.customButton2.Text = "Add New Student";
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Location = new System.Drawing.Point(68, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 76);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // StudentListTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.panel4);
            this.Name = "StudentListTab";
            this.Size = new System.Drawing.Size(888, 657);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewTextBoxColumn MiddleInitial;
        private DataGridViewTextBoxColumn Firstname;
        private DataGridViewTextBoxColumn Lastname;
        private DataGridViewTextBoxColumn id_no;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Age;
        private Panel panel1;
        private CustomControls.CustomButton btnPrev;
        private CustomControls.CustomButton btnNext;
        private CustomControls.CustomButton customButton3;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomLabel customLabel4;
        private CustomControls.CustomLabel customLabel3;
        private ComboBox comboBoxRows;
        private PictureBox pictureBox2;
        private DataGridView dataGridViewStudents;
        private Panel panel4;
        private Panel panel2;
        private CustomControls.CustomButton customButton6;
        private Panel panel3;
        private TextBox textBoxSearch;
        private Panel panel5;
        private CustomControls.CustomButton btnDelete;
        private CustomControls.CustomButton btnUpdate;
        private CustomControls.CustomButton customButton2;
        private Splitter splitter1;
    }
}
