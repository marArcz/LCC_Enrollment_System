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

            foreach (var item in GradeLevels)
            {
                checkedListLevels.Items.Add($"Grade {item.Level}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(checkedListLevels.CheckedItems.Count == 0)
            {
                MessageBox.Show("You need to select at least one grade level!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            AppDbContext db = new();
            string subject = textBoxSubject.Texts;
            string description = textBoxDescription.Texts;
            Subject newSubject = new() { Name = subject, Description = description };
            //add subject
            db.Subjects.Add(newSubject);
            db.SaveChanges();

            //add subject groups
            foreach (int index in checkedListLevels.CheckedIndices)
            {
                SubjectGroup subjectGroup = new()
                {
                    Level = GradeLevels.ElementAt(index).Level,
                    SubjectId = newSubject.id
                };
                db.SubjectGroups.Add(subjectGroup);
            }
            if(db.SaveChanges() >= 0)
            {
                SuccessDialog.ShowMesage("Successfully added subject!");

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
