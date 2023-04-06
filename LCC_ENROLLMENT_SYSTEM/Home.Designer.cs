namespace LCC_ENROLLMENT_SYSTEM
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.sidemenuPanel = new System.Windows.Forms.Panel();
            this.sidemenuButton11 = new LCC_ENROLLMENT_SYSTEM.CustomControls.SidemenuButton();
            this.sidemenuButton10 = new LCC_ENROLLMENT_SYSTEM.CustomControls.SidemenuButton();
            this.sidemenuButton9 = new LCC_ENROLLMENT_SYSTEM.CustomControls.SidemenuButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customLabel1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.studentsTab = new System.Windows.Forms.TabPage();
            this.studentTabComponent = new LCC_ENROLLMENT_SYSTEM.Components.StudentsTabComponent();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.customLabel2 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.dashboardCard3 = new LCC_ENROLLMENT_SYSTEM.Components.DashboardCard();
            this.dashboardCard2 = new LCC_ENROLLMENT_SYSTEM.Components.DashboardCard();
            this.dashboardCard1 = new LCC_ENROLLMENT_SYSTEM.Components.DashboardCard();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.enrollmentTab = new System.Windows.Forms.TabPage();
            this.enrollmentsTab1 = new LCC_ENROLLMENT_SYSTEM.Components.EnrollmentsTab();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebarPanel.SuspendLayout();
            this.sidemenuPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.studentsTab.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.enrollmentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.LCC_64;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidebarPanel.Controls.Add(this.sidemenuPanel);
            this.sidebarPanel.Controls.Add(this.panel3);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(208, 650);
            this.sidebarPanel.TabIndex = 1;
            // 
            // sidemenuPanel
            // 
            this.sidemenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sidemenuPanel.Controls.Add(this.sidemenuButton11);
            this.sidemenuPanel.Controls.Add(this.sidemenuButton10);
            this.sidemenuPanel.Controls.Add(this.sidemenuButton9);
            this.sidemenuPanel.Location = new System.Drawing.Point(0, 101);
            this.sidemenuPanel.Name = "sidemenuPanel";
            this.sidemenuPanel.Size = new System.Drawing.Size(209, 549);
            this.sidemenuPanel.TabIndex = 3;
            // 
            // sidemenuButton11
            // 
            this.sidemenuButton11.Active = false;
            this.sidemenuButton11.ActiveBgColor = System.Drawing.Color.DimGray;
            this.sidemenuButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidemenuButton11.BorderColor = System.Drawing.Color.Green;
            this.sidemenuButton11.BorderSize = 5;
            this.sidemenuButton11.DefaultBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidemenuButton11.FlatAppearance.BorderSize = 0;
            this.sidemenuButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidemenuButton11.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sidemenuButton11.FontSize = 10F;
            this.sidemenuButton11.FontStyle = System.Drawing.FontStyle.Regular;
            this.sidemenuButton11.ForeColor = System.Drawing.Color.White;
            this.sidemenuButton11.Icon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.student;
            this.sidemenuButton11.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.student;
            this.sidemenuButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidemenuButton11.IndicatorPos = LCC_ENROLLMENT_SYSTEM.CustomControls.SidemenuButton.borderPosition.start;
            this.sidemenuButton11.Location = new System.Drawing.Point(0, 95);
            this.sidemenuButton11.Name = "sidemenuButton11";
            this.sidemenuButton11.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.sidemenuButton11.Size = new System.Drawing.Size(208, 40);
            this.sidemenuButton11.Tab = "enrollmentTab";
            this.sidemenuButton11.TabIndex = 0;
            this.sidemenuButton11.Text = "Enrollment";
            this.sidemenuButton11.UseVisualStyleBackColor = false;
            // 
            // sidemenuButton10
            // 
            this.sidemenuButton10.Active = false;
            this.sidemenuButton10.ActiveBgColor = System.Drawing.Color.DimGray;
            this.sidemenuButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidemenuButton10.BorderColor = System.Drawing.Color.Green;
            this.sidemenuButton10.BorderSize = 5;
            this.sidemenuButton10.DefaultBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidemenuButton10.FlatAppearance.BorderSize = 0;
            this.sidemenuButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidemenuButton10.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sidemenuButton10.FontSize = 10F;
            this.sidemenuButton10.FontStyle = System.Drawing.FontStyle.Regular;
            this.sidemenuButton10.ForeColor = System.Drawing.Color.White;
            this.sidemenuButton10.Icon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.graduation;
            this.sidemenuButton10.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.graduation;
            this.sidemenuButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidemenuButton10.IndicatorPos = LCC_ENROLLMENT_SYSTEM.CustomControls.SidemenuButton.borderPosition.start;
            this.sidemenuButton10.Location = new System.Drawing.Point(0, 49);
            this.sidemenuButton10.Name = "sidemenuButton10";
            this.sidemenuButton10.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.sidemenuButton10.Size = new System.Drawing.Size(209, 40);
            this.sidemenuButton10.Tab = "studentsTab";
            this.sidemenuButton10.TabIndex = 0;
            this.sidemenuButton10.Text = "Students";
            this.sidemenuButton10.UseVisualStyleBackColor = false;
            // 
            // sidemenuButton9
            // 
            this.sidemenuButton9.Active = true;
            this.sidemenuButton9.ActiveBgColor = System.Drawing.Color.DimGray;
            this.sidemenuButton9.BackColor = System.Drawing.Color.DimGray;
            this.sidemenuButton9.BorderColor = System.Drawing.Color.Green;
            this.sidemenuButton9.BorderSize = 5;
            this.sidemenuButton9.DefaultBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidemenuButton9.FlatAppearance.BorderSize = 0;
            this.sidemenuButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidemenuButton9.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sidemenuButton9.FontSize = 10F;
            this.sidemenuButton9.FontStyle = System.Drawing.FontStyle.Regular;
            this.sidemenuButton9.ForeColor = System.Drawing.Color.White;
            this.sidemenuButton9.Icon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.dashboard__4_;
            this.sidemenuButton9.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.dashboard__4_;
            this.sidemenuButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidemenuButton9.IndicatorPos = LCC_ENROLLMENT_SYSTEM.CustomControls.SidemenuButton.borderPosition.start;
            this.sidemenuButton9.Location = new System.Drawing.Point(0, 3);
            this.sidemenuButton9.Name = "sidemenuButton9";
            this.sidemenuButton9.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.sidemenuButton9.Size = new System.Drawing.Size(209, 40);
            this.sidemenuButton9.Tab = "dashboardTab";
            this.sidemenuButton9.TabIndex = 0;
            this.sidemenuButton9.Text = "Dashboard";
            this.sidemenuButton9.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.customLabel1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 95);
            this.panel3.TabIndex = 2;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Heebo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customLabel1.FontSize = 14F;
            this.customLabel1.FontStyle = System.Drawing.FontStyle.Bold;
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(79, 22);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(18, 28);
            this.customLabel1.TabIndex = 3;
            this.customLabel1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(80, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enrollment System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // studentsTab
            // 
            this.studentsTab.BackColor = System.Drawing.Color.White;
            this.studentsTab.Controls.Add(this.studentTabComponent);
            this.studentsTab.Location = new System.Drawing.Point(10, 4);
            this.studentsTab.Name = "studentsTab";
            this.studentsTab.Size = new System.Drawing.Size(858, 620);
            this.studentsTab.TabIndex = 1;
            this.studentsTab.Text = "Students";
            // 
            // studentTabComponent
            // 
            this.studentTabComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentTabComponent.Location = new System.Drawing.Point(0, 0);
            this.studentTabComponent.Name = "studentTabComponent";
            this.studentTabComponent.Size = new System.Drawing.Size(858, 620);
            this.studentTabComponent.TabIndex = 0;
            // 
            // dashboardTab
            // 
            this.dashboardTab.Controls.Add(this.customLabel2);
            this.dashboardTab.Controls.Add(this.dashboardCard3);
            this.dashboardTab.Controls.Add(this.dashboardCard2);
            this.dashboardTab.Controls.Add(this.dashboardCard1);
            this.dashboardTab.Location = new System.Drawing.Point(10, 4);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(858, 642);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
            this.dashboardTab.UseVisualStyleBackColor = true;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel2.FontSize = 10F;
            this.customLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel2.Location = new System.Drawing.Point(19, 17);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(92, 21);
            this.customLabel2.TabIndex = 3;
            this.customLabel2.Text = "DASHBOARD";
            // 
            // dashboardCard3
            // 
            this.dashboardCard3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardCard3.CardBg = System.Drawing.Color.RosyBrown;
            this.dashboardCard3.CardIcon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.profile_user;
            this.dashboardCard3.CardTitle = "Students";
            this.dashboardCard3.CardValue = "0";
            this.dashboardCard3.Location = new System.Drawing.Point(16, 327);
            this.dashboardCard3.Name = "dashboardCard3";
            this.dashboardCard3.Size = new System.Drawing.Size(247, 218);
            this.dashboardCard3.TabIndex = 2;
            // 
            // dashboardCard2
            // 
            this.dashboardCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardCard2.CardBg = System.Drawing.Color.RosyBrown;
            this.dashboardCard2.CardIcon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.profile_user;
            this.dashboardCard2.CardTitle = "Students";
            this.dashboardCard2.CardValue = "0";
            this.dashboardCard2.Location = new System.Drawing.Point(440, 53);
            this.dashboardCard2.Name = "dashboardCard2";
            this.dashboardCard2.Size = new System.Drawing.Size(247, 218);
            this.dashboardCard2.TabIndex = 2;
            // 
            // dashboardCard1
            // 
            this.dashboardCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardCard1.CardBg = System.Drawing.Color.RosyBrown;
            this.dashboardCard1.CardIcon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.profile_user;
            this.dashboardCard1.CardTitle = "Students";
            this.dashboardCard1.CardValue = "0";
            this.dashboardCard1.Location = new System.Drawing.Point(16, 53);
            this.dashboardCard1.Name = "dashboardCard1";
            this.dashboardCard1.Size = new System.Drawing.Size(247, 218);
            this.dashboardCard1.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.dashboardTab);
            this.tabControl.Controls.Add(this.studentsTab);
            this.tabControl.Controls.Add(this.enrollmentTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(208, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(872, 650);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // enrollmentTab
            // 
            this.enrollmentTab.Controls.Add(this.enrollmentsTab1);
            this.enrollmentTab.Location = new System.Drawing.Point(10, 4);
            this.enrollmentTab.Name = "enrollmentTab";
            this.enrollmentTab.Size = new System.Drawing.Size(858, 620);
            this.enrollmentTab.TabIndex = 2;
            this.enrollmentTab.Text = "Enrollment";
            this.enrollmentTab.UseVisualStyleBackColor = true;
            // 
            // enrollmentsTab1
            // 
            this.enrollmentsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enrollmentsTab1.Location = new System.Drawing.Point(0, 0);
            this.enrollmentsTab1.Name = "enrollmentsTab1";
            this.enrollmentsTab1.Size = new System.Drawing.Size(858, 620);
            this.enrollmentsTab1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 650);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.sidebarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " LCC Enrollment System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebarPanel.ResumeLayout(false);
            this.sidemenuPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.studentsTab.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.dashboardTab.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.enrollmentTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private Panel sidebarPanel;
        private Panel panel3;
        private Label label2;
    
        private TabPage studentsTab;
        private TabPage dashboardTab;
        private TabControl tabControl;
        private TabPage enrollmentTab;
        private Components.DashboardCard dashboardCard1;
        private Components.DashboardCard dashboardCard3;
        private Components.DashboardCard dashboardCard2;
        private CustomControls.CustomLabel customLabel1;
        private CustomControls.CustomLabel customLabel2;
        private Panel sidemenuPanel;
        private CustomControls.SidemenuButton studentsTabLink;
        private CustomControls.SidemenuButton dashboardTabLInk;
        private CustomControls.SidemenuButton sidemenuButton2;
        private CustomControls.SidemenuButton sidemenuButton3;
        private CustomControls.SidemenuButton sidemenuButton1;
        private CustomControls.SidemenuButton sidemenuButton5;
        private CustomControls.SidemenuButton sidemenuButton4;
        private CustomControls.SidemenuButton sidemenuButton8;
        private CustomControls.SidemenuButton sidemenuButton7;
        private CustomControls.SidemenuButton sidemenuButton6;
        private CustomControls.SidemenuButton sidemenuButton11;
        private CustomControls.SidemenuButton sidemenuButton10;
        private CustomControls.SidemenuButton sidemenuButton9;
        private Components.EnrollmentsTab enrollmentsTab1;
        private Components.StudentsTabComponent studentTabComponent;
    }
}