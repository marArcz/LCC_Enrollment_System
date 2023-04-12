using LCC_ENROLLMENT_SYSTEM.Components;
using LCC_ENROLLMENT_SYSTEM.Data;
using LCC_ENROLLMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;

namespace LCC_ENROLLMENT_SYSTEM;

public partial class btnLogin : Form
{
    SuccessDialog successDialog;
    public btnLogin()
    {
        InitializeComponent();
        successDialog = new();
    }

    private void Login_Load(object sender, EventArgs e)
    {
        
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        string username = usernameBox.TextContent;
        string password = passwordBox.TextContent;
        var db = new AppDbContext();
        LoadingForm loadingForm = new();
        loadingForm.Message = "Logging in, please wait...";
        loadingForm.Duration = 0;

        if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Please fill all the boxes!","Required",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            return;
        }
        List<Admin> admins = new();

        await Task.Run(new Action(() =>
        {
            // Display dialog modally
            // Use BeginInvoke here to avoid blocking
            //   and illegal cross threading exception
            this.BeginInvoke(new Action(() =>
            {
                loadingForm.ShowDialog();
            }));
            // Begin long-running method here
             admins = db.Admins
                .Where(a => a.username == username)
                .ToList(); 
        })).ContinueWith(new Action<Task>(task =>
        {
            // Close modal dialog
            // No need to use BeginInvoke here
            //   because ContinueWith was called with TaskScheduler.FromCurrentSynchronizationContext()
            loadingForm.Close();
            if (admins.Count > 0)
            {
                Admin admin = admins[0];
                if (admin.password == password)
                {
                    /*MessageBox.Show("Successfully logged in!");*/
                    //MessageBox.Show("Successfully logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadingForm.Close();
                    SuccessDialog.ShowMesage("Successfully logged in!");
                    new Home().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sorry you entered an incorrect password!");

                }
            }
            else
            {
                MessageBox.Show("Sorry no matching account found!");
            }
        }), TaskScheduler.FromCurrentSynchronizationContext());
    }

    private void textBoxUsername_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
}