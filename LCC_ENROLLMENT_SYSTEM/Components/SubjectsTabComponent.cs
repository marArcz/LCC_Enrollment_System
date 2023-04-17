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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LCC_ENROLLMENT_SYSTEM.Components
{
    public partial class SubjectsTabComponent : CustomTab
    {

        private enum FetchDirection
        {
            forward,
            backward,
        }
        private int numOfRowsToDisplay = 10;
        private int lastId = 0;
        private FetchDirection dir = FetchDirection.forward;
        private List<Subject> rows;
        public SubjectsTabComponent()
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

                    rows = rows.OrderBy(s => s.id).ToList();
                    lastId = rows.Last().id;
                }
                rows = db.Subjects
                    .Include(s => s.subjectGroups)
                    .Where(s => s.id > lastId && (s.Name.Contains(textBoxSearch.Text) || s.Description.Contains(textBoxSearch.Text)))
                    .Take(numOfRowsToDisplay)
                    .ToList();

            }
            else
            {
                if (movePagination && rows.Any())
                {
                    lastId = rows.First().id;
                }
                rows = db.Subjects
                    .Include(s => s.subjectGroups)
                .Where(s => s.id < lastId && (s.Name.Contains(textBoxSearch.Text) || s.Description.Contains(textBoxSearch.Text)))
                    .OrderByDescending(s => s.id)
                    .Take(numOfRowsToDisplay)
                    .ToList();

                rows = rows.OrderBy(s => s.id).ToList();
            }

            if (rows.Any())
            {

                int nextId = rows.Last().id;
                int prevId = rows.First().id;
                int prevRowsCount = db.Subjects.Include(s => s.subjectGroups).Where(s => s.id < prevId && (s.Name.Contains(textBoxSearch.Text) || s.Description.Contains(textBoxSearch.Text))).Count();
                int nextRowsCount = db.Subjects.Include(s => s.subjectGroups).Where(s => s.id > nextId && (s.Name.Contains(textBoxSearch.Text) || s.Description.Contains(textBoxSearch.Text))).Count();

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

        private void DisplayRows(List<Subject> rows)
        {
            dataGridView.Rows.Clear();
            rows = rows.OrderBy(s => s.Level).ToList();

            foreach (var row in rows)
            {
                var levels = "";
                foreach (var item in row.subjectGroups)
                {
                    levels += item.Level + ",";
                }
                levels = levels.Substring(0,levels.Length - 1);

                dataGridView.Rows
                    .Add(
                        row.id,
                        row.Name,
                        row.Description,
                        levels
                    );

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddSubjectForm();
            addForm.ShowDialog();
            LoadRows(); 
        }

        private void SubjectsTabComponent_Load(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRows();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dir = FetchDirection.forward;
            LoadRows(true);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dir = FetchDirection.backward;
            LoadRows(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.SelectedRows[0].Cells["id"].Value;

                UpdateSubjectForm updateSubjectForm = new(id);
                updateSubjectForm.ShowDialog();
                LoadRows();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = dataGridView.SelectedRows.Count == 1;
            btnDelete.Enabled = dataGridView.SelectedRows.Count > 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete selected subject(s)?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                AppDbContext db = new();
                
                var selectedRows = dataGridView.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    int id = (int)row.Cells["id"].Value;
                    var subject = db.Subjects.Find(id);
                    if(subject != null) db.Subjects.Remove(subject);
                }
                if(db.SaveChanges() <= 0)
                {
                    MessageBox.Show("Something went wrong!", "An error occured please try again later.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoadRows();
                }
                
            }
        }

        private void OnDbChange(object? sender, Microsoft.EntityFrameworkCore.ChangeTracking.EntityStateChangedEventArgs e)
        {
            LoadRows();
        }
    }
}
