using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC_ENROLLMENT_SYSTEM.Components
{
    public partial class Topbar : UserControl
    {
        private int textSize = 22;
        public Topbar()
        {
            InitializeComponent();
            label.FontSize = textSize;
        }
        public int TextSize { get => textSize;
            set
            {
                textSize = value;
                label.FontSize = textSize;
                this.Refresh();
            }
        }

        private void Topbar_Resize(object sender, EventArgs e)
        {
            int h = pictureBox1.Height;
            pictureBox1.Width = h;
        }
    }
}
