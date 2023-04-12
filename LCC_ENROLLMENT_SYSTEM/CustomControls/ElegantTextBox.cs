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
    public partial class ElegantTextBox : UserControl
    {
        public enum InputType
        {
            Text,
            Password
        }
        private Color borderColor = Color.Red;
        private int borderSize = 1;
        private int borderRadius = 3;
        private Image icon;
        private string hint = "Username";
        private bool floatingLabel = true;
        private InputType textBoxInputType = InputType.Text;
        private string textContent = String.Empty;

        public Color BorderColor { get => borderColor;
            set
            {
                borderColor = value;
                updateControls();
            }
        }
        public int BorderSize { get => borderSize;
            set
            {
                borderSize = value;
                updateControls();
            }
        }
        public int BorderRadius { get => borderRadius;
            set
            {
                borderRadius = value;
                updateControls();
            }
        }
        public Image Icon { get => icon;
            set
            {
                icon = value;
                updateControls();
            }
        }
        public string Hint { get => hint;
            set
            {
                hint = value;
                updateControls();
            }
        }
        public bool FloatingLabel { get => floatingLabel; set => floatingLabel = value; }
        public InputType TextBoxInputType { get => textBoxInputType;
            set
            {
                textBoxInputType = value;
                updateControls();
            }
        }

        public string TextContent {
            get
            {
                return textBox.Text;
            }
            set
            {
                textContent = value;
                textBox.Text = value;
                updateControls();
            }
        }

        public ElegantTextBox()
        {
            InitializeComponent();

            this.BackColor= Color.Transparent;
            borderedPanel1.BorderColor = this.BorderColor;
            borderedPanel1.BorderRadius = this.BorderRadius;
            borderedPanel1.BorderSize = this.BorderSize;
            textBox.PlaceholderText = Hint;
            label.Text = Hint;
            label.ForeColor = BorderColor;
            pictureBox.Image = icon;
            label.Visible = false;
            textBox.PasswordChar = TextBoxInputType == InputType.Text ? '\0' : '*';
            textBox.Text = textContent;
            textBox.ForeColor = BorderColor;
           
        }

        private void updateControls()
        {
            textBox.ForeColor = BorderColor;
            textBox.Text = textContent;
            borderedPanel1.BorderColor = this.BorderColor;
            borderedPanel1.BorderRadius = this.BorderRadius;
            borderedPanel1.BorderSize = this.BorderSize;
            textBox.PlaceholderText = Hint;
            label.Text = Hint;
            pictureBox.Image = icon;
            label.ForeColor = BorderColor;
            textBox.PasswordChar = TextBoxInputType == InputType.Text ? '\0' : '*';
        }

        private void borderedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            label.Visible = FloatingLabel;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox.Text))
            {
                label.Visible = false;
            }
        }
    }
}
