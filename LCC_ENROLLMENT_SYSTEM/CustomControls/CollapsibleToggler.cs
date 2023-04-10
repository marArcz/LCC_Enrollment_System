using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    public partial class CollapsibleToggler : MenuButton
    {
        public class CollapseListener
        {
            public void OnCollapse(bool toggled) { }
        }

        private bool toggled = false;
        public bool Toggled { get => toggled; set {
                toggled = value;
                label.Image = toggled ? ToggledIcon : DefaultIcon;

            }
        }
        private EventHandler onToggle;
        private Image DefaultIcon;
        private Image ToggledIcon;
        private CollapseListener onCollapseListener;
        public CollapseListener OnCollapseListener { get => onCollapseListener; set => onCollapseListener = value; }

        public EventHandler OnToggle { get => onToggle; set => onToggle = value; }

        public CollapsibleToggler()
        {
            InitializeComponent();
            DefaultIcon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.right_chevron;
            ToggledIcon = global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.down_chevron__1_;

            label.Image = toggled ? ToggledIcon : DefaultIcon;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            /*label.Image = toggled ? ToggledIcon : DefaultIcon;*/
            base.OnPaint(e);
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void CollapsibleToggler_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void CollapsibleToggler_Click(object sender, EventArgs e)
        {
            if(OnToggle != null)
            {
                OnToggle(sender,e);
            }
        }
    }
}
