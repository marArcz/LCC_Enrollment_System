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
    public partial class SectionTabComponent : CustomTab
    {
        private enum FetchDirection
        {
            forward,
            backward,
        }
        private int numOfRowsToDisplay = 10;
        private int lastId = 0;
        private FetchDirection dir = FetchDirection.forward;
        private List<Section> rows;
        public SectionTabComponent()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = dataGridView.SelectedRows.Count == 1;
            btnDelete.Enabled = dataGridView.SelectedRows.Count > 0;
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
                rows = db.Sections
                    .Include(s => s.gradeLevel)
                    .Where(s => s.Id > lastId && s.Name.Contains(textBoxSearch.Text))
                    .Take(numOfRowsToDisplay)
                    .ToList();

            }
            else
            {
                if (movePagination && rows.Any())
                {
                    lastId = rows.First().Id;
                }
                rows = db.Sections
                    .Include(s => s.gradeLevel)
                    .Where(s => s.Id > lastId && s.Name.Contains(textBoxSearch.Text))
                    .OrderByDescending(s => s.Id)
                    .Take(numOfRowsToDisplay)
                    .ToList();

                rows = rows.OrderBy(s => s.Id).ToList();
            }

            if (rows.Any())
            {

                int nextId = rows.Last().Id;
                int prevId = rows.First().Id;
                int prevRowsCount = db.Sections.Where(s => s.Id > lastId && s.Name.Contains(textBoxSearch.Text)).Count();
                int nextRowsCount = db.Sections.Where(s => s.Id > lastId && s.Name.Contains(textBoxSearch.Text)).Count();

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

        private void DisplayRows(List<Section> rows)
        {
            dataGridView.Rows.Clear();
            rows = rows.OrderBy(s => s.Name).ToList();
            foreach (var row in rows)
            {
                dataGridView.Rows
                    .Add(
                        row.Id,
                        row.Name,
                        "Grade " + row.gradeLevel.Level
                    );
            }
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
            try
            {
                int id = (int) dataGridView.SelectedRows[0].Cells["id"].Value;
                UpdateSectionForm updateSectionForm = new(id);

                updateSectionForm.ShowDialog();
                LoadRows();
            }
            catch (Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSectionForm addSectionForm = new();
            addSectionForm.ShowDialog();
            LoadRows();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRows();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete selected section(s)?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AppDbContext db = new();

                var selectedRows = dataGridView.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    int id = (int)row.Cells["id"].Value;
                    var section = db.Sections.Find(id);
                    if (section != null) db.Sections.Remove(section);
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

        private void SectionTabComponent_Load(object sender, EventArgs e)
        {
            LoadRows();
        }
    }
}
