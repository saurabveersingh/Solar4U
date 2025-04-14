namespace Solar4U
{
    public partial class LoanForm : Form
    {
        // Loan Slab Data
        const decimal LOAN_SLAB_1 = 15000m;
        const decimal LOAN_SLAB_2 = 30000m;

        // Loan Term Data
        const int LOAN_TERM_1 = 1;
        const int LOAN_TERM_2 = 3;
        const int LOAN_TERM_3 = 5;

        // Loan Interest Rate Data
        const decimal LOAN_INTEREST_1 = 0.085m;
        const decimal LOAN_INTEREST_2 = 0.08m;
        const decimal LOAN_INTEREST_3 = 0.075m;
        const decimal LOAN_INTEREST_4 = 0.0815m;
        const decimal LOAN_INTEREST_5 = 0.0755m;
        const decimal LOAN_INTEREST_6 = 0.0685m;
        const decimal LOAN_INTEREST_7 = 0.0785m;
        const decimal LOAN_INTEREST_8 = 0.0725m;
        const decimal LOAN_INTEREST_9 = 0.0615m;

        // Field Variables
        string nameDetailsText, postcodeDetailsText, phoneDetailsText, emailDetailsText, netValDetailsText;
        decimal multiplierA = 1m, multiplierB = 1m, multiplierC = 1m, repaymentA, repaymentB, repaymentC;

        // Shared Variables
        public bool clearForm { get; private set; } = false;

        public LoanForm()
        {
            InitializeComponent();
        }

        // Event Handlers

        // Go back to Main form
        private void BackButton_Click(object sender, EventArgs e)
        {
            // Closes the Form App
            this.Close();
        }

        // Get Order Confirmation
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            // fetch selected loan details
            int loanTerm = 0;
            decimal interest = 0m;
            decimal repayment = 0m;

            if (loanOption1.Checked)
            {
                loanTerm = LOAN_TERM_1;
                interest = multiplierA - 1;
                repayment = repaymentA;
            }
            else if (loanOption2.Checked)
            {
                loanTerm = LOAN_TERM_2;
                interest = multiplierB - 1;
                repayment = repaymentB;
            }
            else if (loanOption3.Checked)
            {
                loanTerm = LOAN_TERM_3;
                interest = multiplierC - 1;
                repayment = repaymentC;
            }
            else
            {
                loanOption4.Checked = true;
            }

            // Show order confirmation message box
            string res = "";
            if (loanTerm == 0)
            {
                res = MessageBox.Show($"Net Value: {netValDetailsText}", "Are you sure that you wish to confirm this order without a loan option?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            }
            else
            {
                string loanDetails = $"System Cost: {netValDetailsText}\nLoan Term: {loanTerm}\nInterest Rate: {interest.ToString("P2")}\nRepayment Amount: {repayment.ToString("C2")}";
                res = MessageBox.Show($"{loanDetails}", "Do you wish to confirm this order?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            }

            if (res == "No" || res == "") return;

            // Create order when user confirms.
            CreateOrder(loanTerm, interest, repayment);

            // Update Summary
            Solar4UFormApp.UpdateSummaryFile();

            // set clear form to true
            clearForm = true;

            this.Hide();
        }

        // Helper Functions

        // Show order details and loan offers to user.
        public void DisplayLoanOffer(string clientName, string clientPostcode, string clientPhone, string clientEmail, decimal netVal)
        {
            // Update Field Variables
            nameDetailsText = clientName;
            postcodeDetailsText = clientPostcode;
            phoneDetailsText = clientPhone;
            emailDetailsText = clientEmail;
            netValDetailsText = netVal.ToString("C2");

            // Update Order Details
            transactionNumber.Text = Solar4UFormApp.currentTransactionNumber.ToString();
            shortDate.Text = Solar4UFormApp.currentDate;
            nameDetails.Text = clientName;
            postcodeDetails.Text = clientPostcode;
            phoneDetails.Text = clientPhone;
            emailDetails.Text = clientEmail;
            panelsDetails.Text = Solar4UFormApp.panelDetailsText;
            batteryDetails.Text = Solar4UFormApp.batteryDetailsText;
            invertorDetails.Text = Solar4UFormApp.invertorDetailsText;
            installationDetails.Text = Solar4UFormApp.installationDetailsText;
            netValDetails.Text = netVal.ToString("C2");

            // Update Loan Option Details
            UpdateLoanOptions(netVal);

            // Show loan offer
            loanOffer.Text = $"*Free System Insurance on {LOAN_TERM_3} Year loan term!";
        }

        // Update Loan Option Details
        private void UpdateLoanOptions(decimal netVal)
        {
            // Update multipliers relavant to loan slab and term
            if (netVal < LOAN_SLAB_1) // If loan amount is less than first slab
            {
                multiplierA += LOAN_INTEREST_1;
                multiplierB += LOAN_INTEREST_2;
                multiplierC += LOAN_INTEREST_3;
            }
            else if (netVal < LOAN_SLAB_2) // If loan amount is equal to or more than first slab but less than second slab
            {
                multiplierA += LOAN_INTEREST_4;
                multiplierB += LOAN_INTEREST_5;
                multiplierC += LOAN_INTEREST_6;
            }
            else // If loan amount is equal to or more than second slab
            {
                multiplierA += LOAN_INTEREST_7;
                multiplierB += LOAN_INTEREST_8;
                multiplierC += LOAN_INTEREST_9;
            }

            //Calculate repayments
            repaymentA = netVal;
            repaymentB = netVal;
            repaymentC = netVal;
            for (int i = 1; i <= LOAN_TERM_3; i++)
            {
                if (i <= LOAN_TERM_1) repaymentA *= multiplierA;
                if (i <= LOAN_TERM_2) repaymentB *= multiplierB;
                if (i <= LOAN_TERM_3) repaymentC *= multiplierC;
            }

            // Update loan options
            loanOption1.Text = $"{LOAN_TERM_1} Year ({(multiplierA - 1).ToString("P2")}), Repayment = {(repaymentA.ToString("C2"))}";
            loanOption2.Text = $"{LOAN_TERM_2} Year ({(multiplierB - 1).ToString("P2")}), Repayment = {(repaymentB.ToString("C2"))}";
            loanOption3.Text = $"{LOAN_TERM_3} Year ({(multiplierC - 1).ToString("P2")}), Repayment = {(repaymentC.ToString("C2"))}";
        }

        // Create new Order File
        public void CreateOrder(int loanTerm, decimal interest, decimal repayment)
        {
            try
            {
                StreamWriter outputFile = File.CreateText($"{Solar4UFormApp.currentTransactionNumber}.txt");
                outputFile.WriteLine(Solar4UFormApp.currentTransactionNumber);
                outputFile.WriteLine(Solar4UFormApp.currentDate);
                outputFile.WriteLine(nameDetailsText);
                outputFile.WriteLine(postcodeDetailsText);
                outputFile.WriteLine(phoneDetailsText);
                outputFile.WriteLine(emailDetailsText);
                outputFile.WriteLine(Solar4UFormApp.panelDetailsText);
                outputFile.WriteLine(Solar4UFormApp.batteryDetailsText);
                outputFile.WriteLine(Solar4UFormApp.invertorDetailsText);
                outputFile.WriteLine(netValDetailsText);
                outputFile.WriteLine(loanTerm);
                if (loanTerm > 0)
                {
                    outputFile.WriteLine(interest.ToString("P2"));
                    outputFile.WriteLine(repayment.ToString("C2"));
                }
                outputFile.Close();
            }
            catch(Exception ex)
            {
                Solar4UFormApp.DisplayError("There was an unexpected error while creating the order file");
            }
        }
    }
}
