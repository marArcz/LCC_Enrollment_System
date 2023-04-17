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
    public partial class UpdateSeniorHighEnrollment : Form
    {
        private int SchoolLevelId;
        List<GradeLevel> gradeLevels;
        List<Section> sections;
        List<Student> students;
        List<SubjectGroup> subjectGroups;
        List<SubjectsEnrolled> subjectsEnrolled;
        List<SchoolYear> schoolYears;
        List<SpecializedCourse> SpecializedCourses;
        Enrollment enrollment;
        List<Track> Tracks;
        List<Strand> Strands;

        int enrollmentId = 0;
        public UpdateSeniorHighEnrollment(int id)
        {
            InitializeComponent();
            AppDbContext db = new();
            enrollmentId = id;
            enrollment = db.Enrollments.Find(id);

            LoadGradeLevels();
            LoadSections();
            LoadSchoolYears();
            LoadTracks();
            LoadStrands();
            LoadCourses();
            LoadData();
            LoadSubjects();

        }

        private void LoadData()
        {
            AppDbContext db = new();

            textBoxName.Text = enrollment.student.firstname + " " + enrollment.student.lastname;
            comboBoxLevel.SelectedIndex = gradeLevels.IndexOf(gradeLevels.Where(g => g.Id == enrollment.gradeLevelId).First());
            comboBoxSection.SelectedIndex = sections.IndexOf(sections.Where(s => s.Id == enrollment.sectionId).First());
            comboBoxTracks.SelectedIndex = Tracks.IndexOf(Tracks.Where(s => s.Id == enrollment.trackId).First());
            comboBoxStrands.SelectedIndex = Strands.IndexOf(Strands.Where(s => s.Id == enrollment.strandId).First());
            comboBoxCourses.SelectedIndex = SpecializedCourses.IndexOf(SpecializedCourses.Where(s => s.Id == enrollment.specializedCourseId).First());
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

        private void LoadCourses()
        {
            AppDbContext db = new();
            SpecializedCourses = db.SpecializedCourses.ToList();
            foreach (var item in SpecializedCourses)
            {
                comboBoxCourses.Items.Add(item.Name);
            }

            if (comboBoxCourses.Items.Count > 0) comboBoxCourses.SelectedIndex = 0;
        }

        private void LoadTracks()
        {
            AppDbContext db = new();
            Tracks = db.Tracks.ToList();

            foreach (var item in Tracks)
            {
                comboBoxTracks.Items.Add(item.Name);
            }

            if (comboBoxTracks.Items.Count > 0) comboBoxTracks.SelectedIndex = 0;
        }
        private void LoadStrands()
        {
            AppDbContext db = new();
            int trackId = Tracks.ElementAt(comboBoxTracks.SelectedIndex).Id;
            Strands = db.Strands.Where(s => s.TrackId == trackId).ToList();

            foreach (var item in Strands)
            {
                comboBoxStrands.Items.Add(item.Name);
            }

            if (comboBoxStrands.Items.Count > 0) comboBoxStrands.SelectedIndex = 0;
        }

        private void LoadGradeLevels()
        {
            AppDbContext db = new();
            comboBoxLevel.Items.Clear();
            gradeLevels = db.GradeLevels.ToList();
            foreach (var item in gradeLevels)
            {
                comboBoxLevel.Items.Add(item.Level);
            }

            if (comboBoxLevel.Items.Count > 0) comboBoxLevel.SelectedIndex = 0;
        }

        private void LoadSections()
        {
            AppDbContext db = new();
            comboBoxSection.Items.Clear();
            int gradeLevelId = gradeLevels.ElementAt(comboBoxLevel.SelectedIndex).Id;

            sections = db.Sections.Where(s => s.GradeLevelId == gradeLevelId).OrderByDescending(s => s.Id).ToList();
            // TODO: 
            foreach (var item in sections)
            {
                comboBoxSection.Items.Add(item.Name);
            }

            if (comboBoxSection.Items.Count > 0) comboBoxSection.SelectedIndex = 0;

        }

        private void LoadSubjects()
        {
            AppDbContext db = new();
            subjectsEnrolled = db.SubjectsEnrolled.Where(s => s.enrollmentId == enrollmentId).ToList();

            checkedListSubjects.Items.Clear();
            int gradeLevelId = gradeLevels.ElementAt(comboBoxLevel.SelectedIndex).Id;

            subjectGroups = db.SubjectGroups.Include(s => s.SubjectModel).Where(s => s.Level == Convert.ToInt32(comboBoxLevel.Text)).ToList();

            foreach (var item in subjectGroups)
            {
                bool isChecked = subjectsEnrolled.Where(s => s.subjectId == item.SubjectId).Any();
                checkedListSubjects.Items.Add(item.SubjectModel.Name,isChecked);
            }

            if (comboBoxSection.Items.Count > 0) comboBoxSection.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            else if (comboBoxTracks.SelectedItem == null)
            {
                MessageDialog.ShowMessage("Please select a track");
                return;
            }
            else if (comboBoxStrands.SelectedItem == null)
            {
                MessageDialog.ShowMessage("Please select a strand");
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
            enrollment.schoolLevelId = SchoolLevelId;
            enrollment.trackId = Tracks.ElementAt(comboBoxTracks.SelectedIndex).Id;
            enrollment.strandId = Tracks.ElementAt(comboBoxStrands.SelectedIndex).Id;
            enrollment.specializedCourseId = SpecializedCourses.ElementAt(comboBoxCourses.SelectedIndex).Id;

            db.SaveChanges();

            db.SubjectsEnrolled.Where(s => s.enrollmentId == enrollmentId).ToList().ForEach(s => db.SubjectsEnrolled.Remove(s));
            
            db.SaveChanges();

            // add new subjects enrolled
            SubjectsEnrolled sb;

            foreach (int index in checkedListSubjects.CheckedIndices)
            {
                sb = new();
                sb.subjectId = subjectGroups.ElementAt(index).SubjectId;
                sb.enrollmentId = enrollment.id;
                db.SubjectsEnrolled.Add(sb);
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
            if (comboBoxCourses.Items.Count > 0) comboBoxCourses.SelectedIndex = 0;
            if (comboBoxStrands.Items.Count > 0) comboBoxStrands.SelectedIndex = 0;
            if (comboBoxTracks.Items.Count > 0) comboBoxTracks.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
    }
}
