using LCC_ENROLLMENT_SYSTEM.Components;
using LCC_ENROLLMENT_SYSTEM.Data;
using LCC_ENROLLMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;

namespace LCC_ENROLLMENT_SYSTEM;

public partial class Login : Form
{
    SuccessDialog successDialog;
    public Login()
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
        if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Please fill all the boxes!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
      
        var db = new AppDbContext();
        LoadingForm loadingForm = new();
        loadingForm.Message = "Logging in, please wait...";
        loadingForm.Duration = 0;

       
        List<User> users = new();

        await Task.Run(new Action(() =>
        {
            // Display dialog modally
            this.BeginInvoke(new Action(() =>
            {
                loadingForm.ShowDialog();
            }));
            // Begin long-running method here
             users = db.Users
                .Where(a => a.Username == username)
                .ToList(); 
        })).ContinueWith(new Action<Task>(task =>
        {
            // Close modal dialog
            loadingForm.Close();
            if (users.Count > 0)
            {
                User user = users[0];
                if (user.Password.Equals(password))
                {
                    AppManager.CurrentUser = user;
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

    private void Login_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}