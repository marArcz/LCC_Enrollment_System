using LCC_ENROLLMENT_SYSTEM.Components;
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

namespace LCC_ENROLLMENT_SYSTEM
{
    public partial class AddStudentForm : Form
    {

        public AddStudentForm()
        {
            InitializeComponent();
        }
        public AddStudentForm(string studentId)
        {
            InitializeComponent();
            textBoxStudentId.Text = studentId;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

            int has_report_card = checkBoxReportCard.Checked ? 1: 0;
            int has_picture = checkBoxPicture.Checked ? 1 : 0;
            int has_good_moral = checkBoxGoodMoral.Checked ? 1 : 0;
            int has_nso = checkBoxNSO.Checked ? 1: 0;
            int has_certification = checkBoxCertification.Checked ? 1 : 0;
            int year_added = DateTime.Now.Year;
            Student newStudent = new()
            {
                student_id = id_no,
                lastname= lastname,
                firstname= firstname,
                middlename= middlename,
                address= address,
                birth_date = DateOnly.Parse(birthDateStr),
                birth_place = birthPlace,
                age = age,
                sex= sex,
                weight= weight,
                height= height,
                guardian = guardianName,
                guardian_phone=guardianPhone,
                guardian_address=guardianAddress,
                last_school_attended = lastSchoolAttended,
                last_school_year = lastSchoolYear,
                has_birth_certificate = has_nso,
                has_report_card = has_report_card,
                has_certification = has_certification,
                has_id_picture = has_picture,
                has_good_moral= has_good_moral,
                year_added = year_added
            };

            using(AppDbContext db = new())
            {
               db.Students.Add(newStudent);
               bool saved = db.SaveChanges() > 0;

                if (saved)
                {
                    SuccessDialog successDialog = new();
                    successDialog.ShowSuccess("Successfully added!");
                    this.Close();
                }
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePicker.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            textBoxAge.Text = age.ToString();
        }


    }
}
