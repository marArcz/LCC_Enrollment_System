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
    public partial class UpdateSectionForm : Form
    {
        private Section sectionToEdit;
        private List<GradeLevel> GradeLevels;
        public UpdateSectionForm()
        {
            InitializeComponent();
        } 
        public UpdateSectionForm(int id)
        {
            InitializeComponent();
            AppDbContext db = new();
            this.sectionToEdit = db.Sections.Find(id);
            LoadGradeLevels();
            LoadData();
        }

        private void LoadGradeLevels()
        {
            AppDbContext db = new();
            GradeLevels = db.GradeLevels.ToList();
            comboBoxGradeLevel.Items.Clear();
            foreach (var item in GradeLevels)
            {
                comboBoxGradeLevel.Items.Add("Grade " + item.Level);
            }
        }

        private void LoadData()
        {
            textBoxName.Texts = sectionToEdit.Name;
            comboBoxGradeLevel.SelectedIndex = GradeLevels.IndexOf(GradeLevels.Find(g => g.Id == sectionToEdit.GradeLevelId));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDbContext db = new();
            var section = db.Sections.Find(sectionToEdit.Id);
            section.Name = textBoxName.Texts;
            section.GradeLevelId = GradeLevels.ElementAt(comboBoxGradeLevel.SelectedIndex).Id;

            if(section == null)
            {
                MessageBox.Show("Cannot find section to edit!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (db.SaveChanges() < 0)
            {
                MessageBox.Show("An Error occured please try again later.","Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show("Success", "Successfully updated section", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SuccessDialog.ShowMesage("Successfully updated section!");
                this.Close();
            }
            
        }
    }
}
