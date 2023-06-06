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
    public partial class AddAdviserForm : Form
    {
        public AddAdviserForm()
        {
            InitializeComponent();
        }

        private void customLabel2_Click(object sender, EventArgs e)
        {

        }

        private void formFooter1_onBtnSaveClicked(object sender, EventArgs e)
        {
            String firstname = textBoxFirstname.Texts;
            String middlename = textBoxMiddlename.Texts;
            String lastname = textBoxLastname.Texts;

            Adviser newAdviser = new()
            {
                Firstname = firstname,
                Middlename = middlename,
                Lastname = lastname
            };

            AppDbContext db = new();
            db.Advisers.Add(newAdviser);

            if (db.SaveChanges() >= 0)
            {
                SuccessDialog.ShowMesage("Successfully added adviser!");
                this.Close();
            }
        }
    }
}
