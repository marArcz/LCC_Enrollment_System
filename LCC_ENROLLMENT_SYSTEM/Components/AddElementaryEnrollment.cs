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
    public partial class AddElementaryEnrollment : Form
    {
        List<GradeLevel> gradeLevels;
        List<Section> sections;
        List<Student> students;
        List<SubjectGroup> subjectGroups;

        int studentId = 0;
        public AddElementaryEnrollment()
        {
            InitializeComponent();
            LoadGradeLevels();
            LoadSections();
            LoadSubjects();
            LoadStudents();
        }
        
        private void LoadStudents()
        {
            AppDbContext db = new();
            students = db.Students
                .Where(s => s.is_deleted == 0 && (s.firstname.Contains(textBoxSearch.Text) || s.lastname.Contains(textBoxSearch.Text)))
                .ToList();
            dataGridViewStudents.Rows.Clear();
            
            foreach(Student student in students) {
                dataGridViewStudents.Rows.Add(
                    student.id,
                    student.student_id,
                    student.firstname + " " + student.lastname
                );
            }

            if(dataGridViewStudents.SelectedRows.Count > 0)
            {
                studentId = (int)dataGridViewStudents.SelectedRows[0].Cells["id"].Value;
                string fullname = (string)dataGridViewStudents.SelectedRows[0].Cells["fullname"].Value;
                textBoxName.Text = fullname;
            }
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
            int gradeLevel = Convert.ToInt32(comboBoxLevel.Text);
            subjectGroups = db.SubjectGroups.Include(s => s.SubjectModel).Where(s => s.Level == Convert.ToInt32(comboBoxLevel.Text)).ToList();

            checkedListSubjects.Items.Clear();
            foreach (var item in subjectGroups)
            {
                checkedListSubjects.Items.Add(item.SubjectModel.Name);
            }
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewStudents.SelectedRows.Count > 0)
            {
                studentId = (int)dataGridViewStudents.SelectedRows[0].Cells["id"].Value;
                string fullname = (string)dataGridViewStudents.SelectedRows[0].Cells["fullname"].Value;
                textBoxName.Text = fullname;
                checkedListSubjects.ClearSelected();
            }
        }

        private void textBoxSearch__TextChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadStudents();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }

        private void clear()
        {
            checkedListSubjects.ClearSelected();
            if(comboBoxLevel.Items.Count > 0) comboBoxLevel.SelectedIndex = 0;
            if(comboBoxSection.Items.Count > 0) comboBoxSection.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDbContext db = new();
            var elementary = db.SchoolLevels.Where(s => s.Description.ToLower().Equals("elementary")).First();
            // add new enrollment
            Enrollment enrollment = new();
            enrollment.sectionId = sections.ElementAt(comboBoxSection.SelectedIndex).Id;
            enrollment.gradeLevelId = gradeLevels.ElementAt(comboBoxLevel.SelectedIndex).Id;
            enrollment.studentId = this.studentId;
            enrollment.schoolLevelId = elementary.Id;

            db.Enrollments.Add(enrollment);

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
                SuccessDialog.ShowMesage("Successfully enrolled!");

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
