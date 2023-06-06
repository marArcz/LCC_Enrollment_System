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
    public partial class AdvisersTabComponent : CustomTab
    {
        private enum FetchDirection
        {
            forward,
            backward,
        }
        private int numOfRowsToDisplay = 10;
        private int lastId = 0;
        private FetchDirection dir = FetchDirection.forward;
        private List<Adviser> rows;
        public AdvisersTabComponent()
        {
            InitializeComponent();
        }
        public void LoadRows(bool movePagination = false)
        {
            AppDbContext db = new();
            //int schoolLevelId = db.SchoolLevels.Where(s => s.Description.ToLower().Equals("junior highschool")).First().Id;
            if (dir == FetchDirection.forward)
            {
                if (movePagination && rows.Any())
                {
                    rows = rows.OrderBy(s => s.Id).ToList();
                    lastId = rows.Last().Id;
                }
                rows = db.Advisers
                    .Where(e => e.Id < lastId && e.Firstname.ToLower().Contains(textBoxSearch.Text) || e.Lastname.ToLower().Contains(textBoxSearch.Text) || e.Middlename.ToLower().Contains(textBoxSearch.Text))
                    .Take(numOfRowsToDisplay)
                    .ToList();

            }
            else
            {
                if (movePagination && rows.Any())
                {
                    lastId = rows.First().Id;
                }
                rows = db.Advisers
                    .Where(e => e.Id > lastId && e.Firstname.ToLower().Contains(textBoxSearch.Text) || e.Lastname.ToLower().Contains(textBoxSearch.Text) || e.Middlename.ToLower().Contains(textBoxSearch.Text))
                    .OrderByDescending(s => s.Id)
                    .Take(numOfRowsToDisplay)
                    .ToList();

                rows = rows.OrderBy(s => s.Id).ToList();
            }

            if (rows.Any())
            {
                int nextId = rows.Last().Id;
                int prevId = rows.First().Id;
                int prevRowsCount = db.Advisers.Where(s => s.Id < prevId).Count();
                int nextRowsCount = db.Advisers.Where(s => s.Id > nextId).Count();

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

        private void DisplayRows(List<Adviser> rows)
        {
            dataGridView.Rows.Clear();
            rows = rows.OrderBy(e => e.Id).ToList();
            foreach (var row in rows)
            {
                dataGridView.Rows
                    .Add(
                        row.Id,
                        row.Firstname,
                        row.Middlename,
                        row.Lastname
                    );
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRows();
        }
    }
}
