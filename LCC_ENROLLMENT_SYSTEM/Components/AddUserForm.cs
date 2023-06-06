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
    public partial class AddUserForm : Form
    {
        List<UserType> UserTypes;
        public AddUserForm()
        {
            InitializeComponent();
            LoadUserTypes();
        }

        private void LoadUserTypes()
        {
     
        }

        private void formFooter1_Load(object sender, EventArgs e)
        {

        }

        private void formFooter1_onBtnSaveClicked(object sender, EventArgs e)
        {
            AppDbContext db = new();
            string fullname = textBoxFullname.Texts;
            string password = textBoxPassword.Texts;
            string username = textBoxUsername.Texts;

            User newUser = new()
            {
                FullName = fullname,
                Password = password,
                Username = username,
            };

            db.Users.Add(newUser);

            if(db.SaveChanges() > 0)
            {
                SuccessDialog.ShowMesage("Successfully Added!");
                this.Close();
            }
        }

        private void formFooter1_onBtnCancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formFooter1_onBtnResetClicked(object sender, EventArgs e)
        {
            textBoxFullname.Texts = "";
            textBoxPassword.Texts = "";
            textBoxUsername.Texts = "";
        }
    }
}
