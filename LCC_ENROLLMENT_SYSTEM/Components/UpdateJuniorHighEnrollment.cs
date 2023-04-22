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
    public partial class UpdateJuniorHighEnrollment : Form
    {
        private int enrollmentId;
        List<GradeLevel> gradeLevels;
        List<Section> sections;
        List<Student> students;
        List<SubjectGroup> subjectGroups;
        List<SubjectsEnrolled> subjectsEnrolled;
        List<SchoolYear> schoolYears;
        Enrollment enrollment;
        public UpdateJuniorHighEnrollment(int id)
        {
            InitializeComponent();
            AppDbContext db = new();
            enrollmentId = id;
            enrollment = db.Enrollments
                            .Include(e => e.student)
                            .Where(e => e.id == id)
                            .First();

            LoadGradeLevels();
            LoadSections();
            LoadSchoolYears();
            LoadData();
            LoadSubjects();
        }
        private void LoadData()
        {
            AppDbContext db = new();

            textBoxName.Text = enrollment.student.firstname + " " + enrollment.student.lastname;
            comboBoxLevel.SelectedIndex = gradeLevels.IndexOf(gradeLevels.Where(g => g.Id == enrollment.gradeLevelId).First());
            comboBoxSection.SelectedIndex = sections.IndexOf(sections.Where(s => s.Id == enrollment.sectionId).First());
        }
        private void LoadSchoolYears()
        {
            AppDbContext db = new();
            schoolYears = db.SchoolYears.ToList();

            foreach (SchoolYear item in schoolYears)
            {
                comboBoxSchoolYears.Items.Add($"{item.From}-{item.To}");
            }

            if (comboBoxSchoolYears.Items.Count > 0) comboBoxSchoolYears.SelectedIndex = 0;
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
            gradeLevels = db.GradeLevels.Where(g => g.Level >= 7 && g.Level <= 10).ToList();
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
            foreach (var item in subjectGroups)
            {
                bool isChecked = subjectsEnrolled.Where(s => s.subjectId == item.SubjectId).ToList().Any();
                checkedListSubjects.Items.Add(item.SubjectModel.Name,isChecked);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (comboBoxLevel.SelectedItem == null)
            {
                MessageDialog.ShowMessage("Please select a level");
                return;
            }
            else if (comboBoxSchoolYears.SelectedItem == null)
            {
                MessageDialog.ShowMessage("Please select a school year");
                return;
            }
            else if (comboBoxSection.SelectedItem == null)
            {
                MessageDialog.ShowMessage("Please select a section");
                return;
            }
            else if (checkedListSubjects.CheckedItems.Count == 0)
            {
                MessageDialog.ShowMessage("Please select one subject or more");
                return;
            }


            AppDbContext db = new();
            // add new enrollment
            Enrollment enrollment = this.enrollment;
            enrollment.sectionId = sections.ElementAt(comboBoxSection.SelectedIndex).Id;
            enrollment.gradeLevelId = gradeLevels.ElementAt(comboBoxLevel.SelectedIndex).Id;

            db.SaveChanges();

            db.SubjectsEnrolled.Where(s => s.enrollmentId == enrollment.id).ToList().ForEach(s => db.SubjectsEnrolled.Remove(s));
            db.SaveChanges();
            // add new subjects enrolled
            SubjectsEnrolled subjectsEnrolled;

            foreach (int index in checkedListSubjects.CheckedIndices)
            {
                subjectsEnrolled = new();
                subjectsEnrolled.subjectId = subjectGroups.ElementAt(index).SubjectId;
                subjectsEnrolled.enrollmentId = enrollment.id;
                db.SubjectsEnrolled.Add(subjectsEnrolled);
            }

            if (db.SaveChanges() >= 0)
            {
                SuccessDialog.ShowMesage("Successfully added!");
                this.Clear();
                this.Close();
            }

        }
        private void Clear()
        {
            checkedListSubjects.ClearSelected();
            if (comboBoxLevel.Items.Count > 0) comboBoxLevel.SelectedIndex = 0;
            if (comboBoxSection.Items.Count > 0) comboBoxSection.SelectedIndex = 0;
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSections();
            LoadSubjects();
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
    }
}
