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
    public partial class UpdateSubjectForm : Form
    {
        public Subject subject;
        private List<GradeLevel> GraveLevels;
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
            comboBoxLevel.SelectedIndex = comboBoxLevel.Items.IndexOf("Grade "+subject.Level);
        }

        private void LoadGradeLevels()
        {
            AppDbContext db = new();
            GraveLevels = db.GradeLevels.ToList();
            comboBoxLevel.Items.Clear();
            foreach ( var item in GraveLevels )
            {
                comboBoxLevel.Items.Add("Grade " + item.Level);
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
            AppDbContext db = new();
      

            var curSubject = db.Subjects.Find(subject.id);
            curSubject.Name = textBoxSubject.Texts;
            curSubject.Description = textBoxDescription.Texts;
            curSubject.Level = GraveLevels.ElementAt(comboBoxLevel.SelectedIndex).Level;

            if (db.SaveChanges() > 0)
            {
                SuccessDialog.ShowMesage("Successfully updated subject!");
                this.Close();
            }
        }
    }
}
