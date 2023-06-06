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
        public int subjectId;
        private List<GradeLevel> GradeLevels;
        private List<SubjectGroup> SubjectGroups;
        public UpdateSubjectForm()
        {
            InitializeComponent();
        }

        public UpdateSubjectForm(int id)
        {
            InitializeComponent();
            AppDbContext db = new();
            subjectId = id;
            var subject = db.Subjects.Find(id);
            SubjectGroups = db.SubjectGroups.Where(s => s.SubjectId == id).ToList();

            textBoxSubject.Texts = subject.Name;
            timePickerFrom.Value = DateTime.Parse(subject.From);
            timePickerTo.Value = DateTime.Parse(subject.To);
            string[] days = subject.Days.Split(',');

            foreach (string day in days)
            {
                checkedListDays.SetItemChecked(checkedListDays.Items.IndexOf(day), true);
            }
            LoadGradeLevels();
        }

        private void LoadGradeLevels()
        {
            AppDbContext db = new();
            GradeLevels = db.GradeLevels.ToList();
            checkedListLevels.Items.Clear();
            foreach ( var item in GradeLevels )
            {
                var is_checked = SubjectGroups.Where(s => s.Level == item.Level).Any();
                checkedListLevels.Items.Add($"Grade {item.Level}",is_checked);
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

            if (checkedListDays.CheckedItems.Count == 0)
            {
                MessageBox.Show("You need to select a day or more!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            AppDbContext db = new();


            var curSubject = db.Subjects.Include(s => s.subjectGroups).Where(s => s.id == subjectId).First();
            curSubject.Name = textBoxSubject.Texts;
            string days = "";
            foreach (var item in checkedListDays.CheckedItems)
            {
                days += item.ToString() + ",";
            }
            days = days.Substring(0, days.Length - 1);//remove the comma at the end
            string from = timePickerFrom.Value.ToString("hh:mm");
            string to = timePickerTo.Value.ToString("hh:mm");

            curSubject.Days = days;
            curSubject.From = from;
            curSubject.To = to;

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
