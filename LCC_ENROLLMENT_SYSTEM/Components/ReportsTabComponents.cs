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
    public partial class ReportsTabComponents : UserControl
    {
        List<GradeLevel> GradeLevels;
        List<Section> Sections;
        List<Enrollment> Enrollments;
        List<SchoolYear> SchoolYears;
        int from = 2000;
        int to = 2001;

        public ReportsTabComponents()
        {
            InitializeComponent();
            from = DateTime.Now.Year - 1;
            to = DateTime.Now.Year;
            textSchoolYearChart.Text = $"{from}-{to}";

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("ListTab");
            LoadAll();
        }

        private void customLabel6_Click(object sender, EventArgs e)
        {

        }
        public void LoadAll()
        {
            LoadSchoolYears();
            LoadGradeLevels();
            LoadSections();
            LoadRows();
        }

        public void LoadGradeLevels()
        {
            AppDbContext db = new();
            //get levels
            GradeLevels = db.GradeLevels.ToList();
            comboBoxGradeLevel.Items.Clear();

            GradeLevels.ForEach(g =>
            {
                comboBoxGradeLevel.Items.Add(g.Level);
            });
            if (comboBoxGradeLevel.Items.Count > 0) comboBoxGradeLevel.SelectedIndex = 0;
        }

        public void LoadSections()
        {
            AppDbContext db = new();
            //get levels
            int gradeLevelId = GradeLevels.ElementAt(comboBoxGradeLevel.SelectedIndex).Id;
            Sections = db.Sections.Where(s => s.GradeLevelId == gradeLevelId).ToList();
            comboBoxSection.Items.Clear();

            Sections.ForEach(s =>
            {
                comboBoxSection.Items.Add(s.Name);
            });
            if (comboBoxSection.Items.Count > 0) comboBoxSection.SelectedIndex = 0;

        }

        public void LoadSchoolYears()
        {
            AppDbContext db = new();
            //get levels
            SchoolYears = db.SchoolYears.ToList();
            comboBoxSchoolYear.Items.Clear();

            SchoolYears.ForEach(s =>
            {
                comboBoxSchoolYear.Items.Add(s.ToString());
            });
            if (comboBoxSchoolYear.Items.Count > 0) comboBoxSchoolYear.SelectedIndex = 0;

        }

        public void LoadEnrollments()
        {
            AppDbContext db = new();
            int sectionId = Sections.ElementAt(comboBoxSection.SelectedIndex).Id;
            int schoolYearId = SchoolYears.ElementAt(comboBoxSchoolYear.SelectedIndex).Id;
            Enrollments = db.Enrollments
                .Include(e => e.student)
                .Where(e => e.sectionId == sectionId && e.schoolYearId == schoolYearId)
                .ToList();
        }

        public void LoadRows()
        {
            LoadEnrollments();
            int index = 0;

            var level = comboBoxGradeLevel.Text;
            var section = comboBoxSection.Text;
            var schoolYear = comboBoxSchoolYear.Text;
            textGradeLevelTotal.Text = textGradeLevel.Text = $"Grade {level}";
            textSectionTotal.Text = textSection.Text = section;
            textSchoolYearTotal.Text = textSchoolYear.Text = schoolYear;

            textTotalStudentTotal.Text = textTotalStudents.Text = Enrollments.Count().ToString();

            dataGridView.Rows.Clear();
            Enrollments.ForEach((e) =>
            {
                dataGridView.Rows.Add(
                   ++index,
                   e.student.lastname,
                   e.student.firstname,
                   (e.student.middlename.Length > 0 ? e.student.middlename[0]:""),
                   $"Grade {level}",
                   section
                );
            });
        }

        private void comboBoxGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSections();
            LoadRows();
        }

        private void comboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Sections != null)
            {
                LoadRows();
            }
        }

        private void btnTotalEnrollees_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("ListTab");
            LoadAll();
        }

        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRows();
        }

        private void btnTotalEnrollees_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectTab("totalTab");
            LoadAll();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            LoadAll();
            LoadChart();
            tabControl.SelectTab("chartTab");
        }

        private void LoadChart()
        {

            AppDbContext db = new();
            
            var schoolYears = db.SchoolYears.Where(s => s.From >= from && s.To <= to).ToList();

            chart.Series["Enrollees"].Points.Clear();

            schoolYears.ForEach(s =>
            {
                int enrollees = db.Enrollments.Where(e => e.schoolYearId == s.Id).Count();
                chart.Series["Enrollees"].Points.AddXY(s.ToString(),enrollees);
            });
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeSchoolYear changeSchoolYear = new(ref from, ref to);
            changeSchoolYear.ShowDialog();

            from = changeSchoolYear.From;
            to = changeSchoolYear.To;

            textSchoolYearChart.Text = $"{from}-{to}";
            LoadChart();
        }
    }
}
