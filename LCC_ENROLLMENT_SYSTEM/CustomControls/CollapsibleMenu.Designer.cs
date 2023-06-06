namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    partial class CollapsibleMenu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.collapsibleToggler1 = new LCC_ENROLLMENT_SYSTEM.CustomControls.CollapsibleToggler();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.collapsibleToggler1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // collapsibleToggler1
            // 
            this.collapsibleToggler1.Active = false;
            this.collapsibleToggler1.ActiveBgColor = System.Drawing.Color.Gray;
            this.collapsibleToggler1.BackColor = System.Drawing.Color.DimGray;
            this.collapsibleToggler1.BorderColor = System.Drawing.Color.Blue;
            this.collapsibleToggler1.BorderSize = 5;
            this.collapsibleToggler1.BtnText = "Text";
            this.collapsibleToggler1.DefaultBgColor = System.Drawing.Color.DimGray;
            this.collapsibleToggler1.FontSize = 10F;
            this.collapsibleToggler1.FontStyle = System.Drawing.FontStyle.Regular;
            this.collapsibleToggler1.Icon = null;
            this.collapsibleToggler1.IndicatorPos = LCC_ENROLLMENT_SYSTEM.CustomControls.MenuButton.borderPosition.start;
            this.collapsibleToggler1.Location = new System.Drawing.Point(3, 3);
            this.collapsibleToggler1.Name = "collapsibleToggler1";
            this.collapsibleToggler1.OnCollapseListener = null;
            this.collapsibleToggler1.Padding = new System.Windows.Forms.Padding(7);
            this.collapsibleToggler1.Size = new System.Drawing.Size(194, 49);
            this.collapsibleToggler1.Tab1 = "Tab";
            this.collapsibleToggler1.TabIndex = 1;
            this.collapsibleToggler1.Toggled = false;
            // 
            // CollapsibleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CollapsibleMenu";
            this.Size = new System.Drawing.Size(203, 58);
            this.Load += new System.EventHandler(this.CollapsibleMenu_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private CollapsibleToggler collapsibleToggler1;
    }
}
