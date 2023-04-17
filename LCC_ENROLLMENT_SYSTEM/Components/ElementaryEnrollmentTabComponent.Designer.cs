namespace LCC_ENROLLMENT_SYSTEM.Components
{
    partial class ElementaryEnrollmentTabComponent
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
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customLabel1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
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
            this.btnPrev.Location = new System.Drawing.Point(777, 3);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.Font = new System.Drawing.Font("Heebo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(854, 3);
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customLabel4.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel4.Location = new System.Drawing.Point(530, 10);
            this.customLabel4.Size = new System.Drawing.Size(45, 21);
            // 
            // comboBoxRows
            // 
            this.comboBoxRows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxRows.Location = new System.Drawing.Point(422, 6);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.customLabel1);
            this.panel5.Size = new System.Drawing.Size(948, 42);
            this.panel5.Controls.SetChildIndex(this.comboBoxRows, 0);
            this.panel5.Controls.SetChildIndex(this.customLabel3, 0);
            this.panel5.Controls.SetChildIndex(this.customLabel4, 0);
            this.panel5.Controls.SetChildIndex(this.btnNext, 0);
            this.panel5.Controls.SetChildIndex(this.btnPrev, 0);
            this.panel5.Controls.SetChildIndex(this.btnRefresh, 0);
            this.panel5.Controls.SetChildIndex(this.customLabel1, 0);
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.Location = new System.Drawing.Point(366, 11);
            this.customLabel3.Size = new System.Drawing.Size(48, 21);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Size = new System.Drawing.Size(329, 22);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(763, 13);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(392, 45);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(882, 74);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(949, 74);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Heebo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(702, 2);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Student,
            this.Section,
            this.Level});
            this.dataGridView.Location = new System.Drawing.Point(0, 115);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(949, 446);
            this.dataGridView.TabIndex = 14;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Student
            // 
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customLabel1.FontSize = 12F;
            this.customLabel1.FontStyle = System.Drawing.FontStyle.Bold;
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customLabel1.Location = new System.Drawing.Point(3, 10);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(190, 24);
            this.customLabel1.TabIndex = 13;
            this.customLabel1.Text = "Elementary Enrollment";
            // 
            // ElementaryEnrollmentTabComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Name = "ElementaryEnrollmentTabComponent";
            this.Size = new System.Drawing.Size(949, 561);
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
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn Level;
        private CustomControls.CustomLabel customLabel1;
    }
}