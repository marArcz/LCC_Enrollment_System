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
    public partial class ChangeSchoolYear : Form
    {
        List<int> fromYears;
        List<int> toYears;

        private int to;
        private int from;

        public int From { get => from; set => from = value; }
        public int To { get => to; set => to = value; }

        public ChangeSchoolYear(ref int from, ref int to)
        {
            InitializeComponent();
            this.From = from;
            this.To = to;
            LoadFromYears();
            comboBoxFrom.SelectedItem = from;
            LoadToYears();
            comboBoxTo.SelectedItem = to;
        }

        public void LoadFromYears()
        {
            int currentYear = DateTime.Now.Year;
            fromYears = new();
            comboBoxFrom.Items.Clear();
            for (int x = 2000; x < currentYear; x++)
            {
                fromYears.Add(x);
                comboBoxFrom.Items.Add(x);
            }
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadToYears();
            if (comboBoxTo.Items.Count > 0) comboBoxTo.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            From = (int) comboBoxFrom.SelectedItem;
            To = (int) comboBoxTo.SelectedItem;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadToYears()
        {
            int currentYear = DateTime.Now.Year;
            toYears = new();
            comboBoxTo.Items.Clear();
            int selectedFrom = (int) comboBoxFrom.SelectedItem;
            for (int x = selectedFrom + 1; x <= currentYear; x++)
            {
                toYears.Add(x);
                comboBoxTo.Items.Add(x);
            }
            
        }

    }
}
