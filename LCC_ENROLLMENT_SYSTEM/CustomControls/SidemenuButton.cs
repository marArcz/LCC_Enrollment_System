using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;


namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    public class SidemenuButton : Button
    {
        private Color borderColor = Color.Blue;
        private string key = "Key";
        private bool active = false;
        private int borderSize = 5;
        private Color activeBgColor = Color.Gray;
        private Image? icon;
        private Color defaultBgColor = Color.DimGray;
        private float fontSize = 10F;
        private FontStyle fontStyle = FontStyle.Regular;

        public enum borderPosition
        {
            start,
            end,
        }

        private borderPosition indicatorPos = borderPosition.start;

        public Color BorderColor { get => borderColor; set => borderColor = value; }
        public string Tab { get => key; set => key = value; }
        public bool Active { get => active; 
            set
            {
                active = value;
                this.Refresh();
            }
         }
        public int BorderSize { get => borderSize; set => borderSize = value; }
        public borderPosition IndicatorPos { get => indicatorPos; set => indicatorPos = value; }
        public Image? Icon { get => icon; set => icon = value; }
        public Color ActiveBgColor { get => activeBgColor;
            set
            {
                activeBgColor = value;
                this.Refresh();
            }
        }
        public Color DefaultBgColor { get => defaultBgColor; 
            set
            {
                defaultBgColor = value;
                this.Refresh();
            }
        }

        public float FontSize { get => fontSize; set => fontSize = value; }
        public FontStyle FontStyle { get => fontStyle; set => fontStyle = value; }

        public SidemenuButton()
        {
            CustomFonts.init(); 
            this.Font = CustomFonts.GetFont(fontSize, fontStyle);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Image = icon;
            this.Padding = new Padding(12,0,0,0);
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.Cursor= Cursors.Hand;
            if (active)
            {
                this.BackColor = ActiveBgColor;
            }
            else
            {
                this.BackColor = DefaultBgColor;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            this.Font = CustomFonts.GetFont(fontSize, fontStyle);

            this.Image = icon;
            
            if (active)
            {
                this.BackColor = ActiveBgColor;
                /*this.ForeColor = borderColor;*/
                GraphicsPath borderPath = new GraphicsPath();
                Pen penBorder = new Pen(borderColor, BorderSize);

                if(indicatorPos == borderPosition.start)
                {
                    borderPath.AddLine(0, 0, 0, this.Size.Height);
                }
                else
                {
                    borderPath.AddLine(this.Size.Width, 0, this.Size.Width, this.Size.Height);
                }

                pevent.Graphics.DrawPath(penBorder, borderPath);
            }
            else
            {
                this.BackColor = DefaultBgColor;
            }
        }
    
    }
}
