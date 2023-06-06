using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    public partial class MenuButton : UserControl
    {
        private Color borderColor = Color.Blue;
        private string Tab = "Tab";
        private bool active = false;
        private int borderSize = 5;
        private Color activeBgColor = Color.Gray;
        private Image? icon;
        private Color defaultBgColor = Color.DimGray;
        private float fontSize = 10F;
        private FontStyle fontStyle = FontStyle.Regular;
        private string text = "Text";
        private EventHandler onClickHandler;
        public enum borderPosition
        {
            start,
            end,
        }

        private borderPosition indicatorPos = borderPosition.start;

        public Color BorderColor { get => borderColor; set => borderColor = value; }
        public string Tab1 { get => Tab; set => Tab = value; }
        public bool Active { get => active; set
            {
                active = value;
                this.Invalidate();
            }        
        }
        public int BorderSize { get => borderSize; set => borderSize = value; }
        public Color ActiveBgColor { get => activeBgColor; set => activeBgColor = value; }
        public Image? Icon { get => icon; set
            {
                icon = value;
                pictureBox.Image = value;
            }        
        }
        public Color DefaultBgColor { get => defaultBgColor; set => defaultBgColor = value; }
        public float FontSize { get => fontSize; set => fontSize = value; }
        public FontStyle FontStyle { get => fontStyle; set => fontStyle = value; }
        public borderPosition IndicatorPos { get => indicatorPos; set => indicatorPos = value; }
        public string BtnText { get => text; set
            {
                text = value;
                label.Text = value;
            }
        }

        public EventHandler OnClickHandler { get => onClickHandler; set => onClickHandler = value; }

        public MenuButton()
        {
            InitializeComponent();
            CustomFonts.init();
            pictureBox.Image = Icon;
            this.Cursor = Cursors.Hand;
            if (Active)
            {
                this.BackColor = ActiveBgColor;
            }
            else
            {
                this.BackColor = DefaultBgColor;
            }
            label.Text = BtnText;
            
        }

        private void MenuButton_Click(object? sender, EventArgs e)
        {
            if(OnClickHandler != null)
            {
                onClickHandler(this,e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graph = e.Graphics;

            if (Active)
            {
                this.BackColor = ActiveBgColor;
                Pen penBorder = new Pen(borderColor, BorderSize);
                penBorder.Alignment = PenAlignment.Inset;
                this.Region = new Region(this.ClientRectangle);
                if (indicatorPos == borderPosition.start)
                {
                    graph.DrawLine(penBorder, 0, 0, 0, this.Size.Height);
                }
                else
                {
                    graph.DrawLine(penBorder, this.Size.Width, 0, this.Size.Width, this.Size.Height);
                }
            }
            else
            {
                this.BackColor = DefaultBgColor;
            }


            base.OnPaint(e);

        }

        private void MenuButton_MouseHover(object sender, EventArgs e)
        {
            Color c1, c2;
            if(active)
            {
                c1 = ActiveBgColor;
            }
            else
            {
                c1 = DefaultBgColor;
            }
            c2 = Color.FromArgb(c1.A,
                    (int)(c1.R * 0.8), (int)(c1.G * 0.8), (int)(c1.B * 0.8));
            this.BackColor = Color.Red;
        }
    }
}
