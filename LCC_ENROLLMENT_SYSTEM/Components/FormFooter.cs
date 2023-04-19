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
    public partial class FormFooter : UserControl
    {
        public event EventHandler onBtnSaveClicked;
        public event EventHandler onBtnResetClicked;
        public event EventHandler onBtnCancelClicked;

  

        public FormFooter()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            onBtnSaveClicked(sender,e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            onBtnResetClicked(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            onBtnCancelClicked(sender, e);
        }
    }
}
