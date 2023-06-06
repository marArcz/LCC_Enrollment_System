using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    public class BorderedPanel : Panel
    {
        private int borderRadius = 0;
        private int borderSize = 1;
        private Color borderColor = Color.Gray;

        public int BorderRadius { get => borderRadius; set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        public int BorderSize { get => borderSize; set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public Color BorderColor { get => borderColor; set
            {
                borderColor = value;
                this.Invalidate();
            }        
        }

        public BorderedPanel() {
            this.BackColor = Color.White;
            this.Size = new Size(200, 180);
            this.ForeColor = Color.Black;
            this.Resize += BorderedPanel_Resize;
        }

        private void BorderedPanel_Resize(object? sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);
            int smoothSize = 2;
            if (BorderSize > 0)
                smoothSize = BorderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - BorderSize))
                using (Pen penSurface = new Pen(this.BackColor, smoothSize))
                using (Pen penBorder = new Pen(BorderColor, BorderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (BorderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
