namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    partial class MenuButton
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.dashboard__4_;
            this.pictureBox.Location = new System.Drawing.Point(7, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(54, 35);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.FontSize = 10F;
            this.label.FontStyle = System.Drawing.FontStyle.Regular;
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(61, 7);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(136, 35);
            this.label.TabIndex = 1;
            this.label.Text = "customLabel1";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // MenuButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Name = "MenuButton";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(204, 49);
            this.Click += new System.EventHandler(this.MenuButton_Click);
            this.Enter += new System.EventHandler(this.MenuButton_MouseHover);
            this.MouseHover += new System.EventHandler(this.MenuButton_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public PictureBox pictureBox;
        public CustomLabel label;
    }
}
