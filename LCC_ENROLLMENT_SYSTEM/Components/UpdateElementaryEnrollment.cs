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
        List<SchoolYear> schoolYears;
        private int enrollmentId;
        List<Adviser> advisers;
       
        public UpdateElementaryEnrollment(int id)
        {
            InitializeComponent();
            this.enrollmentId = id;
            LoadGradeLevels();
            LoadSections();
            LoadSubjects();
            LoadSchoolYears();
            loadAdvisers();
            LoadData();

        }

        private void LoadData()
        {
            AppDbContext db = new();
            
            var enrollment = db.Enrollments
                .Include(e => e.gradeLevel)
                .Include(e => e.section)
                .Include(e => e.student)
                .Include(e => e.adviser)
                .Include(e => e.schoolYear)
                .Where(e => e.id == enrollmentId)
                .First();

            comboBoxAdvisers.SelectedIndex = advisers.IndexOf(advisers.Where(a => a.Id == enrollment.adviserId).Single());
            textBoxName.Text = enrollment.student.firstname + " " + enrollment.student.lastname;
            comboBoxLevel.SelectedIndex = gradeLevels.IndexOf(gradeLevels.Where(g => g.Id == enrollment.gradeLevelId).First());
            comboBoxSection.SelectedIndex = sections.IndexOf(sections.Where(s => s.Id == enrollment.sectionId).First());
            comboBoxSchoolYears.SelectedIndex = schoolYears.IndexOf(schoolYears.Where(s => s.Id == enrollment.schoolYearId).Single());
        }
        private void LoadSchoolYears()
        {
            AppDbContext db = new();
            schoolYears = db.SchoolYears.ToList();
            foreach (SchoolYear item in schoolYears)
            {
                comboBoxSchoolYears.Items.Add(item.ToString());
            }
        }
        private void LoadSections()
        {
            AppDbContext db = new();
            int gradeLevelId = gradeLevels.ElementAt(comboBoxLevel.SelectedIndex).Id;
            sections = db.Sections.Where(s => s.GradeLevelId == gradeLevelId).ToList();
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
            enrollment.schoolYearId = schoolYears.ElementAt(comboBoxSchoolYears.SelectedIndex).Id;
            enrollment.adviserId = advisers.ElementAt(comboBoxAdvisers.SelectedIndex).Id;
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

        private void customLabel6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            int gradeLevelId = gradeLevels.ElementAt(comboBoxLevel.SelectedIndex).Id;
            AddSectionForm addSectionForm = new(gradeLevelId);
            var result = addSectionForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadSections();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadAdvisers()
        {
            AppDbContext db = new();
            advisers = db.Advisers.ToList();
            comboBoxAdvisers.Items.Clear();

            foreach(var adviser in advisers)
            {
                comboBoxAdvisers.Items.Add(adviser.Firstname + " " + adviser.Lastname);
            }
        }

        private void btnNewAdviser_Click(object sender, EventArgs e)
        {
            AddAdviserForm addAdviserForm = new();
            addAdviserForm.ShowDialog();
            loadAdvisers();
        }
    }
}
