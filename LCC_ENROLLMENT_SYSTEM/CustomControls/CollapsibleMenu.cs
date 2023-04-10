using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC_ENROLLMENT_SYSTEM.CustomControls
{
    public partial class CollapsibleMenu : UserControl
    {
        public class MenuItemButton {
            private string text;
            private string tab;

            public string Text { get => text; set => text = value; }
            public string Tab { get => tab; set => tab = value; }
        }

        private List<MenuItemButton> menuItems;
        private int itemHeight;
        private int menuWidth;
        private bool toggled = false;

        public CollapsibleMenu()
        {
            InitializeComponent();
            this.menuItems = new List<MenuItemButton>();
            this.itemHeight = collapsibleToggler1.Height + 20;
            collapsibleToggler1.Toggled = Toggled;
            collapsibleToggler1.Click += onToggle;
            MenuWidth = 110;
            this.Height = itemHeight;
        }

        private void onToggle(Object? sender, EventArgs e)
        {
            Toggled = !Toggled;
            collapsibleToggler1.Toggled = Toggled;
        }

        private void updateMenuState()
        {
            this.Height = toggled ? (menuItems.Count() + 1) * itemHeight : itemHeight;

        }

        public List<MenuItemButton> MenuItems { get => menuItems; set
            {
                menuItems = value;
                LoadMenu();
            }
        }
        public int ItemHeight { get => itemHeight; set => itemHeight = value; }
        public int MenuWidth { get => menuWidth; set
            {
                menuWidth = value;
                collapsibleToggler1.Width = value;
                this.Width = value + 3;

            }
        }
        public bool Toggled { get => toggled; set
            {
                toggled = value;
                collapsibleToggler1.Toggled = value;
                if (toggled)
                {
                    this.Height = itemHeight * (menuItems.Count() + 1);
                }
                else
                {
                    this.Height = itemHeight;
                }
            }
        }

        private void LoadMenu()
        {
            flowLayoutPanel1.Controls.Clear();

            MenuButton menuButton = new();
            menuButton.Width = menuWidth;
            menuButton.Height = itemHeight;
            menuButton.BackColor = collapsibleToggler1.BackColor;

            foreach(MenuItemButton item in menuItems) {
                menuButton.BtnText = item.Text;
                menuButton.Tab1 = item.Tab;
                flowLayoutPanel1.Controls.Add(menuButton);
            }
            this.Height = toggled ? (menuItems.Count() + 1) * itemHeight : itemHeight;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
           
            base.OnPaint(e);
        }
        private void CollapsibleMenu_Load(object sender, EventArgs e)
        {

        }


    }
}
