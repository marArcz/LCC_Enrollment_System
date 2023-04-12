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
    public partial class AddSubjectForm : Form
    {
        List<GradeLevel> GradeLevels;
        SuccessDialog successDialog;
        public AddSubjectForm()
        {
            InitializeComponent();
            successDialog= new SuccessDialog();
            loadGradeLevels();
            
        }

        private void loadGradeLevels()
        {
            AppDbContext db = new();

            GradeLevels = db.GradeLevels.ToList();
            comboBoxLevel.Items.Clear();
            foreach (var item in GradeLevels)
            {
                comboBoxLevel.Items.Add("Grade " + item.Level);
            }

            if(comboBoxLevel.Items.Count > 0)
            {
                comboBoxLevel.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDbContext db = new();
            string subject = textBoxSubject.Texts;
            string description = textBoxDescription.Texts;
            Subject newSubject = new()
            {
                Level = GradeLevels.ElementAt(comboBoxLevel.SelectedIndex).Level,
                Name = subject,
                Description = description
            };
            db.Subjects.Add(newSubject);
            var added = db.SaveChanges() > 0;

            if(added)
            {
                successDialog.ShowSuccess("Successfully added new subject!");
                this.Close();
            }
        }
    }
}
