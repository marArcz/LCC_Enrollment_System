using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    public class SidemenuButtonRounded : CustomButton
    {
        private Color activeBg = Color.Gray;
        private Color defaultBg = Color.Black;
        private Color defaultTextColor = Color.Black;
        private Color activeTextColor = Color.White;
        private bool active = false;
        private string tab = "TargetTab";

        public Color ActiveBg { get => activeBg; set => activeBg = value; }
        public Color DefaultBg { get => defaultBg; set => defaultBg = value; }
        public Color DefaultTextColor { get => defaultTextColor; set => defaultTextColor = value; }
        public Color ActiveTextColor { get => activeTextColor; set => activeTextColor = value; }
        public bool Active { get => active;
            set
            {
                active = value;
                updateState();
                this.Invalidate();
            }
        }

        public string Tab { get => tab; set => tab = value; }

        public SidemenuButtonRounded()
        {
            this.BorderRadius = 10;
            updateState();
        }

        private void updateState()
        {
            if (Active)
            {
                this.BackColor = ActiveBg;
                this.ForeColor = ActiveTextColor;
            }
            else
            {
                this.BackColor = DefaultBg;
                this.ForeColor = DefaultTextColor;
            }
        }


    }
}
