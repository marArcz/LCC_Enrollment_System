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
    public partial class DashboardCard : UserControl
    {
        private string cardValue = "0";
        private string cardTitle = "Students";
        private Image cardIcon;
        private Color cardBg = Color.Black;

        public string CardValue { get => cardValue; set => cardValue = value; }
        public string CardTitle { get => cardTitle; set => cardTitle = value; }
        public Image CardIcon { get => cardIcon; set => cardIcon = value; }
        public Color CardBg { get => cardBg; set => cardBg = value; }

        public DashboardCard()
        {
            InitializeComponent();
            setValues();
        }

        private void lblValue_Click(object sender, EventArgs e)
        {

        }

        private void DashboardCard_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.setValues();
            base.OnPaint(e);
        }

        private void setValues()
        {
            lblValue.Text = cardValue;
            lblTitle.Text = cardTitle;
            mainPanel.BackgroundImage = cardIcon;
            mainPanel.BackColor = CardBg;
        }
    }
}
