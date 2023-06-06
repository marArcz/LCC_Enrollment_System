namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    partial class CollapsibleToggler
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Click += new System.EventHandler(this.CollapsibleToggler_Click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Heebo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label.Image = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.right_chevron;
            this.label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label.Click += new System.EventHandler(this.CollapsibleToggler_Click);
            // 
            // CollapsibleToggler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CollapsibleToggler";
            this.Click += new System.EventHandler(this.CollapsibleToggler_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CollapsibleToggler_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
