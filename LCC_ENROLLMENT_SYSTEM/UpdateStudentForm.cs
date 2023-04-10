using LCC_ENROLLMENT_SYSTEM.Components;
using LCC_ENROLLMENT_SYSTEM.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC_ENROLLMENT_SYSTEM
{
    public partial class UpdateStudentForm : Form
    {
        private int id;
        private SuccessDialog successDialog;
        public UpdateStudentForm()
        {
            InitializeComponent();
            successDialog = new();
        }  
        public UpdateStudentForm(int studentId)
        {
            InitializeComponent();
            successDialog = new();
            LoadData(studentId);
        }

        private void LoadData(int id)
        {
            this.id = id;
            using(AppDbContext db = new())
            {
                var student = db.Students.Find(id);
                textBoxStudentId.Text = student.student_id;
                textBoxLastname.Text = student.lastname;
                textBoxFirstname.Text = student.firstname;
                textBoxMiddlename.Text = student.middlename;
                textBoxAddress.Text = student.address;
                textBoxBirthPlace.Text = student.birth_place;
                dateTimePicker.Text = student.birth_date.ToShortDateString();
                textBoxAge.Text = student.age.ToString();
                if (student.sex.ToLower().Equals("male"))
                {
                    radioButtonMale.Checked = true;
                }
                else
                {
                    radioButtonFemale.Checked = true;
                }
                textBoxWeight.Text = student.weight;
                textBoxHeight.Text = student.height;
                textBoxGuardianName.Text = student.guardian;
                textBoxGuardianPhone.Text = student.guardian_phone;
                textBoxGuardianAddress.Text = student.guardian_address;
                textBoxLastSchool.Text = student.last_school_attended;
                comboBoxLastSchoolYear.Text = student.last_school_year;

                checkBoxReportCard.Checked = student.has_report_card == 1;
                checkBoxPicture.Checked = student.has_id_picture == 1;
                checkBoxGoodMoral.Checked = student.has_good_moral == 1;
                checkBoxNSO.Checked = student.has_birth_certificate == 1;
                checkBoxCertification.Checked = student.has_certification == 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id_no = textBoxStudentId.Text;
            string lastname = textBoxLastname.Text;
            string firstname = textBoxFirstname.Text;
            string middlename = textBoxMiddlename.Text;
            string address = textBoxAddress.Text;
            string birthPlace = textBoxBirthPlace.Text;
            DateTime birthDate = dateTimePicker.Value;

            string birthDateStr = birthDate.Year + "-" + $"{birthDate.Month:00}" + "-" + $"{birthDate.Day:00}";

            int age = DateTime.Now.Year - birthDate.Year;
            string sex = radioButtonMale.Checked ? "Male" : "Female";
            string weight = textBoxWeight.Text;
            string height = textBoxHeight.Text;

            string guardianName = textBoxGuardianName.Text;
            string guardianPhone = textBoxGuardianPhone.Text;
            string guardianAddress = textBoxGuardianAddress.Text;
            string lastSchoolAttended = textBoxLastSchool.Text;
            string lastSchoolYear = comboBoxLastSchoolYear.Text;

            int has_report_card = checkBoxReportCard.Checked ? 1 : 0;
            int has_picture = checkBoxPicture.Checked ? 1 : 0;
            int has_good_moral = checkBoxGoodMoral.Checked ? 1 : 0;
            int has_nso = checkBoxNSO.Checked ? 1 : 0;
            int has_certification = checkBoxCertification.Checked ? 1 : 0;

            using(AppDbContext db = new())
            {
                var student = db.Students.Find(id);
                if(student == null)
                {
                    MessageBox.Show("Student record cannot be found!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    student.firstname = firstname;
                    student.lastname = lastname;
                    student.middlename = middlename;
                    student.address = address;
                    student.weight = weight;
                    student.birth_place = birthPlace;
                    student.birth_date = DateOnly.Parse(birthDateStr);
                    student.age = age;
                    student.guardian = guardianName;
                    student.guardian_address = guardianAddress;
                    student.guardian_phone = guardianPhone;
                    student.height = height;
                    student.has_birth_certificate = has_nso;
                    student.has_report_card = has_report_card;
                    student.has_certification = has_certification;
                    student.has_id_picture = has_picture;
                    student.has_good_moral = has_good_moral;

                    bool saved = db.SaveChanges() >=0;

                    if (saved)
                    {
                        /*successDialog.ShowSuccess("Successfully updated student!");*/
                        MessageBox.Show("Successfully updated student!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePicker.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            textBoxAge.Text = age.ToString();
        }
    }
}
