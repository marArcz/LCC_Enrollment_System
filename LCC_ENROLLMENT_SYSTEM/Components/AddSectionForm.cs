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
    public partial class AddSectionForm : Form
    {
        private List<GradeLevel> GradeLevels;
        public AddSectionForm()
        {
            InitializeComponent();
            LoadGradeLevels();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDbContext db = new();
            string section = textBoxName.Texts;
            int gradeLevelId = GradeLevels.ElementAt(comboBoxGradeLevel.SelectedIndex).Id;
            var newSection = new Section() { Name = section, GradeLevelId = gradeLevelId };
            db.Sections.Add(newSection);

            if(db.SaveChanges() > 0)
            {
                SuccessDialog.ShowMesage("Successfully added new section!");
                this.Close();
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            textBoxName.Texts = "";
            if (comboBoxGradeLevel.Items.Count > 0) comboBoxGradeLevel.SelectedIndex = 0;
        }
    }
}
