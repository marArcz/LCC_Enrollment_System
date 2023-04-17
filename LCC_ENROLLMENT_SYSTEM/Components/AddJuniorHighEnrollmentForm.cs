﻿using LCC_ENROLLMENT_SYSTEM.Data;
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
    public partial class AddJuniorHighEnrollmentForm : Form
    {
        private int SchoolLevelId;
        List<GradeLevel> gradeLevels;
        List<Section> sections;
        List<Student> students;
        List<SubjectGroup> subjectGroups;
        List<SchoolYear> schoolYears;
        int studentId = 0;

        public AddJuniorHighEnrollmentForm()
        {
            InitializeComponent();
            AppDbContext db = new();
            SchoolLevelId = db.SchoolLevels.Where(s => s.Description.ToLower().Equals("junior highschool")).Select(s => s.Id).First();
            LoadGradeLevels();
            LoadSections();
            LoadSubjects();
            LoadStudents();
            LoadSchoolYears();
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

        private void LoadStudents()
        {
            AppDbContext db = new();
            students = db.Students
                .Where(s => s.is_deleted == 0 && (s.firstname.Contains(textBoxSearch.Text) || s.lastname.Contains(textBoxSearch.Text) || s.student_id.Contains(textBoxSearch.Text)))
                .ToList();
            dataGridViewStudents.Rows.Clear();

            foreach (Student student in students)
            {
                dataGridViewStudents.Rows.Add(
                    student.id,
                    student.student_id,
                    student.firstname + " " + student.lastname
                );
            }

            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                studentId = (int)dataGridViewStudents.SelectedRows[0].Cells["id"].Value;
                string fullname = (string)dataGridViewStudents.SelectedRows[0].Cells["fullname"].Value;
                textBoxName.Text = fullname;
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
            gradeLevels = db.GradeLevels.Where(g => g.Level >=7 && g.Level <= 10).ToList();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (studentId == 0)
            {
                MessageDialog.ShowMessage("Please select a student");
                return;
            }
            else if (comboBoxLevel.SelectedItem == null)
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
            else if(checkedListSubjects.CheckedItems.Count == 0)
            {
                MessageDialog.ShowMessage("Please select one subject or more");
                return;
            }

            AppDbContext db = new();
            // add new enrollment
            Enrollment enrollment = new();
            enrollment.sectionId = sections.ElementAt(comboBoxSection.SelectedIndex).Id;
            enrollment.gradeLevelId = gradeLevels.ElementAt(comboBoxLevel.SelectedIndex).Id;
            enrollment.studentId = this.studentId;
            enrollment.schoolLevelId = SchoolLevelId;
            enrollment.schoolYearId = schoolYears.ElementAt(comboBoxSchoolYears.SelectedIndex).Id;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadStudents();
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
