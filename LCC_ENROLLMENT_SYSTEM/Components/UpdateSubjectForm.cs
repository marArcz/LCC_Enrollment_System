using LCC_ENROLLMENT_SYSTEM.Data;
using LCC_ENROLLMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class UpdateSubjectForm : Form
    {
        public Subject subject;
        private List<GradeLevel> GradeLevels;
        public UpdateSubjectForm()
        {
            InitializeComponent();
        }

        public UpdateSubjectForm(Subject subject)
        {
            InitializeComponent();
            this.subject = subject;

            textBoxSubject.Texts = subject.Name;
            textBoxDescription.Texts = subject.Description;
            LoadGradeLevels();
        }

        private void LoadGradeLevels()
        {
            AppDbContext db = new();
            GradeLevels = db.GradeLevels.ToList();
            checkedListLevels.Items.Clear();
            foreach ( var item in GradeLevels )
            {
                checkedListLevels.Items.Add($"Grade {item.Level}");
            }
        }

        private void UpdateSubjectForm_Load(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkedListLevels.CheckedItems.Count == 0)
            {
                MessageBox.Show("You need to select at least one grade level!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            AppDbContext db = new();


            var curSubject = db.Subjects.Include(s => s.subjectGroups).Where(s => s.id == subject.id).First();
            curSubject.Name = textBoxSubject.Texts;
            curSubject.Description = textBoxDescription.Texts;

            if (db.SaveChanges() >= 0)
            {
                SubjectGroup subjectGroup;
                //delete previous subject groups
                foreach (SubjectGroup sg in curSubject.subjectGroups)
                {
                    db.SubjectGroups.Remove(sg);
                }
                db.SaveChanges();

                foreach (int index in checkedListLevels.CheckedIndices)
                {
                    subjectGroup = new()
                    {
                        SubjectId = curSubject.id,
                        Level = GradeLevels.ElementAt(index).Level
                    };
                    db.SubjectGroups.Add(subjectGroup);

                }

                db.SaveChanges();
                SuccessDialog.ShowMesage("Successfully updated subject!");
                this.Close();
            }
        }
    }
}
