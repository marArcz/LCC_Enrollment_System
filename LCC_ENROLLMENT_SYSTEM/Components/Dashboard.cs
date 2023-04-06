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
    public partial class Dashboard : UserControl
    {
        private string cardTitle;
        private Image cardIcon;

        public string CardTitle { get => cardTitle; 
            set {
                cardTitle = value;
                label2.Text = value;
            }
        }
        public Image CardIcon { get => cardIcon; 
            set {
                cardIcon = value;
                pictureBox1.Image = value;
            } 
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label2.Text = CardTitle;
            pictureBox1.Image = cardIcon;   
        }

    }
}
