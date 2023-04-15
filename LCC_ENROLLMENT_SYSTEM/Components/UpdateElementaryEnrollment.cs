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
 
    public partial class UpdateElementaryEnrollment : Form
    {
        List<GradeLevel> gradeLevels;
        List<Section> sections;
        List<SubjectGroup> subjectGroups;
        List<SubjectsEnrolled> subjectsEnrolled;
        private int enrollmentId;
       
        public UpdateElementaryEnrollment(int id)
        {
            InitializeComponent();
            this.enrollmentId = id;
            LoadGradeLevels();
            LoadSections();
            LoadData();
            LoadSubjects();

        }

        private void LoadData()
        {
            AppDbContext db = new();
            var enrollment = db.Enrollments
                .Include(e => e.gradeLevel)
                .Include(e => e.section)
                .Include(e => e.student)
                .Where(e => e.id == enrollmentId)
                .First();

            textBoxName.Text = enrollment.student.firstname + " " + enrollment.student.lastname;
            comboBoxLevel.SelectedIndex = gradeLevels.IndexOf(gradeLevels.Where(g => g.Id == enrollment.gradeLevelId).First());
            comboBoxSection.SelectedIndex = sections.IndexOf(sections.Where(s => s.Id == enrollment.sectionId).First());

        }

        private void LoadSections()
        {
            AppDbContext db = new();
            sections = db.Sections.ToList();
            comboBoxSection.Items.Clear();
            foreach (var item in sections)
            {
                comboBoxSection.Items.Add(item.Name);
            }
            if (comboBoxSection.Items.Count > 0) comboBoxSection.SelectedIndex = 0;

        }
        private void LoadGradeLevels()
        {
            AppDbContext db = new();
            gradeLevels = db.GradeLevels.ToList();
            comboBoxLevel.Items.Clear();
            foreach (var item in gradeLevels)
            {
                comboBoxLevel.Items.Add(item.Level);
            }
            if (comboBoxLevel.Items.Count > 0) comboBoxLevel.SelectedIndex = 0;
        }
        private void LoadSubjects()
        {
            AppDbContext db = new();
            subjectsEnrolled = db.SubjectsEnrolled.Where(s => s.enrollmentId == enrollmentId).ToList();
            int gradeLevel = Convert.ToInt32(comboBoxLevel.Text);
            subjectGroups = db.SubjectGroups.Include(s => s.SubjectModel).Where(s => s.Level == Convert.ToInt32(comboBoxLevel.Text)).ToList();

            checkedListSubjects.Items.Clear();
            foreach (SubjectGroup item in subjectGroups)
            {
                bool isChecked = subjectsEnrolled.Where(s => s.subjectId == item.SubjectId).ToList().Any();
                checkedListSubjects.Items.Add(item.SubjectModel.Name,isChecked);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(checkedListSubjects.CheckedItems.Count <= 0)
            {
                MessageBox.Show("You need to select at least one grade level!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //delete previous subjects enrolled
            AppDbContext db = new();
            db.SubjectsEnrolled.Where(s => s.enrollmentId == enrollmentId).ToList().ForEach(s => db.SubjectsEnrolled.Remove(s));

            db.SaveChanges();

            //save changes
            Enrollment enrollment = db.Enrollments.Find(enrollmentId);
            enrollment.gradeLevelId = gradeLevels.ElementAt(comboBoxLevel.SelectedIndex).Id;
            enrollment.sectionId = sections.ElementAt(comboBoxSection.SelectedIndex).Id;

            if(db.SaveChanges() >= 0)
            {
                foreach (int index in checkedListSubjects.CheckedIndices)
                {
                    SubjectsEnrolled subjectsEnrolled = new();
                    subjectsEnrolled.enrollmentId = enrollmentId;
                    subjectsEnrolled.subjectId = subjectGroups.ElementAt(index).SubjectId;

                    db.SubjectsEnrolled.Add(subjectsEnrolled);
                }

                if(db.SaveChanges() >= 0)
                {
                    SuccessDialog.ShowMesage("Successfully updated!");
                    this.Close();
                }
            }

            
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubjects();
        }
    }
}
