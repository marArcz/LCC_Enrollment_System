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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuButton1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton();
            this.menuButton2 = new LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton();
            this.menuButton3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton();
            this.EnrollmentMenuLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.enrollmentMenuToggler = new LCC_ENROLLMENT_SYSTEM.CustomControls.CollapsibleToggler();
            this.menuButton4 = new LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton();
            this.menuButton5 = new LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton();
            this.menuButton6 = new LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customLabel3 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.customLabel1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.studentsTab = new System.Windows.Forms.TabPage();
            this.studentsTabComponent1 = new LCC_ENROLLMENT_SYSTEM.Components.StudentsTabComponent();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.dashboardCard3 = new LCC_ENROLLMENT_SYSTEM.Components.DashboardCard();
            this.dashboardCard1 = new LCC_ENROLLMENT_SYSTEM.Components.DashboardCard();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.enrollmentTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.enrollmentsTab1 = new LCC_ENROLLMENT_SYSTEM.Components.EnrollmentsTab();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.enrollmentsTab2 = new LCC_ENROLLMENT_SYSTEM.Components.EnrollmentsTab();
            this.subjectsTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.manageUserTab = new System.Windows.Forms.TabPage();
            this.reportsTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebarPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.EnrollmentMenuLayout.SuspendLayout();
            this.panel3.SuspendLayout();
            this.studentsTab.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.enrollmentTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.sidebarPanel.Controls.Add(this.flowLayoutPanel1);
            this.sidebarPanel.Controls.Add(this.panel3);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(210, 771);
            this.sidebarPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menuButton1);
            this.flowLayoutPanel1.Controls.Add(this.menuButton2);
            this.flowLayoutPanel1.Controls.Add(this.menuButton3);
            this.flowLayoutPanel1.Controls.Add(this.EnrollmentMenuLayout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 448);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // menuButton1
            // 
            this.menuButton1.Active = true;
            this.menuButton1.ActiveBgColor = System.Drawing.Color.Gray;
            this.menuButton1.BackColor = System.Drawing.Color.Gray;
            this.menuButton1.BorderColor = System.Drawing.Color.Green;
            this.menuButton1.BorderSize = 5;
            this.menuButton1.BtnText = "Dashboard";
            this.menuButton1.DefaultBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuButton1.FontSize = 10F;
            this.menuButton1.FontStyle = System.Drawing.FontStyle.Regular;
            this.menuButton1.Icon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.dashboard__4_;
            this.menuButton1.IndicatorPos = LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton.borderPosition.start;
            this.menuButton1.Location = new System.Drawing.Point(3, 3);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Padding = new System.Windows.Forms.Padding(7);
            this.menuButton1.Size = new System.Drawing.Size(204, 49);
            this.menuButton1.Tab1 = "Tab";
            this.menuButton1.TabIndex = 0;
            // 
            // menuButton2
            // 
            this.menuButton2.Active = false;
            this.menuButton2.ActiveBgColor = System.Drawing.Color.Gray;
            this.menuButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuButton2.BorderColor = System.Drawing.Color.Green;
            this.menuButton2.BorderSize = 5;
            this.menuButton2.BtnText = "Students";
            this.menuButton2.DefaultBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuButton2.FontSize = 10F;
            this.menuButton2.FontStyle = System.Drawing.FontStyle.Regular;
            this.menuButton2.Icon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.graduation;
            this.menuButton2.IndicatorPos = LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton.borderPosition.start;
            this.menuButton2.Location = new System.Drawing.Point(3, 58);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Padding = new System.Windows.Forms.Padding(7);
            this.menuButton2.Size = new System.Drawing.Size(204, 49);
            this.menuButton2.Tab1 = "studentsTab";
            this.menuButton2.TabIndex = 1;
            // 
            // menuButton3
            // 
            this.menuButton3.Active = false;
            this.menuButton3.ActiveBgColor = System.Drawing.Color.Gray;
            this.menuButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuButton3.BorderColor = System.Drawing.Color.Green;
            this.menuButton3.BorderSize = 5;
            this.menuButton3.BtnText = "Subjects";
            this.menuButton3.DefaultBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuButton3.FontSize = 10F;
            this.menuButton3.FontStyle = System.Drawing.FontStyle.Regular;
            this.menuButton3.Icon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.book__1_;
            this.menuButton3.IndicatorPos = LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton.borderPosition.start;
            this.menuButton3.Location = new System.Drawing.Point(3, 113);
            this.menuButton3.Name = "menuButton3";
            this.menuButton3.Padding = new System.Windows.Forms.Padding(7);
            this.menuButton3.Size = new System.Drawing.Size(204, 49);
            this.menuButton3.Tab1 = "Tab";
            this.menuButton3.TabIndex = 2;
            // 
            // EnrollmentMenuLayout
            // 
            this.EnrollmentMenuLayout.Controls.Add(this.enrollmentMenuToggler);
            this.EnrollmentMenuLayout.Controls.Add(this.menuButton4);
            this.EnrollmentMenuLayout.Controls.Add(this.menuButton5);
            this.EnrollmentMenuLayout.Controls.Add(this.menuButton6);
            this.EnrollmentMenuLayout.Location = new System.Drawing.Point(3, 168);
            this.EnrollmentMenuLayout.Name = "EnrollmentMenuLayout";
            this.EnrollmentMenuLayout.Size = new System.Drawing.Size(207, 57);
            this.EnrollmentMenuLayout.TabIndex = 3;
            // 
            // enrollmentMenuToggler
            // 
            this.enrollmentMenuToggler.Active = false;
            this.enrollmentMenuToggler.ActiveBgColor = System.Drawing.Color.Gray;
            this.enrollmentMenuToggler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.enrollmentMenuToggler.BorderColor = System.Drawing.Color.Blue;
            this.enrollmentMenuToggler.BorderSize = 5;
            this.enrollmentMenuToggler.BtnText = "Enrollment";
            this.enrollmentMenuToggler.DefaultBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.enrollmentMenuToggler.FontSize = 10F;
            this.enrollmentMenuToggler.FontStyle = System.Drawing.FontStyle.Regular;
            this.enrollmentMenuToggler.Icon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.student;
            this.enrollmentMenuToggler.IndicatorPos = LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton.borderPosition.start;
            this.enrollmentMenuToggler.Location = new System.Drawing.Point(3, 3);
            this.enrollmentMenuToggler.Name = "enrollmentMenuToggler";
            this.enrollmentMenuToggler.OnCollapseListener = null;
            this.enrollmentMenuToggler.OnToggle = null;
            this.enrollmentMenuToggler.Padding = new System.Windows.Forms.Padding(7);
            this.enrollmentMenuToggler.Size = new System.Drawing.Size(201, 49);
            this.enrollmentMenuToggler.Tab1 = "Tab";
            this.enrollmentMenuToggler.TabIndex = 0;
            this.enrollmentMenuToggler.Toggled = false;
            // 
            // menuButton4
            // 
            this.menuButton4.Active = false;
            this.menuButton4.ActiveBgColor = System.Drawing.Color.Gray;
            this.menuButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuButton4.BorderColor = System.Drawing.Color.Blue;
            this.menuButton4.BorderSize = 5;
            this.menuButton4.BtnText = "Elementary";
            this.menuButton4.DefaultBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuButton4.FontSize = 9F;
            this.menuButton4.FontStyle = System.Drawing.FontStyle.Regular;
            this.menuButton4.Icon = null;
            this.menuButton4.IndicatorPos = LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton.borderPosition.start;
            this.menuButton4.Location = new System.Drawing.Point(3, 58);
            this.menuButton4.Name = "menuButton4";
            this.menuButton4.Padding = new System.Windows.Forms.Padding(7);
            this.menuButton4.Size = new System.Drawing.Size(201, 49);
            this.menuButton4.Tab1 = "Tab";
            this.menuButton4.TabIndex = 1;
            // 
            // menuButton5
            // 
            this.menuButton5.Active = false;
            this.menuButton5.ActiveBgColor = System.Drawing.Color.Gray;
            this.menuButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuButton5.BorderColor = System.Drawing.Color.Blue;
            this.menuButton5.BorderSize = 5;
            this.menuButton5.BtnText = "Junior Highschool";
            this.menuButton5.DefaultBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuButton5.FontSize = 9F;
            this.menuButton5.FontStyle = System.Drawing.FontStyle.Regular;
            this.menuButton5.Icon = null;
            this.menuButton5.IndicatorPos = LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton.borderPosition.start;
            this.menuButton5.Location = new System.Drawing.Point(3, 113);
            this.menuButton5.Name = "menuButton5";
            this.menuButton5.Padding = new System.Windows.Forms.Padding(7);
            this.menuButton5.Size = new System.Drawing.Size(201, 49);
            this.menuButton5.Tab1 = "Tab";
            this.menuButton5.TabIndex = 2;
            // 
            // menuButton6
            // 
            this.menuButton6.Active = false;
            this.menuButton6.ActiveBgColor = System.Drawing.Color.Gray;
            this.menuButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuButton6.BorderColor = System.Drawing.Color.Blue;
            this.menuButton6.BorderSize = 5;
            this.menuButton6.BtnText = "Senior Highschool";
            this.menuButton6.DefaultBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuButton6.FontSize = 9F;
            this.menuButton6.FontStyle = System.Drawing.FontStyle.Regular;
            this.menuButton6.Icon = null;
            this.menuButton6.IndicatorPos = LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton.borderPosition.start;
            this.menuButton6.Location = new System.Drawing.Point(3, 168);
            this.menuButton6.Name = "menuButton6";
            this.menuButton6.Padding = new System.Windows.Forms.Padding(7);
            this.menuButton6.Size = new System.Drawing.Size(201, 49);
            this.menuButton6.Tab1 = "Tab";
            this.menuButton6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.customLabel3);
            this.panel3.Controls.Add(this.customLabel1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 95);
            this.panel3.TabIndex = 2;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customLabel3.FontSize = 12F;
            this.customLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.customLabel3.ForeColor = System.Drawing.Color.White;
            this.customLabel3.Location = new System.Drawing.Point(78, 25);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(39, 24);
            this.customLabel3.TabIndex = 4;
            this.customLabel3.Text = "LCC";
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
            this.studentsTab.Controls.Add(this.studentsTabComponent1);
            this.studentsTab.Location = new System.Drawing.Point(22, 4);
            this.studentsTab.Name = "studentsTab";
            this.studentsTab.Size = new System.Drawing.Size(844, 763);
            this.studentsTab.TabIndex = 1;
            this.studentsTab.Text = "Students";
            // 
            // studentsTabComponent1
            // 
            this.studentsTabComponent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsTabComponent1.Location = new System.Drawing.Point(0, 0);
            this.studentsTabComponent1.Name = "studentsTabComponent1";
            this.studentsTabComponent1.Size = new System.Drawing.Size(844, 763);
            this.studentsTabComponent1.TabIndex = 0;
            // 
            // dashboardTab
            // 
            this.dashboardTab.AutoScroll = true;
            this.dashboardTab.Controls.Add(this.dashboardCard3);
            this.dashboardTab.Controls.Add(this.dashboardCard1);
            this.dashboardTab.Location = new System.Drawing.Point(22, 4);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(844, 763);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
            this.dashboardTab.UseVisualStyleBackColor = true;
            this.dashboardTab.Click += new System.EventHandler(this.dashboardTab_Click);
            // 
            // dashboardCard3
            // 
            this.dashboardCard3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardCard3.CardBg = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.dashboardCard3.CardIcon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.profile_user;
            this.dashboardCard3.CardTitle = "Students";
            this.dashboardCard3.CardValue = "0";
            this.dashboardCard3.Location = new System.Drawing.Point(16, 327);
            this.dashboardCard3.Name = "dashboardCard3";
            this.dashboardCard3.Size = new System.Drawing.Size(258, 218);
            this.dashboardCard3.TabIndex = 2;
            // 
            // dashboardCard1
            // 
            this.dashboardCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardCard1.CardBg = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.dashboardCard1.CardIcon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.profile_user;
            this.dashboardCard1.CardTitle = "Students";
            this.dashboardCard1.CardValue = "0";
            this.dashboardCard1.Location = new System.Drawing.Point(19, 64);
            this.dashboardCard1.Name = "dashboardCard1";
            this.dashboardCard1.Size = new System.Drawing.Size(258, 218);
            this.dashboardCard1.TabIndex = 2;
            this.dashboardCard1.Load += new System.EventHandler(this.dashboardCard1_Load);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.dashboardTab);
            this.tabControl.Controls.Add(this.studentsTab);
            this.tabControl.Controls.Add(this.enrollmentTab);
            this.tabControl.Controls.Add(this.subjectsTab);
            this.tabControl.Controls.Add(this.settingsTab);
            this.tabControl.Controls.Add(this.manageUserTab);
            this.tabControl.Controls.Add(this.reportsTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(210, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(870, 771);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // enrollmentTab
            // 
            this.enrollmentTab.Controls.Add(this.tabControl1);
            this.enrollmentTab.Location = new System.Drawing.Point(22, 4);
            this.enrollmentTab.Name = "enrollmentTab";
            this.enrollmentTab.Size = new System.Drawing.Size(844, 763);
            this.enrollmentTab.TabIndex = 2;
            this.enrollmentTab.Text = "Enrollment";
            this.enrollmentTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 763);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.enrollmentsTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 735);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // enrollmentsTab1
            // 
            this.enrollmentsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enrollmentsTab1.Location = new System.Drawing.Point(3, 3);
            this.enrollmentsTab1.Name = "enrollmentsTab1";
            this.enrollmentsTab1.Size = new System.Drawing.Size(830, 729);
            this.enrollmentsTab1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.enrollmentsTab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 735);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // enrollmentsTab2
            // 
            this.enrollmentsTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enrollmentsTab2.Location = new System.Drawing.Point(3, 3);
            this.enrollmentsTab2.Name = "enrollmentsTab2";
            this.enrollmentsTab2.Size = new System.Drawing.Size(830, 729);
            this.enrollmentsTab2.TabIndex = 0;
            // 
            // subjectsTab
            // 
            this.subjectsTab.Location = new System.Drawing.Point(22, 4);
            this.subjectsTab.Name = "subjectsTab";
            this.subjectsTab.Size = new System.Drawing.Size(844, 763);
            this.subjectsTab.TabIndex = 3;
            this.subjectsTab.Text = "subjectsTab";
            this.subjectsTab.UseVisualStyleBackColor = true;
            // 
            // settingsTab
            // 
            this.settingsTab.Location = new System.Drawing.Point(22, 4);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(844, 763);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "tabPage2";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // manageUserTab
            // 
            this.manageUserTab.Location = new System.Drawing.Point(22, 4);
            this.manageUserTab.Name = "manageUserTab";
            this.manageUserTab.Size = new System.Drawing.Size(844, 763);
            this.manageUserTab.TabIndex = 5;
            this.manageUserTab.Text = "tabPage2";
            this.manageUserTab.UseVisualStyleBackColor = true;
            // 
            // reportsTab
            // 
            this.reportsTab.Location = new System.Drawing.Point(22, 4);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Size = new System.Drawing.Size(844, 763);
            this.reportsTab.TabIndex = 6;
            this.reportsTab.Text = "tabPage2";
            this.reportsTab.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 771);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.EnrollmentMenuLayout.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.studentsTab.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.enrollmentTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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
        private CustomControls.CustomLabel customLabel1;
        private CustomControls.SidemenuButton studentsTabLink;
        private CustomControls.SidemenuButton dashboardTabLInk;
        private CustomControls.SidemenuButton sidemenuButton8;
        private Components.StudentsTabComponent studentsTabComponent;
        private CustomControls.CustomLabel customLabel3;
        private TabPage subjectsTab;
        private TabPage settingsTab;
        private TabPage manageUserTab;
        private TabPage reportsTab;
        private Components.StudentsTabComponent studentsTabComponent1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Components.EnrollmentsTab enrollmentsTab1;
        private TabPage tabPage2;
        private Components.EnrollmentsTab enrollmentsTab2;
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.MenuButton menuButton1;
        private CustomControls.MenuButton menuButton2;
        private CustomControls.MenuButton menuButton3;
        private FlowLayoutPanel EnrollmentMenuLayout;
        private CustomControls.CollapsibleToggler enrollmentMenuToggler;
        private CustomControls.MenuButton menuButton4;
        private CustomControls.MenuButton menuButton5;
        private CustomControls.MenuButton menuButton6;
    }
}