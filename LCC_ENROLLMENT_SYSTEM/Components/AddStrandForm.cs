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

namespace LCC_ENROLLMENT_SYSTEM.Components
{
    public partial class AddStrandForm : Form
    {
        List<Track> tracks = new();
        public AddStrandForm()
        {
            InitializeComponent();
            LoadTracks();   
        }

        private void LoadTracks()
        {
            AppDbContext db = new();
            tracks = db.Tracks.ToList();
            comboBoxTrack.Items.Clear();
            foreach (var item in tracks)
            {
                comboBoxTrack.Items.Add(item.Name);
            }

            if (comboBoxTrack.Items.Count > 0) comboBoxTrack.SelectedIndex = 0;

        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDbContext db = new();
            var trackId = tracks.ElementAt(comboBoxTrack.SelectedIndex).Id;
            var strand = textBoxStrand.Texts;

            Strand newStrand = new() { TrackId = trackId, Name = strand };
            db.Strands.Add(newStrand);

            if(db.SaveChanges() < 0)
            {

            }
            else
            {
                SuccessDialog.ShowMesage("Successfully added new strand!");
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
