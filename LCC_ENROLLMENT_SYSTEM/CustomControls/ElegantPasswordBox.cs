using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    public partial class ElegantPasswordBox : ElegantTextBox
    {
        private bool showPassword = false;
        public ElegantPasswordBox()
        {
            InitializeComponent();

            if(TextBoxInputType == InputType.Password)
            {
                textBox.PasswordChar = showPassword ? '\0' : '*';
                updateToggler();
            }
        }

        public bool ShowPassword { get => showPassword;
            set
            {
                showPassword = value;
                if (TextBoxInputType == InputType.Password)
                {
                    textBox.PasswordChar = showPassword ? '\0' : '*';
                    updateToggler();

                }
            }
        }

        private void passwordToggler_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            textBox.PasswordChar = showPassword ? '\0' : '*';
            updateToggler();

        }

        private void updateToggler()
        {
            passwordToggler.Image = showPassword ? global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.hide : global::LCC_ENROLLMENT_SYSTEM.Properties.Resources.show;
        }
    }
}
