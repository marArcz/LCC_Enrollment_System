using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    public class CustomLabel : Label
    {
        public Font font;
        private float fontSize = 9F;
        private FontStyle fontStyle = FontStyle.Regular;


        public CustomLabel() {
            CustomFonts.init();
            this.font = CustomFonts.GetFont(this.FontSize);
            Font = this.font;
        }

        public float FontSize { get => fontSize;
            set
            {
                fontSize = value;
                Refresh();
            }
        }

        public FontStyle FontStyle { get => fontStyle; set => fontStyle = value; }

        protected override void OnPaint(PaintEventArgs e)
        {
            Font = CustomFonts.GetFont(this.fontSize,fontStyle);
            base.OnPaint(e);
        }
    }
}
