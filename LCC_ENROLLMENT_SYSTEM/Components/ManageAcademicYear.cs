using LCC_ENROLLMENT_SYSTEM.Data;
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
    public partial class ManageAcademicYear : Form
    {
        public ManageAcademicYear()
        {
            InitializeComponent();
            LoadRows();
        }

        public void LoadRows()
        {
            AppDbContext db = new();
            var academicYears = db.SchoolYears.ToList();
            dataGridView.Rows.Clear();
            academicYears.ForEach(a =>
            {
                dataGridView.Rows.Add(
                    a.Id,
                    a.From,
                    a.To
                );
            });
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = dataGridView.SelectedRows.Count == 1;
            btnDelete.Enabled = dataGridView.SelectedRows.Count > 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                int id = (int) dataGridView.SelectedRows[0].Cells["id"].Value;
                UpdateAcademicYearForm updateAcademicYear = new(id);
                updateAcademicYear.ShowDialog();

                LoadRows();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAcademicYearForm addAcademicYear = new();
            addAcademicYear.ShowDialog();
            LoadRows();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete selected row(s)?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AppDbContext db = new();

                var selectedRows = dataGridView.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    int id = (int)row.Cells["id"].Value;
                    var schoolYear = db.SchoolYears.Find(id);
                    if (schoolYear != null) db.SchoolYears.Remove(schoolYear);
                }
                if (db.SaveChanges() <= 0)
                {
                    MessageBox.Show("Something went wrong!", "An error occured please try again later.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoadRows();
                }
            }
        }
    }
}
