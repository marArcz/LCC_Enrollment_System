namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class EnrollmentsTab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.customButton3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.customButton2 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.customLabel4 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.comboBoxRows = new System.Windows.Forms.ComboBox();
            this.customButton4 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.customButton5 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.customButton1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 74);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.printer__3_;
            this.pictureBox2.Location = new System.Drawing.Point(857, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(101, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 70);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.student;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_no,
            this.fullname,
            this.sex,
            this.age,
            this.address,
            this.level,
            this.section,
            this.ay});
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(957, 523);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // id_no
            // 
            this.id_no.HeaderText = "ID NO";
            this.id_no.Name = "id_no";
            this.id_no.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "FULLNAME";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "SEX";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "AGE";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "ADDRESS";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // level
            // 
            this.level.HeaderText = "LEVEL";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            // 
            // section
            // 
            this.section.HeaderText = "SECTION";
            this.section.Name = "section";
            this.section.ReadOnly = true;
            // 
            // ay
            // 
            this.ay.HeaderText = "AY";
            this.ay.Name = "ay";
            this.ay.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.customButton4);
            this.panel5.Controls.Add(this.customButton5);
            this.panel5.Controls.Add(this.customButton3);
            this.panel5.Controls.Add(this.customButton2);
            this.panel5.Controls.Add(this.customLabel4);
            this.panel5.Controls.Add(this.customLabel3);
            this.panel5.Controls.Add(this.comboBoxRows);
            this.panel5.Location = new System.Drawing.Point(1, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(956, 42);
            this.panel5.TabIndex = 10;
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
            this.customButton3.Font = new System.Drawing.Font("Heebo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton3.FontSize = 8F;
            this.customButton3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.prev;
            this.customButton3.Location = new System.Drawing.Point(1481, 3);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(56, 37);
            this.customButton3.TabIndex = 12;
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton2.BackColor = System.Drawing.Color.Transparent;
            this.customButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 0;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Heebo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton2.FontSize = 8F;
            this.customButton2.FontStyle = System.Drawing.FontStyle.Regular;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.next__2_;
            this.customButton2.Location = new System.Drawing.Point(1548, 2);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(56, 37);
            this.customButton2.TabIndex = 12;
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
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
            this.comboBoxRows.TabIndex = 0;
            // 
            // customButton4
            // 
            this.customButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton4.BackColor = System.Drawing.Color.Transparent;
            this.customButton4.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton4.BorderRadius = 0;
            this.customButton4.BorderSize = 0;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Heebo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton4.FontSize = 8F;
            this.customButton4.FontStyle = System.Drawing.FontStyle.Regular;
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.prev;
            this.customButton4.Location = new System.Drawing.Point(825, 3);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(56, 37);
            this.customButton4.TabIndex = 13;
            this.customButton4.TextColor = System.Drawing.Color.White;
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton5
            // 
            this.customButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton5.BackColor = System.Drawing.Color.Transparent;
            this.customButton5.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton5.BorderRadius = 0;
            this.customButton5.BorderSize = 0;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.Font = new System.Drawing.Font("Heebo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton5.FontSize = 8F;
            this.customButton5.FontStyle = System.Drawing.FontStyle.Regular;
            this.customButton5.ForeColor = System.Drawing.Color.White;
            this.customButton5.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.next__2_;
            this.customButton5.Location = new System.Drawing.Point(892, 2);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(56, 37);
            this.customButton5.TabIndex = 14;
            this.customButton5.TextColor = System.Drawing.Color.White;
            this.customButton5.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(14, 15);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15, 8, 8, 8);
            this.panel4.Size = new System.Drawing.Size(639, 45);
            this.panel4.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search for student name:";
            this.textBox1.Size = new System.Drawing.Size(614, 22);
            this.textBox1.TabIndex = 0;
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 1;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton1.FontSize = 10F;
            this.customButton1.FontStyle = System.Drawing.FontStyle.Regular;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.search__2_;
            this.customButton1.Location = new System.Drawing.Point(665, 15);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(81, 45);
            this.customButton1.TabIndex = 6;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 74);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Controls.Add(this.customButton1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(100, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 74);
            this.panel3.TabIndex = 7;
            // 
            // EnrollmentsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "EnrollmentsTab";
            this.Size = new System.Drawing.Size(957, 642);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn id_no;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn sex;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn level;
        private DataGridViewTextBoxColumn section;
        private DataGridViewTextBoxColumn ay;
        private Panel panel5;
        private CustomControls.CustomButton customButton3;
        private CustomControls.CustomButton customButton2;
        private CustomControls.CustomLabel customLabel4;
        private CustomControls.CustomLabel customLabel3;
        private ComboBox comboBoxRows;
        private CustomControls.CustomButton customButton4;
        private CustomControls.CustomButton customButton5;
        private Panel panel3;
        private Splitter splitter1;
        private CustomControls.CustomButton customButton1;
        private Panel panel4;
        private TextBox textBox1;
    }
}
