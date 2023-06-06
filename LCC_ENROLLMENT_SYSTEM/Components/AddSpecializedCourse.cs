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
    public partial class AddSpecializedCourse : Form
    {
        public AddSpecializedCourse()
        {
            InitializeComponent();
        }

        private void customLabel1_Click(object sender, EventArgs e)
        {

        }

        private void formFooter1_onBtnCancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formFooter1_onBtnSaveClicked(object sender, EventArgs e)
        {
            AppDbContext db = new();
            db.SpecializedCourses
               .Add(new SpecializedCourse() { Name = textBoxName.Texts, Description = textBoxDescription.Texts });

            if(db.SaveChanges() > 0)
            {
                SuccessDialog.ShowMesage("Successfully added!");
                this.Close();
            }
        }

        private void formFooter1_Load(object sender, EventArgs e)
        {
           
        }

        private void formFooter1_onBtnResetClicked(object sender, EventArgs e)
        {
            textBoxName.Texts = "";
            textBoxDescription.Texts = "";
        }
    }
}
