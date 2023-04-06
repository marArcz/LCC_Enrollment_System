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
    public partial class StudentsTabComponent : UserControl
    {
        private int numOfRowsToDisplay = 1;
        private int numOfRows = 0;
        private int paginationIndex = 1;
        private int lastId = 0;
        private int firstId = 0;
        private int limit;

        public StudentsTabComponent()
        {
            InitializeComponent();
            //loadStudents();
        }

        private void customButton6_Click(object sender, EventArgs e)
        {

        }

        public void loadStudents(string dir = "forward")
        {
            /*MessageBox.Show("lastId: " + lastId);*/
            using(AppDbContext db = new())
            {
                if (String.IsNullOrWhiteSpace(textBoxSearch.Text))
                {
                    //get num of rows
                    var numOfRowsNext = db.Students
                        .Where(s => s.is_deleted == 0 && s.id > lastId)
                        .Count();
                    var numOfRowsPrev = db.Students
                        .Where(s => s.is_deleted == 0 && s.id < lastId)
                        .Count();

                    btnNext.Enabled = numOfRowsNext > numOfRowsToDisplay;
                    btnPrev.Enabled = numOfRowsPrev > numOfRowsToDisplay;
                   IOrderedEnumerable<Student> students;
                   if (dir == "forward")
                    {
                         students = db.Students
                           .Where(s => s.is_deleted == 0 && s.id > lastId)
                           .Take(numOfRowsToDisplay)
                           .ToList()
                           .OrderByDescending(s => s.lastname);
                    }
                    else
                    {
                       students = db.Students
                          .Where(s => s.is_deleted == 0 && s.id < lastId)
                          .Take(numOfRowsToDisplay)
                          .ToList()
                          .OrderByDescending(s => s.lastname);
                    }
                    dataGridViewStudents.Rows.Clear();
                    foreach (var student in students)
                    {
                        dataGridViewStudents.Rows
                            .Add(
                                student.id,
                                student.student_id,
                                student.lastname,
                                student.firstname,
                                (student.middlename.Length > 0 ? student.middlename[0]:""),
                                student.sex,
                                student.age,
                                student.address
                            );
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadStudents();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            var currentYear = DateTime.Now.Year.ToString();
            string newStudentId = currentYear + "-" + NewStudentId(currentYear);
            AddStudentForm addStudentForm = new(newStudentId);
            addStudentForm.ShowDialog(this);

        }
        private string NewStudentId(string year)
        {
            int studentId = 0;
            using (AppDbContext db = new AppDbContext())
            {
                var latestStudent = db.Students
                    .Where(s => s.student_id.Contains(year) && s.is_deleted == 0)
                    .OrderByDescending(s => s.id)
                    .FirstOrDefault();

                if (latestStudent != null)
                {
                    //get student id
                    var temp = latestStudent.student_id.Substring(latestStudent.student_id.IndexOf("-") + 1);
                    var startIndex = 0;
                    if (temp[0] != '0')
                    {
                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (temp[i] != '0')
                            {
                                startIndex = i;
                                break;
                            }
                        }
                    }

                    studentId = Convert.ToInt32(temp.Substring(startIndex));
                }
                else
                {
                    studentId = 1;
                }

            }
            studentId++;

            return $"{studentId:00000}"; ;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int lastRowIndex = dataGridViewStudents.RowCount - 1;
            int maxId = (int) dataGridViewStudents.Rows[0].Cells["id"].Value;
            foreach(DataGridViewRow row in dataGridViewStudents.Rows)
            {
                maxId = ((int)row.Cells["id"].Value) > maxId ? ((int)row.Cells["id"].Value) : maxId;
            }
            lastId = maxId;
            loadStudents();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int minId = (int)dataGridViewStudents.Rows[0].Cells["id"].Value;
            foreach (DataGridViewRow row in dataGridViewStudents.Rows)
            {
                minId = ((int)row.Cells["id"].Value) < minId ? ((int)row.Cells["id"].Value) : minId;
            }
            lastId = minId;
            loadStudents("prev");
        }
    }
}
