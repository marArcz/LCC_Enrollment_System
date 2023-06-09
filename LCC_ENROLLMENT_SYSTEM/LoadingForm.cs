﻿using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC_ENROLLMENT_SYSTEM
{
    public partial class LoadingForm : Form
    {
        private string message = "Please wait...";
        private int duration = 200;

        public string Message { get => message;
            set
            {
                message = value;
                labelMessage.Text = value;
            }
        }

        public int Duration { get => duration; set => duration = value; }

        public LoadingForm()
        {
            InitializeComponent();
            labelMessage.Text = message;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(duration);
                    worker.ReportProgress(i * 10);
                }
            }
        }

        public void startProgressBar()
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = 100;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            if(duration > 0)
            {
                startProgressBar();
            }
        }
     

        public static void ShowLoading(string message,int duration=200)
        {
            var form = new LoadingForm();
            form.message = message;
            form.duration = duration;

            form.ShowDialog();
        }
    }
}
