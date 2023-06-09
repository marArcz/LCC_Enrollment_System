﻿using LCC_ENROLLMENT_SYSTEM.Data;
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
    public partial class StrandsComponentTab : CustomTab
    {
        private enum FetchDirection
        {
            forward,
            backward,
        }
        private int numOfRowsToDisplay = 10;
        private int lastId = 0;
        private FetchDirection dir = FetchDirection.forward;
        private List<Strand> rows;
        public StrandsComponentTab()
        {
            InitializeComponent();
            ///LoadRows();

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
                rows = db.Strands
                    .Include(s => s.TrackModel)
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
                rows = db.Strands
                    .Include(s => s.TrackModel)
                   .Where(s => s.Id < lastId && s.Name.Contains(textBoxSearch.Text))
                    .OrderByDescending(s => s.Id)
                    .Take(numOfRowsToDisplay)
                    .ToList();

                rows = rows.OrderBy(s => s.Id).ToList();
            }

            if (rows.Any())
            {

                int nextId = rows.Last().Id;
                int prevId = rows.First().Id;
                int prevRowsCount = db.Strands.Where(s => s.Id < prevId && s.Name.Contains(textBoxSearch.Text)).Count();
                int nextRowsCount = db.Strands.Where(s => s.Id > nextId && s.Name.Contains(textBoxSearch.Text)).Count();

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

        private void DisplayRows(List<Strand> rows)
        {
            dataGridView.Rows.Clear();
            rows = rows.OrderBy(s => s.Id).ToList();
            foreach (var row in rows)
            {
                dataGridView.Rows
                    .Add(
                        row.Id,
                        row.TrackModel.Name,
                        row.Name
                    );

            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStrandForm addStrandForm = new();
            addStrandForm.ShowDialog();
            LoadRows();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = (int) dataGridView.SelectedRows[0].Cells["id"].Value;
            UpdateStrandForm updateStrandForm = new(id);
            updateStrandForm.ShowDialog();
            LoadRows();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = dataGridView.SelectedRows.Count == 1;
            btnDelete.Enabled = dataGridView.SelectedRows.Count > 0;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadRows();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete selected strand(s)?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AppDbContext db = new();

                var selectedRows = dataGridView.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    int id = (int)row.Cells["id"].Value;
                    var strand = db.Strands.Find(id);
                    if (strand != null) db.Strands.Remove(strand);
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
