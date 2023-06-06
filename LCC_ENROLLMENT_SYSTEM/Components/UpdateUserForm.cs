using LCC_ENROLLMENT_SYSTEM.Data;
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
    public partial class UpdateUserForm : Form
    {
        int id;
        public UpdateUserForm(int id)
        {
            InitializeComponent();
            this.id = id;
            LoadData();
        }

        private void LoadUserTypes()
        {

        }

        private void LoadData()
        {
            AppDbContext db = new();
            User user = db.Users.Find(id);
            textBoxFullname.Texts = user.FullName;
            textBoxUsername.Texts = user.Username;
            textBoxPassword.Texts = user.Password;
        }

        private void formFooter1_onBtnSaveClicked(object sender, EventArgs e)
        {
            AppDbContext db = new();
            string fullname = textBoxFullname.Texts;
            string password = textBoxPassword.Texts;
            string username = textBoxUsername.Texts;

            User user = db.Users.Find(id);

            user.Username = username;
            user.FullName = fullname;
            user.Password = password;

            if(db.SaveChanges() >= 0)
            {
                SuccessDialog.ShowMesage("Successfully updated!");
                this.Close();
            }
        }

        private void formFooter1_onBtnResetClicked(object sender, EventArgs e)
        {
            LoadData();
        }

        private void formFooter1_onBtnCancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
