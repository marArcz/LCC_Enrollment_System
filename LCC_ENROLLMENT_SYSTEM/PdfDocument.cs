using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM
{
    internal class PdfDocument : Document
    {
        private int afterSpaces = 4;
        public enum Spacing
        {
            Before,
            After
        }
        private PdfPTable table;

        public int AfterSpaces { get => afterSpaces; set => afterSpaces = value; }

        public PdfDocument(iTextSharp.text.Rectangle pageSize, float marginLeft, float marginRight, float marginTop, float marginBottom) : base(pageSize, marginLeft, marginRight, marginTop, marginBottom)
        {
        }

        public override void Open()
        {
            base.Open();
        }

        public void AddParagraph(string ParagraphText, float fontSize=12, int fontStyle = iTextSharp.text.Font.NORMAL, int Alignment = Element.ALIGN_CENTER, iTextSharp.text.Font font = null)
        {
            if(font == null)
            {
                font = new(iTextSharp.text.Font.FontFamily.TIMES_ROMAN,fontSize, fontStyle);
            }
            Paragraph p = new(ParagraphText,font);
            p.Alignment = Alignment;
            p.Font = font;
            p.SpacingAfter = AfterSpaces;

            this.Add(p);
        }

        public void CreateTable(int ColumnCount)
        {
            this.table = new(ColumnCount)
            {
                SpacingBefore = 10,
                WidthPercentage = 100,
            };

            this.table.DefaultCell.Padding = 4;
        }
        public void AddTableCell(string text, int fontSize = 12,iTextSharp.text.Font font = null)
        {
            if (font == null)
            {
                font = new(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, fontSize);
            }
            PdfPCell cell = new(new Phrase(text, font))
            {
                Padding = 5,
                BorderColor = iTextSharp.text.BaseColor.GRAY,
                BackgroundColor = BaseColor.WHITE,
                Border = iTextSharp.text.Rectangle.BOX,
                BorderWidth = 1f,
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_CENTER
            };

            this.table.AddCell(cell);
        }

        public void DrawTable()
        {
            this.Add(table);
        }

        public void AddSpaces(float spaces,Spacing spacing = Spacing.After)
        {
            Paragraph p = new("");

            if (spacing == Spacing.Before)
            {
                p.SpacingBefore = spaces;
            }
            else
            {
                p.SpacingAfter = spaces;
            }
            this.Add(p);
        }
    }
}
