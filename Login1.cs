using System;
using System.Windows.Forms;

namespace Assinment_3
{
    public partial class Login1 : Form
    {
        // This is the password we need to check against
        private const string CORRECT_PASSWORD = "ILuvVisualC#";

        // We only allow 3 tries before locking out
        private const int MAX_ATTEMPTS = 3;

        // Keeps track of how many wrong passwords were entered
        private int loginAttempts = 0;

        public Login1()
        {
            InitializeComponent();
            SetupForm();
        }
        private void SetupForm()
        {
            // Hide the password characters with *
            PasswordtextBox.PasswordChar = '*';

            // Add keyboard shortcuts - Alt+L for Login, Alt+X for Exit
            LoginButton.Text = "&Login";
            ExitButton.Text = "E&xit";

            // Put focus on the username field so user can start typing right away
            SalespersonnametextBox.Focus();
        }

        // Checks if the login details are correct
        private bool CheckLoginDetails(string username, string password)
        {
            // Password must match AND username can't be empty
            return (password == CORRECT_PASSWORD && !string.IsNullOrWhiteSpace(username));
        }

        // Tells us how many attempts are left
        private int CalculateRemainingAttempts()
        {
            return MAX_ATTEMPTS - loginAttempts;
        }

        // What happens when login works
        private void ProcessSuccessfulLogin(string salespersonName)
        {
            MessageBox.Show($"Login successful! Welcome {salespersonName}.",
                          "Success",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);

            // Open the main sales form and hide this login form
            Neart4U mainForm = new Neart4U();
            mainForm.Show();
            this.Hide();
        }

        // What happens when login fails
        private void ProcessFailedLogin()
        {
            loginAttempts++;  // Increase the failed attempt counter
            int attemptsLeft = CalculateRemainingAttempts();

            if (attemptsLeft > 0)
            {
                // Still have tries left
                MessageBox.Show($"Incorrect password. You have {attemptsLeft} attempt(s) remaining.",
                              "Login Failed",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                PasswordtextBox.Text = "";  // Clear the password field
                PasswordtextBox.Focus();    // Put cursor back in password field
            }
            else
            {
                // No tries left - close the application
                MessageBox.Show("Maximum login attempts reached. Application will now close.",
                              "Access Denied",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Makes sure user entered both username and password
        private bool ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(SalespersonnametextBox.Text))
            {
                MessageBox.Show("Please enter your name.",
                              "Missing Information",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                SalespersonnametextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(PasswordtextBox.Text))
            {
                MessageBox.Show("Please enter your password.",
                              "Missing Information",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                PasswordtextBox.Focus();
                return false;
            }

            return true;  // Everything looks good
        }

        // This runs when user clicks the Login button
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string salespersonName = SalespersonnametextBox.Text.Trim();
            string password = PasswordtextBox.Text;

            // First check if user entered both fields
            if (!ValidateUserInput())
                return;

            // Now check if the password is correct
            if (CheckLoginDetails(salespersonName, password))
            {
                ProcessSuccessfulLogin(salespersonName);
            }
            else
            {
                ProcessFailedLogin();
            }
        }
    }
}