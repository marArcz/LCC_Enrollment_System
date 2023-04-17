namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class JuniorHighEnrollmentTabComponent
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Track = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Strand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.Font = new System.Drawing.Font("Heebo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(769, 3);
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.Font = new System.Drawing.Font("Heebo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(846, 3);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // customLabel4
            // 
            this.customLabel4.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel4.Size = new System.Drawing.Size(45, 21);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(940, 42);
            // 
            // customLabel3
            // 
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.Size = new System.Drawing.Size(48, 21);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Size = new System.Drawing.Size(332, 22);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(723, 13);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(384, 45);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(874, 74);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(941, 74);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Heebo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(694, 2);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_no,
            this.Firstname,
            this.Lastname,
            this.Level,
            this.Section,
            this.Track,
            this.Strand,
            this.a_year});
            this.dataGridView.Location = new System.Drawing.Point(0, 115);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(941, 487);
            this.dataGridView.TabIndex = 14;
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
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "FIRSTNAME";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "LASTNAME";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.HeaderText = "LEVEL";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.HeaderText = "SECTION";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // Track
            // 
            this.Track.HeaderText = "TRACK";
            this.Track.Name = "Track";
            this.Track.ReadOnly = true;
            // 
            // Strand
            // 
            this.Strand.HeaderText = "STRAND";
            this.Strand.Name = "Strand";
            this.Strand.ReadOnly = true;
            // 
            // a_year
            // 
            this.a_year.HeaderText = "AY";
            this.a_year.Name = "a_year";
            this.a_year.ReadOnly = true;
            // 
            // JuniorHighEnrollmentTabComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Name = "JuniorHighEnrollmentTabComponent";
            this.Size = new System.Drawing.Size(941, 602);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn id_no;
        private DataGridViewTextBoxColumn Firstname;
        private DataGridViewTextBoxColumn Lastname;
        private DataGridViewTextBoxColumn Level;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn Track;
        private DataGridViewTextBoxColumn Strand;
        private DataGridViewTextBoxColumn a_year;
    }
}