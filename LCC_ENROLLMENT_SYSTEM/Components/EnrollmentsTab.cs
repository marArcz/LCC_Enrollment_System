using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronSoftware.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using LCC_ENROLLMENT_SYSTEM.Data;
using LCC_ENROLLMENT_SYSTEM.Models;
using LCC_ENROLLMENT_SYSTEM.Properties;
using Microsoft.EntityFrameworkCore;
using PdfSharp.Charting;
using PdfSharp.Drawing;

namespace LCC_ENROLLMENT_SYSTEM.Components
{
    public partial class EnrollmentsTab : UserControl
    {
        public EnrollmentsTab()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        public void GeneratePdfFromTable(DataGridView dataGridView,string title)
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

                PdfDocument document = new PdfDocument(PageSize.LETTER,margin,margin,margin,margin);

                var fileStream = new FileStream(fileName, FileMode.Create);
                var pdfWriter = PdfWriter.GetInstance(document, fileStream);
                document.Open();
                var Image1 = iTextSharp.text.Image.GetInstance(ImageToByte(Properties.Resources.LCC_64));
                Image1.SetAbsolutePosition(document.GetLeft(10f), document.GetTop(margin) * 0.95f);

                var Image2 = iTextSharp.text.Image.GetInstance(ImageToByte(Properties.Resources.LCC_64));
                Image2.SetAbsolutePosition(document.GetRight(10f), 725);

                document.AddSpaces(Image1.Height / 2f);
                document.AddParagraph("Legacy College of Compostela",14);
                document.AddParagraph("Dagohoy Street, Poblacion, Compostela, Davao de Oro", 10);
                document.Add(Image1);

                document.AddSpaces(Image1.Height * 0.85f);


                document.AddParagraph(title, 14, Element.ALIGN_LEFT);

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
                printDocument.Print();

                this.UseWaitCursor = false;
            }
        }

        public static byte[] ImageToByte(System.Drawing.Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public void GenerateCertificate(int id)
        {
            AppDbContext db = new();
            var enrollment = db.Enrollments
                .Include(e => e.student)
                .Include(e => e.schoolYear)
                .Include(e => e.section)
                .Include(e => e.gradeLevel)
                .Where(s => s.id == id).First();

           
                this.UseWaitCursor = true;

                string fileDirectory = "Pdf/";
                string fileName = $"{fileDirectory}{enrollment.student.lastname}.pdf";
                string photoDirectory = "Image/";
                string photoFileName = $"{photoDirectory}{enrollment.student.lastname}.png";

                Directory.CreateDirectory(fileDirectory);
                Directory.CreateDirectory(photoDirectory);

                float margin = 30f;

                PdfDocument document = new PdfDocument(PageSize.LETTER, margin+30, margin+30, margin, margin);

                var fileStream = new FileStream(fileName, FileMode.Create);
                var pdfWriter = PdfWriter.GetInstance(document, fileStream);
                document.Open();

                //add header
                var Image1 = iTextSharp.text.Image.GetInstance(ImageToByte(Properties.Resources.LCC_64));
                Image1.SetAbsolutePosition(document.GetLeft(10f), document.GetTop(margin) * 0.95f);

                document.AddSpaces(Image1.Height / 2f);
                document.AddParagraph("LEGACY COLLEGE OF COMPOSTELLA", 16,iTextSharp.text.Font.BOLD);
                document.AddParagraph("Dagohoy Street, Poblacion, Compostela, Davao de Oro", 10);
                document.Add(Image1);
                //end of header
                document.AddSpaces(Image1.Height * 0.85f);

                document.AddParagraph("CERTIFICATE OF ENROLLMENT", 14,iTextSharp.text.Font.BOLD);

            document.AddSpaces(30f);
            //first table content
            PdfPTable table1 = new(2);
            table1.WidthPercentage = 100;
            table1.HorizontalAlignment = Element.ALIGN_LEFT;
            table1.AddCell(NewCell($"IDNO: {enrollment.student.student_id}",14,0,10));
            table1.AddCell(NewCell($"SCHOOL YEAR: {enrollment.schoolYear.ToString()}",14,0,10));
            table1.AddCell(NewCell($"NAME: {enrollment.student.ToString()}",14));
            table1.AddCell(NewCell($"YEAR/SEC: Grade {enrollment.gradeLevel.Level} {enrollment.section.Name}",14));
            document.Add(table1);


            PdfPTable table2 = new(2);
            table2.SpacingBefore = 100;
            table2.WidthPercentage = 70;
            table2.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell(NewCell("Subject",12,iTextSharp.text.Font.BOLD));
            table2.AddCell(NewCell("Description",12,iTextSharp.text.Font.BOLD));

            //fetch subjects enrolled
            var subjectsEnrolled = db.SubjectsEnrolled.Include(s=>s.subject).Where(s => s.enrollmentId == enrollment.id).ToList();
            foreach(SubjectsEnrolled item in subjectsEnrolled)
            {
                table2.AddCell(NewCell(item.subject.Name, 12));
                table2.AddCell(NewCell(item.subject.Description, 12));
            }

            document.Add(table2);

            document.AddSpaces(100,PdfDocument.Spacing.Before);
            float w = 30;
            LineSeparator line = new LineSeparator(1f, w, BaseColor.BLACK, Element.ALIGN_LEFT, 1);
            document.Add(line);
            iTextSharp.text.Font font = new(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD);

            Paragraph p = new("Office In-Charge",font);
            p.Alignment = Element.ALIGN_LEFT;

            p.IndentationLeft = w * 0.8f;
            document.Add(p);
            document.AddParagraph("Signature over printed name",12,0,Element.ALIGN_LEFT);
            document.Close();
                pdfWriter.Close();


                var pdf = IronPdf.PdfDocument.FromFile(fileName);

                pdf.RasterizeToImageFiles(photoFileName);
                // Extract all pages as AnyBitmap objects
                AnyBitmap[] pdfBitmaps = pdf.ToBitmap();
                CertificatePreview preview = new(pdfBitmaps[0]);
                //CertificatePreview preview = new(photoFileName);
                DialogResult dialogResult =  preview.ShowDialog();

                if(dialogResult== DialogResult.OK)
                {
                    PrintDialog printDialog = new();
                    DialogResult result = printDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        IronPdf.ChromePdfRenderer renderer = new();
                        IronPdf.PdfDocument doc = new(fileName);


                        var printDocument = doc.GetPrintDocument();
                        printDocument.PrinterSettings = printDialog.PrinterSettings;

                        printDocument.DefaultPageSettings.Margins.Top = 0;
                        printDocument.DefaultPageSettings.Margins.Bottom = 0;
                        printDocument.DefaultPageSettings.Margins.Left = 0;
                        printDocument.DefaultPageSettings.Margins.Right = 0;
                        printDocument.Print();
                    }
                }

                this.UseWaitCursor = false;
        }

        private PdfPCell NewCell(string text,float fontSize=10,int fontStyle=iTextSharp.text.Font.NORMAL,int PaddingBottom = 5)
        {
            iTextSharp.text.Font font = new(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, fontSize,fontStyle);
            
            PdfPCell cell = new(new Phrase(text, font))
            {
                Padding = 5,
                PaddingBottom = PaddingBottom,
                BackgroundColor = BaseColor.WHITE,
                Border = iTextSharp.text.Rectangle.NO_BORDER,
                BorderWidth = 0,
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_CENTER
            };

            return cell;
        }
    }
}
