using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    public class ToggleButton : CustomButton
    {
        private bool toggled = false;
        private Color toggledBg = Color.Black;
        private Color defaultBg = Color.White;
        private Color toggledTextColor = Color.White;

        public bool Toggled { get => toggled; set => toggled = value; }
        public Color ToggledBg { get => toggledBg; set => toggledBg = value; }
        public Color ToggledTextColor { get => toggledTextColor; set => toggledTextColor = value; }
        public Color DefaultBg { get => defaultBg; set => defaultBg = value; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.BackgroundColor = Toggled? ToggledBg : defaultBg;
            this.ForeColor = Toggled? ToggledTextColor : BorderColor;
            base.OnPaint(pevent);
        }
    }
}
