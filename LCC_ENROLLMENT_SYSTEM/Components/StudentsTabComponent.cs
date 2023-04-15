using LCC_ENROLLMENT_SYSTEM.Data;
using LCC_ENROLLMENT_SYSTEM.Models;
using Microsoft.VisualBasic.ApplicationServices;
using MR.EntityFrameworkCore.KeysetPagination;
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
        private enum FetchDirection
        {
            forward,
            backward,
        }
        private int numOfRowsToDisplay = 10;
        private int lastId = 0;
        private FetchDirection dir = FetchDirection.forward;
        private List<Student> students;
        public StudentsTabComponent()
        {
            InitializeComponent();
            /*comboBoxRows.SelectedIndex = 0;*/
        }

        private void customButton6_Click(object sender, EventArgs e)
        {

        }

        public void LoadStudents(bool movePagination = false)
        {
            AppDbContext db = new();

            if (dir == FetchDirection.forward)
            {
                if (movePagination && students.Any())
                {
                    
                    students = students.OrderBy(s => s.id).ToList();
                    lastId = students.Last().id;
                }
                students = db.Students
                    .Where(s => s.is_deleted == 0 && s.id > lastId && s.lastname.Contains(textBoxSearch.Text))
                    .Take(numOfRowsToDisplay)
                    .ToList();
                DisplayStudents(students);


            }
            else
            {
                if (movePagination && students.Any())
                {
                    lastId = students.First().id;
                }
                students = db.Students
                    .Where(s => s.is_deleted == 0 && s.id < lastId && s.lastname.Contains(textBoxSearch.Text))
                    .OrderByDescending(s => s.id)
                    .Take(numOfRowsToDisplay)
                    .ToList();

                students = students.OrderBy(s => s.id).ToList();
                DisplayStudents(students);
            }

            if (students.Any())
            {

                int nextId = students.Last().id;
                int prevId = students.First().id;
                int prevRowsCount = db.Students.Where(s => s.id < prevId && s.is_deleted == 0).Count();
                int nextRowsCount = db.Students.Where(s => s.id > nextId && s.is_deleted == 0).Count();

                btnNext.Enabled = nextRowsCount > 0;
                btnPrev.Enabled = prevRowsCount > 0;
            }
            else
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
            }


        }

        private void DisplayStudents(List<Student> students)
        {
            dataGridViewStudents.Rows.Clear();
            students = students.OrderBy(s => s.lastname).ToList();
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
      

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            var currentYear = DateTime.Now.Year.ToString();
            string newStudentId = Convert.ToString(generateNewStudentId());
            AddStudentForm addStudentForm = new(newStudentId);
            addStudentForm.ShowDialog(this);
            LoadStudents();
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

        private int generateNewStudentId()
        {
            int currentYear = DateTime.Now.Year;
            using(AppDbContext db = new())
            {
                var latestStudent = db.Students
                    .Where(s => s.year_added == currentYear && s.is_deleted == 0)
                    .FirstOrDefault();

                if(latestStudent != null)
                {
                    int latestIdNo = Convert.ToInt32(latestStudent.student_id);
                    int suffix = Convert.ToInt32(latestStudent.student_id.Substring(3));

                    return ++latestIdNo;
                }
                else
                {
                    int latestIdNo = Convert.ToInt32(currentYear + "0001");
                    return latestIdNo;
                }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            dir = FetchDirection.forward;
            LoadStudents(true);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dir = FetchDirection.backward;
            LoadStudents(true);
        }

        private void comboBoxRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            numOfRowsToDisplay = Convert.ToInt32(comboBoxRows.Text);
            LoadStudents();
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = dataGridViewStudents.SelectedRows.Count == 1;
            btnDelete.Enabled = dataGridViewStudents.SelectedRows.Count > 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are you sure to delete selected student(s)?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.No)
            {
                return;
            }
            
            var ids = new List<int>();
            var selectedRows = dataGridViewStudents.SelectedRows;
            

            using(AppDbContext db = new())
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    var id = (int) row.Cells["id"].Value;
                    var student = db.Students.Find(id);
                    if (student != null)
                    {
                        student.is_deleted = 1;
                        db.SaveChanges();
                    }
                }
            }

            LoadStudents();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadStudents();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = (int) dataGridViewStudents.SelectedRows[0].Cells["id"].Value;
            UpdateStudentForm updateStudentForm = new(id);
            updateStudentForm.ShowDialog();
            LoadStudents();
        }


        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            LoadStudents();

        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
