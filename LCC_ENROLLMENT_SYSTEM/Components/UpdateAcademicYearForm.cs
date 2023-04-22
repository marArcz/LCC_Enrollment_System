using LCC_ENROLLMENT_SYSTEM.Data;
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
    public partial class UpdateAcademicYearForm : Form
    {
        int id;
        public UpdateAcademicYearForm(int id)
        {
            InitializeComponent();
            this.id = id;
            LoadData();
        }

        private void LoadData()
        {
            AppDbContext db = new();
            var schoolYear = db.SchoolYears.Find(id);

            textBoxFrom.Texts = schoolYear.From.ToString();
            textBoxTo.Texts = schoolYear.To.ToString();
        }

        private void formFooter1_onBtnSaveClicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxFrom.Texts) || String.IsNullOrWhiteSpace(textBoxTo.Texts))
            {
                MessageDialog.ShowMessage("Please fill all the boxes!");
                return;
            }

            AppDbContext db = new();
            var schoolYear = db.SchoolYears.Find(id);

            schoolYear.From = Convert.ToInt32(textBoxFrom.Texts);
            schoolYear.To = Convert.ToInt32(textBoxTo.Texts);

            if(db.SaveChanges() >= 0)
            {
                SuccessDialog.ShowMesage("Successfully updated!");
                this.Close();
            }
        }

        private void formFooter1_onBtnCancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formFooter1_onBtnResetClicked(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
