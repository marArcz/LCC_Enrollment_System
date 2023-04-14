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
    public partial class UpdateStrandForm : Form
    {
        List<Track> tracks;
        private int id;
        public UpdateStrandForm(int id)
        {
            InitializeComponent();
            LoadTracks();
            this.id = id;
            LoadData();
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
            
        }

        private void LoadData()
        {
            AppDbContext db = new();
            var strand = db.Strands.Find(id);
            comboBoxTrack.SelectedIndex = tracks.IndexOf(tracks.Find(t => t.Id == strand.TrackId));
            textBoxStrand.Texts = strand.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDbContext db = new();
            var trackId = tracks.ElementAt(comboBoxTrack.SelectedIndex).Id;
            var strand = textBoxStrand.Texts;

            var strandModel = db.Strands.Find(id);
            strandModel.TrackId = trackId;
            strandModel.Name = strand;

            if (db.SaveChanges() < 0)
            {

            }
            else
            {
                SuccessDialog.ShowMesage("Successfully updated strand!");
                this.Close();
            }
        }
    }
}
