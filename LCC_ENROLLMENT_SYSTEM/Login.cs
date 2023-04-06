using LCC_ENROLLMENT_SYSTEM.Components;
using LCC_ENROLLMENT_SYSTEM.Data;
using LCC_ENROLLMENT_SYSTEM.Models;

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

    private void button1_Click(object sender, EventArgs e)
    {
        string username = textBoxUsername.Text;
        string password = textBoxPassword.Text;

        if(String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Please fill all the boxes!");
            return;
        }

        using (var db = new AppDbContext())
        {
            var admins = db.Admins
                .Where(a => a.username == username)
                .ToList();
            if(admins.Count > 0)
            {
                Admin admin = admins[0];
                if(admin.password == password) {
                    /*MessageBox.Show("Successfully logged in!");*/
                    successDialog.ShowSuccess("Successfully logged in!",this);
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
        }
    }

    private void textBoxUsername_TextChanged(object sender, EventArgs e)
    {

    }

    private void login_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
}