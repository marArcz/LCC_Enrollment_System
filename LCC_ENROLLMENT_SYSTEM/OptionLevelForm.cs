using LCC_ENROLLMENT_SYSTEM.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC_ENROLLMENT_SYSTEM
{
    public partial class OptionLevelForm : Form
    {
        public OptionLevelForm()
        {
            InitializeComponent();
            
            if(AppSettings.SchoolLevel == AppSettings.Level.ELEMENTARY)
            {
                btnElementary.Toggled = true;
            }
            else if(AppSettings.SchoolLevel == AppSettings.Level.JUNIOR_HIGHSCHOOL)
            {
                btnJuniorHigh.Toggled = true;
            }
            else
            {
                btnSeniorHigh.Toggled = true;
            }
        }

        public void OnLevelClick(object sender, EventArgs e)
        {
            ToggleButton btn = (ToggleButton) sender;

            switch (btn.Tag.ToString())
            {
                case "elementary":
                    btn.Toggled = true;
                    AppSettings.SchoolLevel = AppSettings.Level.ELEMENTARY;
                    break;
                case "junior":
                    btn.Toggled = true;
                    AppSettings.SchoolLevel = AppSettings.Level.JUNIOR_HIGHSCHOOL;
                    break;
                case "senior":
                    AppSettings.SchoolLevel = AppSettings.Level.SENIOR_HIGHSCHOOL;
                    btn.Toggled = true; break;
                default:
                    break;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void toggleButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
