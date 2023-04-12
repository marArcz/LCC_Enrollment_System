namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    partial class ElegantTextBox
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
            this.borderedPanel1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.BorderedPanel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label = new LCC_ENROLLMENT_SYSTEM.CustomControls.CustomLabel();
            this.borderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // borderedPanel1
            // 
            this.borderedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.borderedPanel1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.borderedPanel1.BorderRadius = 3;
            this.borderedPanel1.BorderSize = 1;
            this.borderedPanel1.Controls.Add(this.textBox);
            this.borderedPanel1.Controls.Add(this.pictureBox);
            this.borderedPanel1.ForeColor = System.Drawing.Color.Black;
            this.borderedPanel1.Location = new System.Drawing.Point(1, 18);
            this.borderedPanel1.Name = "borderedPanel1";
            this.borderedPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.borderedPanel1.Size = new System.Drawing.Size(348, 44);
            this.borderedPanel1.TabIndex = 5;
            this.borderedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.borderedPanel1_Paint);
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(59, 12);
            this.textBox.Name = "textBox";
            this.textBox.PlaceholderText = "Username";
            this.textBox.Size = new System.Drawing.Size(283, 19);
            this.textBox.TabIndex = 1;
            this.textBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.user__6_;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox.Size = new System.Drawing.Size(50, 38);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("Heebo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.FontSize = 8F;
            this.label.FontStyle = System.Drawing.FontStyle.Regular;
            this.label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label.Location = new System.Drawing.Point(9, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 17);
            this.label.TabIndex = 6;
            this.label.Text = "Username";
            this.label.Visible = false;
            // 
            // ElegantTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label);
            this.Controls.Add(this.borderedPanel1);
            this.Name = "ElegantTextBox";
            this.Size = new System.Drawing.Size(351, 64);
            this.borderedPanel1.ResumeLayout(false);
            this.borderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public BorderedPanel borderedPanel1;
        public TextBox textBox;
        public PictureBox pictureBox;
        public CustomLabel label;
    }
}
