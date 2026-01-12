using System;
using System.Windows.Forms;
using System.IO;

namespace Assinment_3
{
    public partial class LoanCalculatorForm : Form
    {
        public string TransactionNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalCost { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentBrand { get; set; }
        public int Quantity { get; set; }
        public string ClientName { get; set; }
        public string ClientPostcode { get; set; }
        public string ClientTelephone { get; set; }
        public string ClientEmail { get; set; }

        private int selectedTerm = 0;
        private decimal monthlyPayment = 0;
        private decimal totalInterest = 0;
        private decimal interestRate = 0;

        public LoanCalculatorForm()
        {
            InitializeComponent();
        }

        private void LoanCalculatorForm_Load(object sender, EventArgs e)
        {
            DisplayOrderSummary();
        }

        //Calculate loan details
        private (decimal monthlyPayment, decimal totalInterest, decimal interestRate) CalculateLoan(int termYears)
        {
            decimal principal = TotalCost;
            decimal annualRate = GetInterestRate(principal, termYears);

            decimal monthlyRate = annualRate / 12;
            int totalMonths = termYears * 12;

            decimal monthlyPay = CalculateMonthlyPayment(principal, monthlyRate, totalMonths);
            decimal totalAmount = monthlyPay * totalMonths;
            decimal totalInt = totalAmount - principal;

            return (Math.Round(monthlyPay, 2), Math.Round(totalInt, 2), annualRate);
        }

        //Get interest rate based on amount
        private decimal GetInterestRate(decimal principal, int termYears)
        {
            if (principal <= 5000)
            {
                if (termYears == 1) return 0.0945m;
                if (termYears == 3) return 0.0835m;
                if (termYears == 5) return 0.0725m;
            }
            else if (principal <= 25000)
            {
                if (termYears == 1) return 0.0885m;
                if (termYears == 3) return 0.0775m;
                if (termYears == 5) return 0.0685m;
            }
            else
            {
                if (termYears == 1) return 0.0785m;
                if (termYears == 3) return 0.0665m;
                if (termYears == 5) return 0.0565m;
            }
            return 0;
        }

        //Calculate monthly payment
        private decimal CalculateMonthlyPayment(decimal principal, decimal monthlyRate, int totalMonths)
        {
            decimal temp = (decimal)Math.Pow(1 + (double)monthlyRate, totalMonths);
            return principal * (monthlyRate * temp) / (temp - 1);
        }

        private string FormatTransactionData()
        {
            string loanInfo = selectedTerm > 0 ?
                $"{selectedTerm} Year Loan|{interestRate:P2}|{monthlyPayment:C2}|{totalInterest:C2}" :
                "No Loan|0%|0|€0.00";

            return $"{TransactionNumber}|{OrderDate:dd/MM/yyyy}|{ClientName}|{ClientPostcode}|{ClientTelephone}|{ClientEmail}|" +
                   $"{EquipmentName}|{EquipmentBrand}|{Quantity}|{TotalCost:C2}|{loanInfo}";
        }

        // Method to save transaction to file
        private void SaveTransactionToFile()
        {
            try
            {
                string filePath = "transactions.txt";
                string transactionData = FormatTransactionData();

                using (StreamWriter writer = new StreamWriter(filePath, true))
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

        private void DisplayOrderSummary()
        {
            string summary = $"ORDER SUMMARY & LOAN OPTIONS\n\n" +
                           $"CLIENT DETAILS:\n" +
                           $"Transaction No: {TransactionNumber}\n" +
                           $"Date: {OrderDate:dd/MM/yyyy}\n" +
                           $"Client Name: {ClientName}\n" +
                           $"Postcode: {ClientPostcode}\n" +
                           $"Telephone: {ClientTelephone}\n" +
                           $"Email: {ClientEmail}\n\n" +
                           $"ORDER DETAILS:\n" +
                           $"Equipment: {EquipmentName}\n" +
                           $"Brand: {EquipmentBrand}\n" +
                           $"Quantity: {Quantity}\n" +
                           $"Total Cost: {TotalCost:C2}\n\n" +
                           $"LOAN FINANCE OPTIONS:\n" +
                           $"Please select a loan term\n\n" +
                           $"INTEREST RATES:\n" +
                           $"Below €5,000: 1Y=9.45% 3Y=8.35% 5Y=7.25%\n" +
                           $"€5,000-€25,000: 1Y=8.85% 3Y=7.75% 5Y=6.85%\n" +
                           $"Above €25,000: 1Y=7.85% 3Y=6.65% 5Y=5.65%\n";

            SummaryLabel.Text = summary;
        }

        private void UpdateLoanDisplay()
        {
            string loanDetails = "";

            if (selectedTerm > 0)
            {
                loanDetails = $"SELECTED: {selectedTerm} Year Loan\n" +
                             $"Interest Rate: {interestRate:P2}\n" +
                             $"Monthly Payment: {monthlyPayment:C2}\n" +
                             $"Total Interest: {totalInterest:C2}\n" +
                             $"Total Amount: {(TotalCost + totalInterest):C2}\n" +
                             $"Click SUBMIT to confirm loan.";
            }
            else
            {
                // Completely Clear loan details for No Loan
                loanDetails = $"SELECTED: No Loan\n" +
                             $"Pay in full: {TotalCost:C2}\n" +
                             $"No monthly payments\n" +
                             $"Click SUBMIT to purchase.";
            }

            // Completely Rebuild the display
            string baseSummary = $"ORDER SUMMARY & LOAN OPTIONS\n\n" +
                               $"CLIENT DETAILS:\n" +
                               $"Transaction No: {TransactionNumber}\n" +
                               $"Date: {OrderDate:dd/MM/yyyy}\n" +
                               $"Client Name: {ClientName}\n" +
                               $"Postcode: {ClientPostcode}\n" +
                               $"Telephone: {ClientTelephone}\n" +
                               $"Email: {ClientEmail}\n\n" +
                               $"ORDER DETAILS:\n" +
                               $"Equipment: {EquipmentName}\n" +
                               $"Brand: {EquipmentBrand}\n" +
                               $"Quantity: {Quantity}\n" +
                               $"Total Cost: {TotalCost:C2}\n\n" +
                               $"LOAN FINANCE OPTIONS:\n{loanDetails}\n\n" +
                               $"INTEREST RATES:\n" +
                               $"Below €5,000: 1Y=9.45% 3Y=8.35% 5Y=7.25%\n" +
                               $"€5,000-€25,000: 1Y=8.85% 3Y=7.75% 5Y=6.85%\n" +
                               $"Above €25,000: 1Y=7.85% 3Y=6.65% 5Y=5.65%\n";

            SummaryLabel.Text = baseSummary;
        }
        private void Noloanradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (Noloanradiobutton.Checked)
            {
                // COMPLETELY RESET all loan variables
                selectedTerm = 0;
                monthlyPayment = 0;
                totalInterest = 0;
                interestRate = 0;

                // FORCE complete display refresh
                UpdateLoanDisplay();
            }
        }

        private void OneYearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OneYearRadioButton.Checked)
            {
                selectedTerm = 1;
                var result = CalculateLoan(1);
                monthlyPayment = result.monthlyPayment;
                totalInterest = result.totalInterest;
                interestRate = result.interestRate;
                UpdateLoanDisplay();
            }
        }

        private void ThreeYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ThreeYearsRadioButton.Checked)
            {
                selectedTerm = 3;
                var result = CalculateLoan(3);
                monthlyPayment = result.monthlyPayment;
                totalInterest = result.totalInterest;
                interestRate = result.interestRate;
                UpdateLoanDisplay();
            }
        }

        private void FiveYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FiveYearsRadioButton.Checked)
            {
                selectedTerm = 5;
                var result = CalculateLoan(5);
                monthlyPayment = result.monthlyPayment;
                totalInterest = result.totalInterest;
                interestRate = result.interestRate;
                UpdateLoanDisplay();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (selectedTerm == 0)
            {
                DialogResult result = MessageBox.Show(
                    $"Confirm purchase without loan?\nTotal: {TotalCost:C2}",
                    "Confirm Purchase",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveTransactionToFile();
                    MessageBox.Show($"Purchase confirmed!\nTransaction: {TransactionNumber}",
                                  "Complete",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    $"Confirm {selectedTerm}-year loan?\nMonthly: {monthlyPayment:C2}\nTotal: {(TotalCost + totalInterest):C2}",
                    "Confirm Loan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveTransactionToFile();
                    MessageBox.Show($"Loan confirmed!\nMonthly: {monthlyPayment:C2}",
                                  "Complete",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}