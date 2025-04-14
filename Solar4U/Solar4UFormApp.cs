using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Transactions;

namespace Solar4U
{
    public partial class Solar4UFormApp : Form
    {
        // Panel Brand Data
        const string PANEL_1_BRAND = "LONGi Solar",
            PANEL_2_BRAND = "JinkoSolar",
            PANEL_3_BRAND = "Trina Solar",
            PANEL_4_BRAND = "CanadianSolar",
            PANEL_5_BRAND = "Q-Cells",
            PANEL_6_BRAND = "FirstSolar";

        const decimal PANEL_1_PRICE = 129.5m,
            PANEL_2_PRICE = 135m,
            PANEL_3_PRICE = 112.79m,
            PANEL_4_PRICE = 149m,
            PANEL_5_PRICE = 131m,
            PANEL_6_PRICE = 119m;

        // Panel Size and Discount Data
        const int PANEL_SIZE_1 = 30,
            PANEL_SIZE_2 = 48,
            PANEL_SIZE_3 = 60,
            PANEL_SIZE_4 = 72,
            PANEL_SIZE_5 = 84,
            PANEL_SIZE_6 = 96,
            DISCOUNT_SIZE = 700;

        const decimal PANEL_SIZE_1_PERCENT = -.25m,
            PANEL_SIZE_2_PERCENT = -.15m,
            PANEL_SIZE_3_PERCENT = 0m,
            PANEL_SIZE_4_PERCENT = .15m,
            PANEL_SIZE_5_PERCENT = .25m,
            PANEL_SIZE_6_PERCENT = .4m,
            DISCOUNT_PERCENT = .03m;

        // Battery Data
        const string BATTERY_1_SIZE = "20KWh",
            BATTERY_2_SIZE = "10KWh",
            BATTERY_3_SIZE = "5KWh",
            BATTERY_4_SIZE = "Not Required";

        const decimal BATTERY_1_PRICE = 9500m,
            BATTERY_2_PRICE = 7500m,
            BATTERY_3_PRICE = 4500m,
            BATTERY_4_PRICE = 0;

        // Invertor and Installation Data
        const string INVERTOR_1_TYPE = "Regular without Battery",
            INVERTOR_2_TYPE = "Large without Battery",
            INVERTOR_3_TYPE = "Regular with Battery",
            INVERTOR_4_TYPE = "Large with Battery",
            INSTALLATION_1_TYPE = "Regular Install",
            INSTALLATION_2_TYPE = "Expedited Install";

        const decimal INVERTOR_1_PRICE = 650m,
            INVERTOR_2_PRICE = 950m,
            INVERTOR_3_PRICE = 1150m,
            INVERTOR_4_PRICE = 1350m,
            INSTALLATION_1_PRICE = 499m,
            INSTALLATION_2_PRICE = 798m;

        // File Paths
        const string SUMMARY_FILE_PATH = "summary.txt";

        // Field Variables
        public static int numOfOrders { get; private set; }
        public static int numOfDiscounts { get; private set; }
        public static int numOfPanels { get; private set; }
        public static int numOfCells { get; private set; }
        public static int currentTransactionNumber { get; private set; }
        public static decimal totalPanelsCost { get; private set; }
        public static decimal totalBatteriesCost { get; private set; }
        public static decimal totalInvertorsCost { get; private set; }
        public static decimal totalInstallationsCost { get; private set; }
        public static decimal totalDiscountVal { get; private set; }
        public static decimal panelsCost { get; private set; }
        public static decimal batteryCost { get; private set; }
        public static decimal invertorCost { get; private set; }
        public static decimal installationCost { get; private set; }
        public static decimal discountVal { get; private set; }
        public static string panelDetailsText { get; private set; }
        public static string batteryDetailsText { get; private set; }
        public static string invertorDetailsText { get; private set; }
        public static string installationDetailsText { get; private set; }
        public static string currentDate { get; private set; }

        public Solar4UFormApp()
        {
            InitializeComponent();
        }

        // Home Panels Event Handlers

        // Form Load Event Handler
        private void Solar4UFormApp_Load(object sender, EventArgs e)
        {
            // Checks if summary button should be enabled
            UpdateSummaryVariables();
            summaryButton.Enabled = numOfOrders > 0;
        }

        // Displays a Detailed Price Quote based on User Inputs
        private void QuoteButton_Click(object sender, EventArgs e)
        {
            // Validate Data
            if (!ValidateQuoteInputs()) return;

            // Disable Quote Button to prevent multiple clicks
            quoteButton.Enabled = false;

            // User is allowed to switch between summary and quote screens using buttons when one or more order exist.
            summaryButton.Enabled = numOfOrders > 0;

            // Enable Order Button
            orderButton.Enabled = true;

            // Enable Search Button
            searchButton.Enabled = true;

            // Update Costs in field variables
            UpdateQuoteCosts();

            // Update Quote Summary Panel
            ShowQuoteSummary();
        }

        // Resets the Form
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Disable Order Button
            orderButton.Enabled = false;

            // Reset Inputs
            brandList.ClearSelected();
            sizeList.ClearSelected();
            quantityInput.Text = "0";
            battery1RadioButton.Checked = false;
            battery2RadioButton.Checked = false;
            battery3RadioButton.Checked = false;
            battery4RadioButton.Checked = false;
            expInstallCheckBox.Checked = false;

            // Hide Discount Offer
            discountOffer.Visible = false;

            // Enable Buttons
            quoteButton.Enabled = true;
            searchButton.Enabled = true;
            summaryButton.Enabled = numOfOrders > 0;

            // Hide panels
            ShowClientDetailsPanel(false);
            summaryPanel.Visible = false;
        }

        // Confirms order details with client and asks for client details
        private void OrderButton_Click(object sender, EventArgs e)
        {
            // Prepare Continue Order Message
            decimal netVal = panelsCost + batteryCost + invertorCost + installationCost;
            string orderDetails = $"{panelDetailsText}\nBattery {batteryDetailsText}\nInvertor {invertorDetailsText}\n{installationDetailsText}\nTotal Cost {netVal.ToString("C2")}";

            // Continue Order Message Box
            string res = MessageBox.Show($"{orderDetails}", "Do you wish to continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            // Return if User doesn't confirm order. 
            if (res == "No") return;

            // Displays client details panel
            ShowClientDetailsPanel(true);

            // Prepare Client Form
            PrepareClientForm();
        }

        // Displays a summary of previous orders.
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            // Disable Summary Button to avoid multiple clicks
            summaryButton.Enabled = false;

            // Enables user to switch between quote and summary screens when required inputs are provided.
            quoteButton.Enabled = true;

            // Disables order button until user has the quotation clearly visible.
            orderButton.Enabled = false;

            // Enable search Button
            searchButton.Enabled = true;

            // Update Summary Panel Data
            noOfOrdersLabel.Visible = true;
            noOfOrders.Visible = true;
            noOfOrders.Text = numOfOrders.ToString("N0");

            decimal grossVal = totalPanelsCost + totalBatteriesCost + totalInvertorsCost + totalInstallationsCost;
            decimal netVal = grossVal - totalDiscountVal;

            panelDetails.Visible = false;
            panelsCostValue.Text = totalPanelsCost.ToString("C2");
            panelsPercentage.Text = (totalPanelsCost / netVal).ToString("P2");

            batteryDetails.Visible = false;
            batteriesCostValue.Text = totalBatteriesCost.ToString("C2");
            batteriesPercentage.Text = (totalBatteriesCost / netVal).ToString("P2");

            invertorDetails.Visible = false;
            invertorsCostValue.Text = totalInvertorsCost.ToString("C2");
            invertorsPercentage.Text = (totalInvertorsCost / netVal).ToString("P2");

            installationDetails.Visible = false;
            installationCostValue.Text = totalInstallationsCost.ToString("C2");
            installationPercentage.Text = (totalInstallationsCost / netVal).ToString("P2");

            grossValue.Text = grossVal.ToString("C2");
            discountValue.Text = totalDiscountVal.ToString("C2");
            netValue.Text = netVal.ToString("C2");

            averageValueLabel.Visible = true;
            averageValue.Visible = true;
            averageValue.Text = (netVal / numOfOrders).ToString("C2");

            noOfDiscountsLabel.Visible = true;
            noOfDiscounts.Visible = true;
            noOfDiscounts.Text = numOfDiscounts.ToString("N0");

            // Show summary panel
            summaryPanel.Visible = true;

            // Hide Search Panel
            searchPanel.Visible = false;
        }

        // Displays Search Options
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = true;
            summaryPanel.Visible = false;
            searchOption1.Checked = false;
            searchOption2.Checked = false;
            searchLabel.Visible = false;
            searchInput.Clear();
            searchInput.Visible = false;
            enterButton.Visible = false;
            searchResults.Visible = false;
            openButton.Visible = false;
        }

        // Closes the Form App
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Handle panel brand input change
        private void BrandList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Handle panel size input change
        private void SizeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Offers Discount if conditions are met and updates quotation if its visible
            OfferDiscount(sender, e);
        }

        // Handle panel quantity input change
        private void QuantityInput_TextChanged(object sender, EventArgs e)
        {
            string quantity = quantityInput.Text;

            // Panel quantity can be zero or less at this stage for smooth UI.
            // However, user recieves an error message on click of quote button with a panel quantity less than 1.
            // User also recieves an error message dynamically when panel quantity is changed to less than 1 while quotation is visible.
            if (quantity == "")
            {
                numOfPanels = 0;
            }
            else
            {
                try
                {
                    numOfPanels = int.Parse(quantity);
                }
                catch (Exception ex)
                {
                    DisplayError("Please Enter a valid panel quantity");
                    quantityInput.SelectAll();
                    quantityInput.Focus();
                    return;
                }
            }

            // Offers Discount if conditions are met and updates quotation if its visible
            OfferDiscount(sender, e);
        }

        // Handle Battery Selection Change
        private void Battery1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Handle Battery Selection Change
        private void Battery2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Handle Battery Selection Change
        private void Battery3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Handle Battery Selection Change
        private void Battery4RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Handle Expedited Install Input Change
        private void ExpInstallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Client Details Panel Event Handlers

        // Goes back to previous screen.
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ShowClientDetailsPanel(false);
        }

        // Confirms the order and updates summary file
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Validate Inputs
            string clientName = nameTextBox.Text;
            string clientPostcode = postcodeTextBox.Text;
            string clientPhone = phoneTextBox.Text;
            string clientEmail = emailTextBox.Text;
            if (!ValidateClientDetails(clientName, clientPostcode, clientPhone, clientEmail)) return;

            // Intialise a new order Confirmation Form.
            LoanForm CurrentLoanForm = new LoanForm();

            // Display Order Details in Loan Form
            decimal netVal = panelsCost + batteryCost + invertorCost + installationCost;
            CurrentLoanForm.DisplayLoanOffer(clientName, clientPostcode, clientPhone, clientEmail, netVal);

            // Show Loan form as a Dialog.
            CurrentLoanForm.ShowDialog();

            // Reset the Form App
            if (CurrentLoanForm.clearForm)
            {
                ClearButton_Click(sender, e);
            }

            CurrentLoanForm.Close();
        }

        // Search Panel Event Handlers

        // When Seach by Transaction Number is Selected
        private void searchOption1_CheckedChanged(object sender, EventArgs e)
        {
            if (searchOption1.Checked)
            {
                searchLabel.Text = "Transaction Number:";
                searchLabel.Visible = true;
                searchInput.Visible = true;
                enterButton.Visible = true;
            }
        }

        // When Search by Transaction Date is Selected
        private void searchOption2_CheckedChanged(object sender, EventArgs e)
        {
            if (searchOption2.Checked)
            {
                searchLabel.Text = "Transaction Date:";
                searchLabel.Visible = true;
                searchInput.Visible = true;
                enterButton.Visible = true;
            }
        }

        // Utility Functions

        //Displays Error Box
        public static void DisplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Validate phone number format
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // check if all characters are digits and the phone number has a minimum length
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length >= 7;
        }

        // Validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var emailAddress = new System.Net.Mail.MailAddress(email);
                return emailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Genral Helper Functions

        // Update Summary Variables
        private void UpdateSummaryVariables()
        {
            // Check if summary file exists.
            if (File.Exists(SUMMARY_FILE_PATH))
            {
                try
                {
                    // initiate reader for summary file.
                    StreamReader SummaryFileReader = new StreamReader(SUMMARY_FILE_PATH);

                    // Store summary values in local variables.
                    numOfOrders = int.Parse(SummaryFileReader.ReadLine());
                    totalPanelsCost = decimal.Parse(SummaryFileReader.ReadLine());
                    totalBatteriesCost = decimal.Parse(SummaryFileReader.ReadLine());
                    totalInvertorsCost = decimal.Parse(SummaryFileReader.ReadLine());
                    totalInstallationsCost = decimal.Parse(SummaryFileReader.ReadLine());
                    totalDiscountVal = decimal.Parse(SummaryFileReader.ReadLine());
                    numOfDiscounts = int.Parse(SummaryFileReader.ReadLine());

                    // Close the summary file.
                    SummaryFileReader.Close();
                }
                catch (Exception ex)
                {
                    DisplayError($"Unexpected error while reading {SUMMARY_FILE_PATH}");
                }
            }
        }

        // Updates the Summary File
        public static void UpdateSummaryFile()
        {
            // Update Summary values on order confirmation
            numOfOrders++;
            totalPanelsCost += panelsCost;
            totalBatteriesCost += batteryCost;
            totalInvertorsCost += invertorCost;
            totalInstallationsCost += installationCost;
            if (discountVal > 0)
            {
                totalDiscountVal += discountVal;
                numOfDiscounts++;
            }

            try
            {
                // Create a new summary file or rewrite existing file.
                StreamWriter SummaryFileWriter = File.CreateText(SUMMARY_FILE_PATH);

                // Store Summary Information in the summary file.
                SummaryFileWriter.WriteLine(numOfOrders);
                SummaryFileWriter.WriteLine(totalPanelsCost);
                SummaryFileWriter.WriteLine(totalBatteriesCost);
                SummaryFileWriter.WriteLine(totalInvertorsCost);
                SummaryFileWriter.WriteLine(totalInstallationsCost);
                SummaryFileWriter.WriteLine(totalDiscountVal);
                SummaryFileWriter.WriteLine(numOfDiscounts);

                // Close Summary File
                SummaryFileWriter.Close();
            }
            catch (Exception ex)
            {
                DisplayError($"Unexpected error while writing in {SUMMARY_FILE_PATH}");
            }
        }

        // Home Pannel Helper Functions

        // Quote Generation Helper Functions

        // Validate user inputs related to quotation.
        private bool ValidateQuoteInputs()
        {
            int brandIndex = brandList.SelectedIndex, sizeIndex = sizeList.SelectedIndex;

            // Validate panel brand selection
            if (brandIndex == -1)
            {
                DisplayError("Please Select a Panel Brand");
                return false;
            }

            // Validate panel size selection
            if (sizeIndex == -1)
            {
                DisplayError("Please Select a Panel Size");
                return false;
            }

            // Validate quantity input
            if (numOfPanels < 1)
            {
                DisplayError("Please Enter a valid panel quantity");
                quantityInput.SelectAll();
                quantityInput.Focus();
                return false;
            }

            // Handle No Battery Selection
            if (!battery1RadioButton.Checked &&
                !battery2RadioButton.Checked &&
                !battery3RadioButton.Checked &&
                !battery4RadioButton.Checked) battery4RadioButton.Checked = true;

            return true;
        }

        // Update Quote cost related field variables
        private void UpdateQuoteCosts()
        {
            // Update panels cost
            int brandIndex = brandList.SelectedIndex, sizeIndex = sizeList.SelectedIndex;

            panelsCost = brandIndex == 0 ? PANEL_1_PRICE :
                brandIndex == 1 ? PANEL_2_PRICE :
                brandIndex == 2 ? PANEL_3_PRICE :
                brandIndex == 3 ? PANEL_4_PRICE :
                brandIndex == 4 ? PANEL_5_PRICE :
                PANEL_6_PRICE;

            panelsCost *= 1 + (sizeIndex == 0 ? PANEL_SIZE_1_PERCENT :
                sizeIndex == 1 ? PANEL_SIZE_2_PERCENT :
                sizeIndex == 2 ? PANEL_SIZE_3_PERCENT :
                sizeIndex == 3 ? PANEL_SIZE_4_PERCENT :
                sizeIndex == 4 ? PANEL_SIZE_5_PERCENT :
                PANEL_SIZE_6_PERCENT);

            panelsCost *= numOfPanels;

            // Update battery cost
            batteryCost = battery1RadioButton.Checked ? BATTERY_1_PRICE :
                battery2RadioButton.Checked ? BATTERY_2_PRICE :
                battery3RadioButton.Checked ? BATTERY_3_PRICE :
                BATTERY_4_PRICE;

            // Update invertor cost
            invertorCost = battery4RadioButton.Checked ?
                numOfCells <= DISCOUNT_SIZE ?
                INVERTOR_1_PRICE : INVERTOR_2_PRICE :
                numOfCells <= DISCOUNT_SIZE ?
                INVERTOR_3_PRICE : INVERTOR_4_PRICE;

            // Update installation cost
            installationCost = expInstallCheckBox.Checked ?
                INSTALLATION_2_PRICE : INSTALLATION_1_PRICE;

            // Update Discount Value
            decimal grossVal = panelsCost + batteryCost + invertorCost + installationCost;
            bool hasLargeBattery = battery2RadioButton.Checked || battery1RadioButton.Checked;
            discountVal = numOfCells > DISCOUNT_SIZE && hasLargeBattery ? grossVal * DISCOUNT_PERCENT : 0;
        }

        // Display Quote Summary to the user
        private void ShowQuoteSummary()
        {
            // Hide unrequired lables
            noOfOrdersLabel.Visible = false;
            noOfOrders.Visible = false;
            averageValueLabel.Visible = false;
            averageValue.Visible = false;
            noOfDiscountsLabel.Visible = false;
            noOfDiscounts.Visible = false;

            // Update Gross Value Label
            decimal grossVal = panelsCost + batteryCost + invertorCost + installationCost;
            grossValue.Text = grossVal.ToString("C2");

            // Update Discount Value Label
            discountValue.Text = discountVal.ToString("C2");

            // Update Net Value Label
            decimal netVal = grossVal - discountVal;
            netValue.Text = netVal.ToString("C2");

            // Update Panel Details
            int brandIndex = brandList.SelectedIndex, sizeIndex = sizeList.SelectedIndex;

            string panelBrand = brandIndex == 0 ? PANEL_1_BRAND :
                brandIndex == 1 ? PANEL_2_BRAND :
                brandIndex == 2 ? PANEL_3_BRAND :
                brandIndex == 3 ? PANEL_4_BRAND :
                brandIndex == 4 ? PANEL_5_BRAND :
                PANEL_6_BRAND;

            string panelSize = sizeIndex == 0 ? $"{PANEL_SIZE_1}-Cell" :
                sizeIndex == 1 ? $"{PANEL_SIZE_2}-Cell" :
                sizeIndex == 2 ? $"{PANEL_SIZE_3}-Cell" :
                sizeIndex == 3 ? $"{PANEL_SIZE_4}-Cell" :
                sizeIndex == 4 ? $"{PANEL_SIZE_5}-Cell" :
                $"{PANEL_SIZE_6}-Cell";

            panelDetails.Visible = true;
            panelDetailsText = $"{panelBrand} {panelSize} x{numOfPanels}";
            panelDetails.Text = panelDetailsText;
            panelsCostValue.Text = panelsCost.ToString("C2");
            panelsPercentage.Text = (panelsCost / netVal).ToString("P2");

            // Update Battery Details
            batteryDetails.Visible = true;
            batteryDetailsText = battery1RadioButton.Checked ? BATTERY_1_SIZE :
                battery2RadioButton.Checked ? BATTERY_2_SIZE :
                battery3RadioButton.Checked ? BATTERY_3_SIZE :
                BATTERY_4_SIZE;
            batteryDetails.Text = batteryDetailsText;
            batteriesCostValue.Text = batteryCost.ToString("C2");
            batteriesPercentage.Text = (batteryCost / netVal).ToString("P2");

            // Update Invertor Details
            invertorDetails.Visible = true;
            invertorDetailsText = battery4RadioButton.Checked ?
                numOfCells <= DISCOUNT_SIZE ? INVERTOR_1_TYPE :
                INVERTOR_2_TYPE :
                numOfCells <= DISCOUNT_SIZE ? INVERTOR_3_TYPE :
                INVERTOR_4_TYPE;
            invertorDetails.Text = invertorDetailsText;
            invertorsCostValue.Text = invertorCost.ToString("C2");
            invertorsPercentage.Text = (invertorCost / netVal).ToString("P2");

            // Update Installation Details
            installationDetails.Visible = true;
            installationDetailsText = expInstallCheckBox.Checked ? INSTALLATION_2_TYPE : INSTALLATION_1_TYPE;
            installationDetails.Text = installationDetailsText;
            installationCostValue.Text = installationCost.ToString("C2");
            installationPercentage.Text = (installationCost / netVal).ToString("P2");

            // Display Summary to the user
            summaryPanel.Visible = true;

            // Hide Search Panel
            searchPanel.Visible = false;
        }

        // Order Button Helper Functions

        // toggles client details and related panels
        private void ShowClientDetailsPanel(bool show)
        {
            selectionPanel.Visible = !show;
            optionsPanel.Visible = !show;
            summaryPanel.Visible = !show;
            searchPanel.Visible = false;
            clientDetailsPanel.Visible = show;
        }

        // Prepares Client form for new order.
        public void PrepareClientForm()
        {
            // Generate a random 6 digit transaction Number
            Random random = new Random();
            currentTransactionNumber = random.Next(100000, 1000000);

            // Update current date
            currentDate = DateTime.Now.ToShortDateString();

            // Updates transaction number and date labels.
            transactionNumber.Text = currentTransactionNumber.ToString();
            transactionDate.Text = currentDate;

            // Reset client detail Inputs
            nameTextBox.Clear();
            postcodeTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
        }

        // Search Panel Helper Functions

        // Search files using input string.
        private void enterButton_Click(object sender, EventArgs e)
        {
            string query = searchInput.Text;
            if (searchOption1.Checked && query.Length == 6)
            {
                if (File.Exists($"{query}.txt")) DisplayFile($"{query}.txt");
                else DisplayError("Transaction Number does not exist.");
            }
            else if (searchOption2.Checked && query.Length == 10)
            {
                // Display all matches in a listbox. User can select a file name and click open.
                searchResults.Visible = true;
                searchResults.Items.Clear();

                string defaultPath = AppDomain.CurrentDomain.BaseDirectory;
                foreach (string filePath in Directory.EnumerateFiles(defaultPath, "*.txt"))
                {
                    try
                    {
                        StreamReader FileReader = new StreamReader(filePath);
                        string transactionId = FileReader.ReadLine();

                        //if date is equal to query string then add filename to results.
                        if (FileReader.ReadLine() == query) searchResults.Items.Add($"{transactionId}.txt");
                    }
                    catch (Exception ex)
                    {
                        DisplayError($"Unexpected Error while reading files");
                    }
                }
                if (searchResults.Items.Count > 0) openButton.Visible = true;
                else searchResults.Items.Add($"No transactions for this date.");
            }
            else
            {
                DisplayError("Invalid Search");
            }
        }

        // Display File if a file is selected on search results listbox.
        private void openButton_Click(object sender, EventArgs e)
        {
            if (searchResults.SelectedIndex == -1) DisplayError("Please Select a File in Selection Box");

            DisplayFile(searchResults.SelectedItem.ToString());

            openButton.Visible = false;
        }

        // Read and show the contents of provide filename
        private void DisplayFile(string fileName)
        {
            try
            {
                // Display File Contents
                searchResults.Visible = true;
                searchResults.Items.Clear();

                StreamReader FileReader = new StreamReader(fileName);
                searchResults.Items.Add($"Transaction Id: {FileReader.ReadLine()}");
                searchResults.Items.Add($"Transaction Date: {FileReader.ReadLine()}");
                searchResults.Items.Add($"Full Name: {FileReader.ReadLine()}");
                searchResults.Items.Add($"Postcode: {FileReader.ReadLine()}");
                searchResults.Items.Add($"Phone Number: {FileReader.ReadLine()}");
                searchResults.Items.Add($"Panels: {FileReader.ReadLine()}");
                searchResults.Items.Add($"Battery: {FileReader.ReadLine()}");
                searchResults.Items.Add($"Invertor: {FileReader.ReadLine()}");
                searchResults.Items.Add($"Installation: {FileReader.ReadLine()}");
                searchResults.Items.Add($"Net Value: {FileReader.ReadLine()}");
                string loanTerm = FileReader.ReadLine();
                if (loanTerm == "0") searchResults.Items.Add($"Loan: Not Required");
                else
                {
                    searchResults.Items.Add($"Loan term: {FileReader.ReadLine()}");
                    searchResults.Items.Add($"Interest Rate: {FileReader.ReadLine()}");
                    searchResults.Items.Add($"Repayment Amount: {FileReader.ReadLine()}");
                }

                // Close file.
                FileReader.Close();
            }
            catch (Exception ex)
            {
                DisplayError($"Unexpected Error while reading {fileName}");
            }
        }

        // Home Pannel change Helper Functions

        // Offers Discount if conditions are met and updates quotation if its visible
        private void OfferDiscount(object sender, EventArgs e)
        {
            int sizeIndex = sizeList.SelectedIndex;

            if (sizeIndex == -1) return;

            numOfCells = sizeIndex == 0 ? PANEL_SIZE_1 :
                sizeIndex == 1 ? PANEL_SIZE_2 :
                sizeIndex == 2 ? PANEL_SIZE_3 :
                sizeIndex == 3 ? PANEL_SIZE_4 :
                sizeIndex == 4 ? PANEL_SIZE_5 :
                PANEL_SIZE_6;

            numOfCells *= numOfPanels;

            if (numOfCells > DISCOUNT_SIZE)
            {
                discountOffer.Visible = true;
            }
            else
            {
                discountOffer.Visible = false;
            }

            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Client Details Pannel Helper

        // Validate client details inputs
        private bool ValidateClientDetails(string clientName, string clientPostcode, string clientPhone, string clientEmail)
        {
            TextBox invalidInput = null;

            if (string.IsNullOrWhiteSpace(clientName)) invalidInput = nameTextBox; // Validate clientName
            else if (string.IsNullOrWhiteSpace(clientPostcode) || clientPostcode.Length < 5) invalidInput = postcodeTextBox; // Validate clientPostcode
            else if (string.IsNullOrWhiteSpace(clientPhone) || !IsValidPhoneNumber(clientPhone)) invalidInput = phoneTextBox; // Validate clientPhone
            else if (string.IsNullOrWhiteSpace(clientEmail) || !IsValidEmail(clientEmail)) invalidInput = emailTextBox; // Validate clientEmail

            if (invalidInput != null) // if invalid input exist, display error and highlight the relavant textbox
            {
                DisplayError($"Invalid {invalidInput.AccessibleName}");
                invalidInput.SelectAll();
                invalidInput.Focus();
                return false;
            }
            else return true; // return true if all inputs are valid
        }
    }
}
