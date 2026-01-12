using System;
using System.Windows.Forms;
using System.IO;

namespace Assinment_3
{
    public partial class ClientDetailsForm : Form
    {
        // These properties will store the order details passed from main form
        public decimal TotalCost { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentBrand { get; set; }
        public int Quantity { get; set; }

        // These will store the client details and transaction info
        public string TransactionNumber { get; private set; }
        public DateTime OrderDate { get; private set; }
        public string ClientName { get; private set; }
        public string ClientPostcode { get; private set; }
        public string ClientTelephone { get; private set; }
        public string ClientEmail { get; private set; }

        public ClientDetailsForm()
        {
            InitializeComponent();

            // When form loads, generate transaction number and set current date
            TransactionNumber = GenerateTransactionNumber();
            OrderDate = DateTime.Now;

            // Show the transaction number in the textbox (read-only so user can't change it)
            TransNotextBox.Text = TransactionNumber;
            TransNotextBox.ReadOnly = true;

            // Show today's date in the order date field (also read-only)
            OrderDatetextBox.Text = OrderDate.ToString("dd/MM/yyyy");
            OrderDatetextBox.ReadOnly = true;

            // Connect the phone number validation so only numbers can be entered
            PhonenoTextbox.KeyPress += PhonenoTextbox_KeyPress;
        }

        // This method creates a random 8-character transaction number
        private string GenerateTransactionNumber()
        {
            Random random = new Random();
            // We use both letters and numbers for the transaction ID
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] transactionArray = new char[8];

            // Build the 8-character transaction number
            for (int i = 0; i < 8; i++)
            {
                transactionArray[i] = chars[random.Next(chars.Length)];
            }

            return new string(transactionArray);
        }

        // Count how many digits are in the phone number (without using Regex)
        private int CountDigits(string phoneNumber)
        {
            int digitCount = 0;
            foreach (char c in phoneNumber)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }
            return digitCount;
        }

        // Method to save transaction details to the text file
        private void SaveTransactionToFile()
        {
            try
            {
                // Create the transaction data in the correct format
                string transactionData = $"{TransactionNumber}|{OrderDate:dd/MM/yyyy}|{ClientName}|{ClientPostcode}|" +
                                       $"{ClientTelephone}|{ClientEmail}|{EquipmentName}|{EquipmentBrand}|" +
                                       $"{Quantity}|{TotalCost:C2}|Loan Decision Pending";

                // Append to the transactions file
                using (StreamWriter writer = new StreamWriter("transactions.txt", true))
                {
                    writer.WriteLine(transactionData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving transaction: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This runs every time user types in the phone number field
        private void PhonenoTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys like backspace, delete, etc.
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Only allow digits - if user tries to type letters, show warning
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Stop the character from being entered
                MessageBox.Show("Please enter numbers only for phone number.",
                              "Invalid Input",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
            }
        }

        // This runs when user clicks the Proceed button
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            // First check if all fields are filled in
            if (string.IsNullOrWhiteSpace(FullNametextBox.Text) ||
                string.IsNullOrWhiteSpace(PostcodetextBox.Text) ||
                string.IsNullOrWhiteSpace(PhonenoTextbox.Text) ||
                string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MessageBox.Show("Please fill in all client details.", "Missing Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if email looks valid (has @ and .)
            if (!EmailtextBox.Text.Contains("@") || !EmailtextBox.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailtextBox.Focus();
                return;
            }

            // Check if phone number has at least 10 digits
            if (CountDigits(PhonenoTextbox.Text) < 10)
            {
                MessageBox.Show("Please enter a valid phone number with at least 10 digits.", "Invalid Phone Number",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PhonenoTextbox.Focus();
                PhonenoTextbox.SelectAll(); // Highlight the text so user can easily retype
                return;
            }

            // If we get here, all validation passed - save the client details
            ClientName = FullNametextBox.Text.Trim();
            ClientPostcode = PostcodetextBox.Text.Trim();
            ClientTelephone = PhonenoTextbox.Text.Trim();
            ClientEmail = EmailtextBox.Text.Trim();

            // ✅ ADDED: Save the transaction to file before proceeding
            SaveTransactionToFile();

            // Now open the Loan Calculator form and pass all the information to it
            LoanCalculatorForm orderForm = new LoanCalculatorForm();

            // Pass all the order and client details to the loan form
            orderForm.TransactionNumber = TransactionNumber;
            orderForm.OrderDate = OrderDate;
            orderForm.TotalCost = TotalCost;
            orderForm.EquipmentName = EquipmentName;
            orderForm.EquipmentBrand = EquipmentBrand;
            orderForm.Quantity = Quantity;
            orderForm.ClientName = ClientName;
            orderForm.ClientPostcode = ClientPostcode;
            orderForm.ClientTelephone = ClientTelephone;
            orderForm.ClientEmail = ClientEmail;

            // Show the loan form and close this client details form
            orderForm.Show();
            this.Close();
        }
    }
}