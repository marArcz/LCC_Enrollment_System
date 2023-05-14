using iText.Layout.Element;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LCC_ENROLLMENT_SYSTEM.Data;
using LCC_ENROLLMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LCC_ENROLLMENT_SYSTEM.Components
{
    public partial class ReportsTabComponents : UserControl
    {
        List<GradeLevel> GradeLevels;
        List<Models.Section> Sections;
        List<Enrollment> Enrollments;
        List<SchoolYear> SchoolYears;
        int from = 2000;
        int to = 2001;

        public ReportsTabComponents()
        {
            InitializeComponent();
            from = DateTime.Now.Year - 1;
            to = DateTime.Now.Year;
            textSchoolYearChart.Text = $"{from}-{to}";

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("ListTab");
            LoadRows();
        }

        private void customLabel6_Click(object sender, EventArgs e)
        {

        }
        public void LoadAll()
        {
            LoadSchoolYears();
            LoadGradeLevels();
            LoadSections();
            LoadRows();
        }

        public void LoadGradeLevels()
        {
            AppDbContext db = new();
            //get levels
            GradeLevels = db.GradeLevels.ToList();
            comboBoxGradeLevel.Items.Clear();

            GradeLevels.ForEach(g =>
            {
                comboBoxGradeLevel.Items.Add(g.Level);
            });
            if (comboBoxGradeLevel.Items.Count > 0) comboBoxGradeLevel.SelectedIndex = 0;
        }

        public void LoadSections()
        {
            AppDbContext db = new();
            //get levels
            int gradeLevelId = GradeLevels.ElementAt(comboBoxGradeLevel.SelectedIndex).Id;
            Sections = db.Sections.Where(s => s.GradeLevelId == gradeLevelId).ToList();
            comboBoxSection.Items.Clear();

            Sections.ForEach(s =>
            {
                comboBoxSection.Items.Add(s.Name);
            });
            if (comboBoxSection.Items.Count > 0) comboBoxSection.SelectedIndex = 0;

        }

        public void LoadSchoolYears()
        {
            AppDbContext db = new();
            //get levels
            SchoolYears = db.SchoolYears.ToList();
            comboBoxSchoolYear.Items.Clear();

            SchoolYears.ForEach(s =>
            {
                comboBoxSchoolYear.Items.Add(s.ToString());
            });
            if (comboBoxSchoolYear.Items.Count > 0) comboBoxSchoolYear.SelectedIndex = 0;

        }

        public void LoadEnrollments()
        {
            if (Sections.Count > 0)
            {
                AppDbContext db = new();
                int sectionId = Sections.ElementAt(comboBoxSection.SelectedIndex).Id;
                int schoolYearId = SchoolYears.ElementAt(comboBoxSchoolYear.SelectedIndex).Id;
                Enrollments = db.Enrollments
                    .Include(e => e.student)
                    .Where(e => e.sectionId == sectionId && e.schoolYearId == schoolYearId)
                    .ToList();
            }
        }

        public void LoadRows()
        {
            if (Sections.Count > 0)
            {
                LoadEnrollments();
                int index = 0;

                var level = comboBoxGradeLevel.Text;
                var section = comboBoxSection.Text;
                var schoolYear = comboBoxSchoolYear.Text;
                textGradeLevelTotal.Text = textGradeLevel.Text = $"Grade {level}";
                textSectionTotal.Text = textSection.Text = section;
                textSchoolYearTotal.Text = textSchoolYear.Text = schoolYear;

                textTotalStudentTotal.Text = textTotalStudents.Text = Convert.ToString(Enrollments.Count());

                dataGridView.Rows.Clear();
                Enrollments.ForEach((e) =>
                {
                    dataGridView.Rows.Add(
                       ++index,
                       e.student.lastname,
                       e.student.firstname,
                       (e.student.middlename.Length > 0 ? e.student.middlename[0] : ""),
                       $"Grade {level}",
                       section
                    );
                });
            }
        }

        private void comboBoxGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSections();
            LoadRows();
        }

        private void comboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Sections != null)
            {
                LoadRows();
            }
        }

        private void btnTotalEnrollees_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("ListTab");
            LoadAll();
        }

        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRows();
        }

        private void btnTotalEnrollees_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectTab("totalTab");
            LoadRows();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            LoadRows();
            LoadChart();
            tabControl.SelectTab("chartTab");
        }

        private void LoadChart()
        {

            AppDbContext db = new();
            
            var schoolYears = db.SchoolYears.Where(s => s.From >= from && s.To <= to).ToList();

            chart.Series["Enrollees"].Points.Clear();

            schoolYears.ForEach(s =>
            {
                int enrollees = db.Enrollments.Where(e => e.schoolYearId == s.Id).Count();
                chart.Series["Enrollees"].Points.AddXY(s.ToString(),enrollees);
            });
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeSchoolYear changeSchoolYear = new(ref from, ref to);
            changeSchoolYear.ShowDialog();

            from = changeSchoolYear.From;
            to = changeSchoolYear.To;

            textSchoolYearChart.Text = $"{from}-{to}";
            LoadChart();
        }

        private void printReport(DataGridView dataGridView, string title)
        {
            PrintDialog printDialog = new();
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.UseWaitCursor = true;

                string fileDirectory = "Pdf/";
                string fileName = $"{fileDirectory}{title}.pdf";
                Directory.CreateDirectory(fileDirectory);

                float margin = 40f;

                PdfDocument document = new PdfDocument(PageSize.LETTER, margin, margin, margin, margin);

                var fileStream = new FileStream(fileName, FileMode.Create);
                var pdfWriter = PdfWriter.GetInstance(document, fileStream);
                document.Open();
                var Image1 = iTextSharp.text.Image.GetInstance(ImageToByte(Properties.Resources.LCC_64));
                Image1.SetAbsolutePosition(document.GetLeft(10f), document.GetTop(margin) * 0.95f);


                //add header

                document.AddSpaces(Image1.Height / 2f);
                document.AddParagraph("LEGACY COLLEGE OF COMPOSTELLA", 16, iTextSharp.text.Font.BOLD);
                document.AddParagraph("Dagohoy Street, Poblacion, Compostela, Davao de Oro", 10);
                document.Add(Image1);
                //end of header

                document.AddSpaces(Image1.Height * 0.85f);


                //document.AddParagraph(title, 14, Element.ALIGN_LEFT);

                document.AddSpaces(10,PdfDocument.Spacing.Before);

                PdfPTable pTable = new PdfPTable(2);
                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pTable.WidthPercentage = 50;
                pTable.AddCell(NewCell($"Grade Level: {textGradeLevel.Text}",12));
                pTable.AddCell(NewCell($"Section: {textSection.Text}", 12));
                pTable.AddCell(NewCell($"School Year: {textSchoolYear.Text}", 12,0,5,2));
                document.Add(pTable);
                //create table;
                int colCount = dataGridView.ColumnCount - 1;
                document.CreateTable(colCount);

                //add table header
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.Index == 0) continue;
                    string text = column.HeaderText;
                    document.AddTableCell(text);
                }

                //add table rows
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 0) continue;
                        document.AddTableCell(cell.Value.ToString());
                    }
                }

                document.DrawTable();
                document.Close();
                pdfWriter.Close();

                IronPdf.ChromePdfRenderer renderer = new();
                IronPdf.PdfDocument doc = new(fileName);

                var printDocument = doc.GetPrintDocument();
                printDocument.PrinterSettings = printDialog.PrinterSettings;

                printDocument.DefaultPageSettings.Margins.Top = 0;
                printDocument.DefaultPageSettings.Margins.Bottom = 0;
                printDocument.DefaultPageSettings.Margins.Left = 0;
                printDocument.DefaultPageSettings.Margins.Right = 0;

                PrintPreviewDialog previewDialog = new();
                previewDialog.Document = printDocument;

                previewDialog.ShowDialog();



                this.UseWaitCursor = false;
            }
        }
        private PdfPCell NewCell(string text, float fontSize = 10, int fontStyle = iTextSharp.text.Font.NORMAL, int PaddingBottom = 5, int Colspan=1, int Alignment = Element.ALIGN_LEFT)
        {
            iTextSharp.text.Font font = new(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, fontSize, fontStyle);

            PdfPCell cell = new(new Phrase(text, font))
            {
                Padding = 5,
                Colspan=Colspan,
                PaddingBottom = PaddingBottom,
                BackgroundColor = BaseColor.WHITE,
                Border = iTextSharp.text.Rectangle.NO_BORDER,
                BorderWidth = 0,
                HorizontalAlignment = Alignment,
                VerticalAlignment = Element.ALIGN_CENTER
            };

            return cell;
        }

        public static byte[] ImageToByte(System.Drawing.Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printReport(dataGridView, "List of Students");
        }
    }
}
