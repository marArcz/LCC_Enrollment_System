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
            LoadRows();
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
                int prevRowsCount = db.Strands.Where(s => s.Id < lastId && s.Name.Contains(textBoxSearch.Text)).Count();
                int nextRowsCount = db.Strands.Where(s => s.Id > lastId && s.Name.Contains(textBoxSearch.Text)).Count();

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
    }
}
