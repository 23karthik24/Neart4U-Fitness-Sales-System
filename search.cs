using System;
using System.Windows.Forms;
using System.IO;

namespace Assinment_3
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        // Search by transaction number
        private string SearchByTransactionNumber(string searchTerm)
        {
            try
            {
                if (File.Exists("transactions.txt"))
                {
                    using (StreamReader reader = new StreamReader("transactions.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Check if this line matches the transaction number
                            if (line.StartsWith(searchTerm + "|"))
                            {
                                return line; // Found the transaction
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null; // Not found
        }

        // Search by email
        private string SearchByEmail(string searchTerm)
        {
            string results = "";
            int foundCount = 0;

            try
            {
                if (File.Exists("transactions.txt"))
                {
                    using (StreamReader reader = new StreamReader("transactions.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Split the line to check email (field 5)
                            string[] parts = line.Split('|');
                            if (parts.Length >= 6)
                            {
                                // Check if email matches (case insensitive)
                                if (parts[5].ToLower() == searchTerm.ToLower())
                                {
                                    foundCount++;
                                    results += FormatTransactionForDisplay(line) + "\n\n";
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (foundCount > 0)
            {
                return $"SEARCH RESULTS - Found {foundCount} transaction(s):\n\n" + results;
            }
            return null; // No transactions found for this email
        }

        //Transaction for display 
        private string FormatTransactionForDisplay(string transactionData)
        {
            string[] parts = transactionData.Split('|');

            if (parts.Length >= 11)
            {
                return $"═══════════════════════════════════════════════\n" +
                       $"TRANSACTION NUMBER: {parts[0]}\n" +
                       $"DATE: {parts[1]}\n" +
                       $"CLIENT NAME: {parts[2]}\n" +
                       $"POSTCODE: {parts[3]}\n" +
                       $"TELEPHONE: {parts[4]}\n" +
                       $"EMAIL: {parts[5]}\n" +
                       $"EQUIPMENT: {parts[6]}\n" +
                       $"BRAND: {parts[7]}\n" +
                       $"QUANTITY: {parts[8]}\n" +
                       $"TOTAL COST: {parts[9]}\n" +
                       $"LOAN INFORMATION: {parts[10]}\n" +
                       $"═══════════════════════════════════════════════";
            }

            return "Invalid transaction format";
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string searchText = Searchtextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a Transaction Number or Email address to search.",
                              "Missing Search Term",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!transradiobutton.Checked && !emailradioButton.Checked)
            {
                MessageBox.Show("Please select search type (Transaction No or Email).",
                              "Select Search Type",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Search based on selected type
            if (transradiobutton.Checked)
            {
                // Search by transaction number
                string foundTransaction = SearchByTransactionNumber(searchText);

                if (foundTransaction != null)
                {
                    OutputLabel.Text = $"SEARCH RESULTS - Found 1 transaction(s):\n\n" +
                                     FormatTransactionForDisplay(foundTransaction);
                }
                else
                {
                    OutputLabel.Text = "No transactions found matching your search criteria.\n\n" +
                                     "Please check your search term and try again.";
                }
            }
            else if (emailradioButton.Checked)
            {
                // Search by email
                string emailResults = SearchByEmail(searchText);

                if (emailResults != null)
                {
                    OutputLabel.Text = emailResults;
                }
                else
                {
                    OutputLabel.Text = "No transactions found matching your search criteria.\n\n" +
                                     "Please check your search term and try again.";
                }
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // Check if transactions file Exists or Not
            if (!File.Exists("transactions.txt"))
            {
                OutputLabel.Text = "Welcome to Search Transactions!\n\n" +
                                 "No transactions file found yet.\n" +
                                 "Please complete an order first to see transactions here.";
            }
            else
            {
                OutputLabel.Text = "Welcome to Search Transactions!\n\n" +
                                 "• Select 'Transaction No' to search by transaction number\n" +
                                 "• Select 'Email' to find all orders for a client\n" +
                                 "• Enter your search term and click SEARCH";
            }
        }
        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            Searchtextbox.Text = "";
            transradiobutton.Checked = false;
            emailradioButton.Checked = false;
            OutputLabel.Text = "Welcome to Search Transactions!\n\n" +
                             "• Select 'Transaction No' to search by transaction number\n" +
                             "• Select 'Email' to find all orders for a client\n" +
                             "• Enter your search term and click SEARCH";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}