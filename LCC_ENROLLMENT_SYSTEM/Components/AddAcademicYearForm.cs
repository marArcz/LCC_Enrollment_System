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
    public partial class AddAcademicYearForm : Form
    {
        public AddAcademicYearForm()
        {
            InitializeComponent();
        }

        private void formFooter1_onBtnSaveClicked(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBoxFrom.Texts) || String.IsNullOrWhiteSpace(textBoxTo.Texts))
            {
                MessageDialog.ShowMessage("Please fill all the boxes!");
                return;
            }
            AppDbContext db = new();
            int from = Convert.ToInt32(textBoxFrom.Texts);
            int to = Convert.ToInt32(textBoxTo.Texts);

            SchoolYear schoolYear = new() { From= from, To = to };

            db.SchoolYears.Add(schoolYear);

            if(db.SaveChanges() > 0)
            {
                SuccessDialog.ShowMesage("Successfully added!");
                this.Close();
            }
        }

        private void formFooter1_onBtnResetClicked(object sender, EventArgs e)
        {
            textBoxTo.Texts = "";
            textBoxFrom.Texts = "";
        }

        private void formFooter1_onBtnCancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formFooter1_Load(object sender, EventArgs e)
        {

        }
    }
}
