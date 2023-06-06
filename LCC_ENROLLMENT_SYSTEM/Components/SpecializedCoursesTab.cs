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
    public partial class SpecializedCoursesTab : CustomTab
    {
        private enum FetchDirection
        {
            forward,
            backward,
        }
        private int numOfRowsToDisplay = 10;
        private int lastId = 0;
        private FetchDirection dir = FetchDirection.forward;
        private List<SpecializedCourse> rows;

        public SpecializedCoursesTab()
        {
            InitializeComponent();
        }

        public void LoadRows(bool movePagination = false)
        {
            AppDbContext db = new();

            if (dir == FetchDirection.forward)
            {
                if (movePagination && rows.Any())
                {

                    rows = rows.OrderBy(s => s.Id).ToList();
                    lastId = rows.Last().Id;
                }
                rows = db.SpecializedCourses
                    .Where(s => s.Id > lastId && (s.Name.Contains(textBoxSearch.Text) || s.Description.Contains(textBoxSearch.Text)))
                    .Take(numOfRowsToDisplay)
                    .ToList();

            }
            else
            {
                if (movePagination && rows.Any())
                {
                    lastId = rows.First().Id;
                }
                rows = db.SpecializedCourses
                .Where(s => s.Id < lastId && (s.Name.Contains(textBoxSearch.Text) || s.Description.Contains(textBoxSearch.Text)))
                    .OrderByDescending(s => s.Id)
                    .Take(numOfRowsToDisplay)
                    .ToList();

                rows = rows.OrderBy(s => s.Id).ToList();
            }

            if (rows.Any())
            {

                int nextId = rows.Last().Id;
                int prevId = rows.First().Id;
                int prevRowsCount = db.SpecializedCourses.Where(s => s.Id < prevId && (s.Name.Contains(textBoxSearch.Text) || s.Description.Contains(textBoxSearch.Text))).Count();
                int nextRowsCount = db.SpecializedCourses.Where(s => s.Id > nextId && (s.Name.Contains(textBoxSearch.Text) || s.Description.Contains(textBoxSearch.Text))).Count();

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

        private void DisplayRows(List<SpecializedCourse> rows)
        {
            dataGridView.Rows.Clear();
            rows = rows.OrderBy(s => s.Id).ToList();

            foreach (var row in rows)
            {
                dataGridView.Rows
                    .Add(
                        row.Id,
                        row.Name,
                        row.Description
                    );

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSpecializedCourse addSpecializedCourse = new();
            addSpecializedCourse.Show();
            LoadRows();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRows();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                int id = (int) dataGridView.SelectedRows[0].Cells["id"].Value;
                UpdateSpecializedCourse updateSpecializedCourse = new(id);
                updateSpecializedCourse.ShowDialog();
            }
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
                    var specializeCourse = db.SpecializedCourses.Find(id);
                    if (specializeCourse != null) db.SpecializedCourses.Remove(specializeCourse);
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

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = dataGridView.SelectedRows.Count == 1;
            btnDelete.Enabled = dataGridView.SelectedRows.Count > 0;
        }
    }
}
