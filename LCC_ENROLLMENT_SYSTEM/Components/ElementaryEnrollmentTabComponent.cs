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
    public partial class ElementaryEnrollmentTabComponent : CustomTab
    {
        private enum FetchDirection
        {
            forward,
            backward,
        }
        private int numOfRowsToDisplay = 10;
        private int lastId = 0;
        private FetchDirection dir = FetchDirection.forward;
        private List<Enrollment> rows;

        public ElementaryEnrollmentTabComponent()
        {
            InitializeComponent();
        }
        public void LoadRows(bool movePagination = false)
        {
            AppDbContext db = new();
            int elementaryId = db.SchoolLevels.Where(s => s.Description.ToLower().Equals("elementary")).First().Id;
            if (dir == FetchDirection.forward)
            {
                if (movePagination && rows.Any())
                {

                    rows = rows.OrderBy(s => s.id).ToList();
                    lastId = rows.Last().id;
                }
                rows = db.Enrollments
                    .Include(e => e.student)
                    .Include(e => e.gradeLevel)
                    .Include(e => e.section)
                    .Include(e => e.adviser)
                    .Where(e => e.id > lastId && e.schoolLevelId == elementaryId && (e.student.lastname.Contains(textBoxSearch.Text) || e.student.firstname.Contains(textBoxSearch.Text)))
                    .Take(numOfRowsToDisplay)
                    .ToList();

            }
            else
            {
                if (movePagination && rows.Any())
                {
                    lastId = rows.First().id;
                }
                rows = db.Enrollments
                    .Include(e => e.student)
                    .Include(e => e.section)
                    .Include(e => e.gradeLevel)
                    .Include(e => e.adviser)
                    .Where(e => e.id > lastId && e.schoolLevelId == elementaryId && (e.student.lastname.Contains(textBoxSearch.Text) || e.student.firstname.Contains(textBoxSearch.Text)))
                    .OrderByDescending(s => s.id)
                    .Take(numOfRowsToDisplay)
                    .ToList();

                rows = rows.OrderBy(s => s.id).ToList();
            }

            if (rows.Any())
            {

                int nextId = rows.Last().id;
                int prevId = rows.First().id;
                int prevRowsCount = db.Enrollments.Include(e => e.section).Include(e => e.student).Include(e => e.gradeLevel).Where(e => e.id < prevId && e.schoolLevelId == elementaryId && (e.student.firstname.Contains(textBoxSearch.Text) || e.student.lastname.Contains(textBoxSearch.Text))).Count();
                int nextRowsCount = db.Enrollments.Include(e => e.section).Include(e => e.student).Include(e => e.gradeLevel).Where(e => e.id > nextId && e.schoolLevelId == elementaryId && (e.student.firstname.Contains(textBoxSearch.Text) || e.student.lastname.Contains(textBoxSearch.Text))).Count();

                btnNext.Enabled = nextRowsCount > 0;
                btnPrev.Enabled = prevRowsCount > 0;
            }
            else
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
            }
            DisplayRows(rows);
        }

        private void DisplayRows(List<Enrollment> rows)
        {
            dataGridView.Rows.Clear();
            rows = rows.OrderBy(e => e.id).ToList();
            foreach (var row in rows)
            {
                dataGridView.Rows
                    .Add(
                        row.id,
                        row.student.firstname + " " + row.student.middlename + " " + row.student.lastname,
                        row.section.Name,
                        row.adviser.Firstname + " " + row.adviser.Lastname,
                        row.gradeLevel.Level
                    );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddElementaryEnrollment addElementaryEnrollment = new();
            addElementaryEnrollment.ShowDialog();
            LoadRows();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRows();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = dataGridView.SelectedRows.Count == 1;
            btnDelete.Enabled = dataGridView.SelectedRows.Count > 0;
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
                    var enrollment = db.Enrollments.Find(id);
                    if (enrollment != null) db.Enrollments.Remove(enrollment);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                int id = (int) dataGridView.SelectedRows[0].Cells["id"].Value;
                UpdateElementaryEnrollment updateElementary = new(id);
                updateElementary.ShowDialog();

                LoadRows();
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadRows();
        }
    }
}
