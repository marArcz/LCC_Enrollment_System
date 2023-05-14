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
    public partial class CustomTab : UserControl
    {
        public CustomTab()
        {
            InitializeComponent();
            comboBoxRows.Text = "10";
        }
    }
}
