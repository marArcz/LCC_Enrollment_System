using LCC_ENROLLMENT_SYSTEM.Models;
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
    public partial class SettingsTabComponent : UserControl
    {
        public SettingsTabComponent()
        {
            InitializeComponent();
        }

        private void customLabel3_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            UpdateUserForm updateUserForm = new(AppManager.CurrentUser.Id);
            updateUserForm.ShowDialog();
            LoadUser();
        }

        public void LoadUser()
        {
            User user = AppManager.CurrentUser;
            textBoxFullname.Texts = user.FullName;
            textBoxUsername.Texts = user.Username;

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            ManageAcademicYear manageAcademicYear = new();
            manageAcademicYear.ShowDialog();

        }
    }
}
