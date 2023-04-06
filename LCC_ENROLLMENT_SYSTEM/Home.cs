using LCC_ENROLLMENT_SYSTEM.CustomControls;
using LCC_ENROLLMENT_SYSTEM.Data;
using LCC_ENROLLMENT_SYSTEM.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC_ENROLLMENT_SYSTEM
{
    public partial class Home : Form
    {
        private TabPage[] tabPages;
        private SidemenuButton[] tabPagesLinks;
        private bool isSearching = false;
        
        public Home()
        {
            CustomFonts.init();
            InitializeComponent();
            var controls = sidemenuPanel.Controls;
            foreach (var control in controls)
            {
                ((SidemenuButton)control).Click += tabLink_Click;
            }
            studentTabComponent.loadStudents();
        }

        private void tabLink_Click(object sender, EventArgs e)
        {
            SidemenuButton btn = (SidemenuButton)sender;

            string targetTab = btn.Tab;
            tabControl.SelectedTab = tabControl.TabPages[targetTab];

            clearActiveTabLink();
            btn.Active = true;
        }

        private void clearActiveTabLink()
        {
            var controls = sidemenuPanel.Controls;
            foreach (var control in controls)
            {
                ((SidemenuButton)control).Active = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void loadStudentsTable()
        {
        
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if(tabControl.SelectedTab == studentsTab)
            {
                studentTabComponent.loadStudents();
            }*/
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var currentYear = DateTime.Now.Year.ToString();
            string newStudentId =  currentYear + "-" + NewStudentId(currentYear);
            AddStudentForm addStudentForm = new(newStudentId);
            addStudentForm.ShowDialog(this);
        }

        private string NewStudentId(string year)
        {
            int studentId = 0;
            using(AppDbContext db = new AppDbContext())
            {
                var latestStudent = db.Students
                    .Where(s => s.student_id.Contains(year) && s.is_deleted == 0)
                    .OrderByDescending(s => s.id)
                    .FirstOrDefault();

                if (latestStudent != null)
                {
                    //get student id
                    var temp = latestStudent.student_id.Substring(latestStudent.student_id.IndexOf("-")+1);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
