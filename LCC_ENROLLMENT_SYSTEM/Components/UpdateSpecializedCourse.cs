using LCC_ENROLLMENT_SYSTEM.Data;
using LCC_ENROLLMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class UpdateSpecializedCourse : Form
    {
        int id;
        public UpdateSpecializedCourse(int id)
        {
            InitializeComponent();
            this.id = id;
            LoadData();
        }

        private void LoadData()
        {
            AppDbContext db = new();
            var specializedCourse = db.SpecializedCourses.Find(id);

            textBoxName.Texts = specializedCourse.Name;
            textBoxDescription.Texts = specializedCourse.Description;
        }

        private void formFooter1_onBtnSaveClicked(object sender, EventArgs e)
        {
            AppDbContext db = new();
            var specializedCourse = db.SpecializedCourses.Find(id);
            specializedCourse.Name = textBoxName.Texts;
            specializedCourse.Description = textBoxDescription.Texts;
            
            if(db.SaveChanges() >= 0)
            {
                SuccessDialog.ShowMesage("Successfully updated!");
                this.Close();
            }
        }

        private void formFooter1_onBtnCancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
