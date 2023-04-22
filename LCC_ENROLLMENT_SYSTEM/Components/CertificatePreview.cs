using IronSoftware.Drawing;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
    public partial class CertificatePreview : Form
    {

        public CertificatePreview(IronSoftware.Drawing.AnyBitmap pdfBitmap)
        {
            InitializeComponent();
            pictureBox1.Image = pdfBitmap.Clone(new Rectangle(0,0,pdfBitmap.Width,pdfBitmap.Height));
        }

        public CertificatePreview(string photoFileName)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(photoFileName);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
