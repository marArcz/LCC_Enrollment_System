namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    partial class ElegantPasswordBox
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
            this.passwordToggler = new System.Windows.Forms.PictureBox();
            this.borderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordToggler)).BeginInit();
            this.SuspendLayout();
            // 
            // borderedPanel1
            // 
            this.borderedPanel1.Controls.Add(this.passwordToggler);
            this.borderedPanel1.Controls.SetChildIndex(this.pictureBox, 0);
            this.borderedPanel1.Controls.SetChildIndex(this.textBox, 0);
            this.borderedPanel1.Controls.SetChildIndex(this.passwordToggler, 0);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Size = new System.Drawing.Size(231, 19);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Heebo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Size = new System.Drawing.Size(59, 17);
            // 
            // passwordToggler
            // 
            this.passwordToggler.Dock = System.Windows.Forms.DockStyle.Right;
            this.passwordToggler.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.show;
            this.passwordToggler.Location = new System.Drawing.Point(296, 3);
            this.passwordToggler.Name = "passwordToggler";
            this.passwordToggler.Size = new System.Drawing.Size(49, 38);
            this.passwordToggler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.passwordToggler.TabIndex = 2;
            this.passwordToggler.TabStop = false;
            this.passwordToggler.Click += new System.EventHandler(this.passwordToggler_Click);
            // 
            // ElegantPasswordBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ElegantPasswordBox";
            this.borderedPanel1.ResumeLayout(false);
            this.borderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordToggler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox passwordToggler;
    }
}
