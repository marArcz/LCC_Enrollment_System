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
    public partial class AddElementaryEnrollment : Form
    {
        List<Subject> subjects;
        List<GradeLevel> gradeLevels;
        List<Section> sections;
        List<Student> students;
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
            students = db.Students.Where(s => s.is_deleted == 0).ToList();
            dataGridViewStudents.Rows.Clear();
            
            foreach(Student student in students) {
                dataGridViewStudents.Rows.Add(
                    student.id,
                    student.student_id,
                    student.firstname + " " + student.lastname
                );
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
            var elementaryLevel = db.SchoolLevels.Where(s => s.Description == "Elementary").First();
            var gradeLevel = gradeLevels.ElementAt(comboBoxLevel.SelectedIndex);
            subjects = db.Subjects
                .Where(s => s.Level == gradeLevel.Level)
                .ToList();
            checkedListSubjects.Items.Clear();
            foreach (var item in subjects)
            {
                checkedListSubjects.Items.Add(item);
            }
        }
    }
}
