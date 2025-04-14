namespace Solar4U
{
    partial class Solar4UFormApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solar4UFormApp));
            logoImage = new PictureBox();
            selectionPanel = new Panel();
            discountOffer = new Label();
            expInstallCheckBox = new CheckBox();
            quantityLabel = new Label();
            quantityInput = new TextBox();
            sizeLabel = new Label();
            effectLabel = new Label();
            brandPriceLabel = new Label();
            brandLabel = new Label();
            batterySelection = new GroupBox();
            battery4RadioButton = new RadioButton();
            battery1RadioButton = new RadioButton();
            battery2RadioButton = new RadioButton();
            battery3RadioButton = new RadioButton();
            sizeList = new ListBox();
            brandList = new ListBox();
            optionsPanel = new Panel();
            searchButton = new Button();
            exitButton = new Button();
            summaryButton = new Button();
            orderButton = new Button();
            clearButton = new Button();
            quoteButton = new Button();
            summaryPanel = new Panel();
            installationDetails = new Label();
            invertorDetails = new Label();
            batteryDetails = new Label();
            panelDetails = new Label();
            noOfDiscounts = new Label();
            netValue = new Label();
            discountValue = new Label();
            noOfDiscountsLabel = new Label();
            netValueLabel = new Label();
            discountValueLabel = new Label();
            averageValue = new Label();
            grossValue = new Label();
            installationPercentage = new Label();
            installationCostValue = new Label();
            invertorsPercentage = new Label();
            invertorsCostValue = new Label();
            batteriesPercentage = new Label();
            batteriesCostValue = new Label();
            panelsPercentage = new Label();
            panelsCostValue = new Label();
            noOfOrders = new Label();
            summaryMidLine = new Panel();
            averageValueLabel = new Label();
            grossValueLabel = new Label();
            installationSummaryLabel = new Label();
            invertorSummaryLabel = new Label();
            batterySummaryLabel = new Label();
            panelsSummaryLabel = new Label();
            noOfOrdersLabel = new Label();
            summaryLabel = new Label();
            summaryHeadingLine = new Panel();
            toolTip = new ToolTip(components);
            cancelButton = new Button();
            submitButton = new Button();
            enterButton = new Button();
            openButton = new Button();
            clientDetailsPanel = new Panel();
            transactionDate = new Label();
            transactionNumber = new Label();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            postcodeTextBox = new TextBox();
            transactionLabel = new Label();
            dateLabel = new Label();
            nameTextBox = new TextBox();
            emailLabel = new Label();
            phoneLabel = new Label();
            pastcodeLabel = new Label();
            nameLabel = new Label();
            searchPanel = new Panel();
            searchLabel = new Label();
            searchInput = new TextBox();
            searchResults = new ListBox();
            searchOptions = new GroupBox();
            searchOption1 = new RadioButton();
            searchOption2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            selectionPanel.SuspendLayout();
            batterySelection.SuspendLayout();
            optionsPanel.SuspendLayout();
            summaryPanel.SuspendLayout();
            clientDetailsPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            searchOptions.SuspendLayout();
            SuspendLayout();
            // 
            // logoImage
            // 
            logoImage.Image = (Image)resources.GetObject("logoImage.Image");
            logoImage.Location = new Point(830, 149);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(200, 200);
            logoImage.SizeMode = PictureBoxSizeMode.Zoom;
            logoImage.TabIndex = 19;
            logoImage.TabStop = false;
            // 
            // selectionPanel
            // 
            selectionPanel.BackColor = Color.Maroon;
            selectionPanel.Controls.Add(discountOffer);
            selectionPanel.Controls.Add(expInstallCheckBox);
            selectionPanel.Controls.Add(quantityLabel);
            selectionPanel.Controls.Add(quantityInput);
            selectionPanel.Controls.Add(sizeLabel);
            selectionPanel.Controls.Add(effectLabel);
            selectionPanel.Controls.Add(brandPriceLabel);
            selectionPanel.Controls.Add(brandLabel);
            selectionPanel.Controls.Add(batterySelection);
            selectionPanel.Controls.Add(sizeList);
            selectionPanel.Controls.Add(brandList);
            selectionPanel.Controls.Add(logoImage);
            selectionPanel.Location = new Point(50, 50);
            selectionPanel.Name = "selectionPanel";
            selectionPanel.Size = new Size(1425, 400);
            selectionPanel.TabIndex = 20;
            // 
            // discountOffer
            // 
            discountOffer.Font = new Font("Segoe UI", 10F);
            discountOffer.ForeColor = Color.FromArgb(255, 255, 192);
            discountOffer.Location = new Point(830, 128);
            discountOffer.Name = "discountOffer";
            discountOffer.Size = new Size(200, 229);
            discountOffer.TabIndex = 54;
            discountOffer.Text = "3% Discount with a system of 700 + Cells that also has a 10KWh or higher Battery";
            discountOffer.TextAlign = ContentAlignment.MiddleCenter;
            discountOffer.Visible = false;
            // 
            // expInstallCheckBox
            // 
            expInstallCheckBox.AutoSize = true;
            expInstallCheckBox.Font = new Font("Segoe UI", 12F);
            expInstallCheckBox.ForeColor = Color.FromArgb(255, 255, 192);
            expInstallCheckBox.Location = new Point(1030, 300);
            expInstallCheckBox.Name = "expInstallCheckBox";
            expInstallCheckBox.Size = new Size(383, 49);
            expInstallCheckBox.TabIndex = 8;
            expInstallCheckBox.Text = "Expedited Install ($299)";
            expInstallCheckBox.UseVisualStyleBackColor = true;
            expInstallCheckBox.CheckedChanged += ExpInstallCheckBox_CheckedChanged;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            quantityLabel.ForeColor = Color.FromArgb(255, 255, 192);
            quantityLabel.Location = new Point(855, 25);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(149, 45);
            quantityLabel.TabIndex = 18;
            quantityLabel.Text = "Quantity";
            // 
            // quantityInput
            // 
            quantityInput.BackColor = Color.FromArgb(192, 64, 0);
            quantityInput.Font = new Font("Segoe UI", 12F);
            quantityInput.ForeColor = Color.FromArgb(255, 255, 192);
            quantityInput.Location = new Point(855, 75);
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(150, 50);
            quantityInput.TabIndex = 2;
            quantityInput.Text = "0";
            quantityInput.TextAlign = HorizontalAlignment.Center;
            quantityInput.TextChanged += QuantityInput_TextChanged;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sizeLabel.ForeColor = Color.FromArgb(255, 255, 192);
            sizeLabel.Location = new Point(495, 25);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(79, 45);
            sizeLabel.TabIndex = 16;
            sizeLabel.Text = "Size";
            // 
            // effectLabel
            // 
            effectLabel.AutoSize = true;
            effectLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            effectLabel.ForeColor = Color.FromArgb(255, 255, 192);
            effectLabel.Location = new Point(680, 25);
            effectLabel.Name = "effectLabel";
            effectLabel.Size = new Size(105, 45);
            effectLabel.TabIndex = 17;
            effectLabel.Text = "Effect";
            // 
            // brandPriceLabel
            // 
            brandPriceLabel.AutoSize = true;
            brandPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            brandPriceLabel.ForeColor = Color.FromArgb(255, 255, 192);
            brandPriceLabel.Location = new Point(320, 25);
            brandPriceLabel.Name = "brandPriceLabel";
            brandPriceLabel.Size = new Size(94, 45);
            brandPriceLabel.TabIndex = 15;
            brandPriceLabel.Text = "Price";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            brandLabel.ForeColor = Color.FromArgb(255, 255, 192);
            brandLabel.Location = new Point(55, 25);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(110, 45);
            brandLabel.TabIndex = 14;
            brandLabel.Text = "Brand";
            // 
            // batterySelection
            // 
            batterySelection.BackColor = Color.Maroon;
            batterySelection.Controls.Add(battery4RadioButton);
            batterySelection.Controls.Add(battery1RadioButton);
            batterySelection.Controls.Add(battery2RadioButton);
            batterySelection.Controls.Add(battery3RadioButton);
            batterySelection.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            batterySelection.ForeColor = Color.FromArgb(255, 255, 192);
            batterySelection.Location = new Point(1055, 25);
            batterySelection.Name = "batterySelection";
            batterySelection.Size = new Size(310, 265);
            batterySelection.TabIndex = 3;
            batterySelection.TabStop = false;
            batterySelection.Text = "Battery";
            // 
            // battery4RadioButton
            // 
            battery4RadioButton.AutoSize = true;
            battery4RadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            battery4RadioButton.ForeColor = Color.FromArgb(255, 255, 192);
            battery4RadioButton.Location = new Point(32, 199);
            battery4RadioButton.Name = "battery4RadioButton";
            battery4RadioButton.Size = new Size(241, 49);
            battery4RadioButton.TabIndex = 7;
            battery4RadioButton.TabStop = true;
            battery4RadioButton.Text = "Not Required";
            battery4RadioButton.UseVisualStyleBackColor = true;
            battery4RadioButton.CheckedChanged += Battery4RadioButton_CheckedChanged;
            // 
            // battery1RadioButton
            // 
            battery1RadioButton.AutoSize = true;
            battery1RadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            battery1RadioButton.ForeColor = Color.FromArgb(255, 255, 192);
            battery1RadioButton.Location = new Point(32, 49);
            battery1RadioButton.Name = "battery1RadioButton";
            battery1RadioButton.Size = new Size(274, 49);
            battery1RadioButton.TabIndex = 4;
            battery1RadioButton.TabStop = true;
            battery1RadioButton.Text = "20KWh ($9,500)";
            battery1RadioButton.UseVisualStyleBackColor = true;
            battery1RadioButton.CheckedChanged += Battery1RadioButton_CheckedChanged;
            // 
            // battery2RadioButton
            // 
            battery2RadioButton.AutoSize = true;
            battery2RadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            battery2RadioButton.ForeColor = Color.FromArgb(255, 255, 192);
            battery2RadioButton.Location = new Point(32, 99);
            battery2RadioButton.Name = "battery2RadioButton";
            battery2RadioButton.Size = new Size(274, 49);
            battery2RadioButton.TabIndex = 5;
            battery2RadioButton.TabStop = true;
            battery2RadioButton.Text = "10KWh ($7,500)";
            battery2RadioButton.UseVisualStyleBackColor = true;
            battery2RadioButton.CheckedChanged += Battery2RadioButton_CheckedChanged;
            // 
            // battery3RadioButton
            // 
            battery3RadioButton.AutoSize = true;
            battery3RadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            battery3RadioButton.ForeColor = Color.FromArgb(255, 255, 192);
            battery3RadioButton.Location = new Point(32, 149);
            battery3RadioButton.Name = "battery3RadioButton";
            battery3RadioButton.Size = new Size(257, 49);
            battery3RadioButton.TabIndex = 6;
            battery3RadioButton.TabStop = true;
            battery3RadioButton.Text = "5KWh ($4,500)";
            battery3RadioButton.UseVisualStyleBackColor = true;
            battery3RadioButton.CheckedChanged += Battery3RadioButton_CheckedChanged;
            // 
            // sizeList
            // 
            sizeList.BackColor = Color.FromArgb(192, 64, 0);
            sizeList.Font = new Font("Segoe UI", 12F);
            sizeList.ForeColor = Color.FromArgb(255, 255, 192);
            sizeList.FormattingEnabled = true;
            sizeList.ItemHeight = 45;
            sizeList.Items.AddRange(new object[] { "30 - Cell\t        -25%", "48 - Cell\t        -15%", "60 - Cell\t        0%", "72 - Cell\t        15%", "84 - Cell\t        25%", "96 - Cell\t        40%" });
            sizeList.Location = new Point(480, 75);
            sizeList.Name = "sizeList";
            sizeList.Size = new Size(325, 274);
            sizeList.TabIndex = 1;
            sizeList.SelectedIndexChanged += SizeList_SelectedIndexChanged;
            // 
            // brandList
            // 
            brandList.BackColor = Color.FromArgb(192, 64, 0);
            brandList.Font = new Font("Segoe UI", 12F);
            brandList.ForeColor = Color.FromArgb(255, 255, 192);
            brandList.FormattingEnabled = true;
            brandList.ItemHeight = 45;
            brandList.Items.AddRange(new object[] { "LONGi Solar\t$129.50", "JinkoSolar\t$135", "Trina Solar\t$112.79", "CanadianSolar\t$149", "Q-Cells\t\t$131", "FirstSolar\t\t$119" });
            brandList.Location = new Point(30, 75);
            brandList.Name = "brandList";
            brandList.Size = new Size(410, 274);
            brandList.TabIndex = 0;
            brandList.SelectedIndexChanged += BrandList_SelectedIndexChanged;
            // 
            // optionsPanel
            // 
            optionsPanel.BackColor = Color.Maroon;
            optionsPanel.Controls.Add(searchButton);
            optionsPanel.Controls.Add(exitButton);
            optionsPanel.Controls.Add(summaryButton);
            optionsPanel.Controls.Add(orderButton);
            optionsPanel.Controls.Add(clearButton);
            optionsPanel.Controls.Add(quoteButton);
            optionsPanel.Location = new Point(1100, 500);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(375, 625);
            optionsPanel.TabIndex = 21;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(192, 64, 0);
            searchButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            searchButton.FlatAppearance.BorderSize = 5;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            searchButton.ForeColor = Color.FromArgb(255, 255, 192);
            searchButton.Location = new Point(90, 430);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(200, 52);
            searchButton.TabIndex = 13;
            searchButton.Text = "&Search";
            toolTip.SetToolTip(searchButton, "Press to search by transaction Id or Date");
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(192, 64, 0);
            exitButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            exitButton.FlatAppearance.BorderSize = 5;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            exitButton.ForeColor = Color.FromArgb(255, 255, 192);
            exitButton.Location = new Point(90, 530);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 52);
            exitButton.TabIndex = 14;
            exitButton.Text = "E&xit";
            toolTip.SetToolTip(exitButton, "Press to Quit the App");
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += ExitButton_Click;
            // 
            // summaryButton
            // 
            summaryButton.BackColor = Color.FromArgb(192, 64, 0);
            summaryButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            summaryButton.FlatAppearance.BorderSize = 5;
            summaryButton.FlatStyle = FlatStyle.Flat;
            summaryButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            summaryButton.ForeColor = Color.FromArgb(255, 255, 192);
            summaryButton.Location = new Point(90, 330);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new Size(200, 52);
            summaryButton.TabIndex = 12;
            summaryButton.Text = "Su&mmary";
            toolTip.SetToolTip(summaryButton, "Press to view Summary of all quotations");
            summaryButton.UseVisualStyleBackColor = false;
            summaryButton.Click += SummaryButton_Click;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.FromArgb(192, 64, 0);
            orderButton.Enabled = false;
            orderButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            orderButton.FlatAppearance.BorderSize = 5;
            orderButton.FlatStyle = FlatStyle.Flat;
            orderButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            orderButton.ForeColor = Color.FromArgb(255, 255, 192);
            orderButton.Location = new Point(90, 230);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(200, 52);
            orderButton.TabIndex = 11;
            orderButton.Text = "&Order";
            toolTip.SetToolTip(orderButton, "Press to confirm the order");
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += OrderButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(192, 64, 0);
            clearButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            clearButton.FlatAppearance.BorderSize = 5;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            clearButton.ForeColor = Color.FromArgb(255, 255, 192);
            clearButton.Location = new Point(90, 130);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(200, 52);
            clearButton.TabIndex = 10;
            clearButton.Text = "&Clear";
            toolTip.SetToolTip(clearButton, "Press to reset the form");
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // quoteButton
            // 
            quoteButton.BackColor = Color.FromArgb(192, 64, 0);
            quoteButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            quoteButton.FlatAppearance.BorderSize = 5;
            quoteButton.FlatStyle = FlatStyle.Flat;
            quoteButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            quoteButton.ForeColor = Color.FromArgb(255, 255, 192);
            quoteButton.Location = new Point(90, 30);
            quoteButton.Name = "quoteButton";
            quoteButton.Size = new Size(200, 52);
            quoteButton.TabIndex = 9;
            quoteButton.Text = "&Quote";
            toolTip.SetToolTip(quoteButton, "Press to view quotation");
            quoteButton.UseVisualStyleBackColor = false;
            quoteButton.Click += QuoteButton_Click;
            // 
            // summaryPanel
            // 
            summaryPanel.BackColor = Color.Maroon;
            summaryPanel.Controls.Add(installationDetails);
            summaryPanel.Controls.Add(invertorDetails);
            summaryPanel.Controls.Add(batteryDetails);
            summaryPanel.Controls.Add(panelDetails);
            summaryPanel.Controls.Add(noOfDiscounts);
            summaryPanel.Controls.Add(netValue);
            summaryPanel.Controls.Add(discountValue);
            summaryPanel.Controls.Add(noOfDiscountsLabel);
            summaryPanel.Controls.Add(netValueLabel);
            summaryPanel.Controls.Add(discountValueLabel);
            summaryPanel.Controls.Add(averageValue);
            summaryPanel.Controls.Add(grossValue);
            summaryPanel.Controls.Add(installationPercentage);
            summaryPanel.Controls.Add(installationCostValue);
            summaryPanel.Controls.Add(invertorsPercentage);
            summaryPanel.Controls.Add(invertorsCostValue);
            summaryPanel.Controls.Add(batteriesPercentage);
            summaryPanel.Controls.Add(batteriesCostValue);
            summaryPanel.Controls.Add(panelsPercentage);
            summaryPanel.Controls.Add(panelsCostValue);
            summaryPanel.Controls.Add(noOfOrders);
            summaryPanel.Controls.Add(summaryMidLine);
            summaryPanel.Controls.Add(averageValueLabel);
            summaryPanel.Controls.Add(grossValueLabel);
            summaryPanel.Controls.Add(installationSummaryLabel);
            summaryPanel.Controls.Add(invertorSummaryLabel);
            summaryPanel.Controls.Add(batterySummaryLabel);
            summaryPanel.Controls.Add(panelsSummaryLabel);
            summaryPanel.Controls.Add(noOfOrdersLabel);
            summaryPanel.Controls.Add(summaryLabel);
            summaryPanel.Controls.Add(summaryHeadingLine);
            summaryPanel.Location = new Point(50, 500);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(1000, 625);
            summaryPanel.TabIndex = 22;
            summaryPanel.Visible = false;
            // 
            // installationDetails
            // 
            installationDetails.Font = new Font("Arial", 9.5F);
            installationDetails.ForeColor = Color.White;
            installationDetails.Location = new Point(250, 260);
            installationDetails.Name = "installationDetails";
            installationDetails.Padding = new Padding(0, 4, 0, 4);
            installationDetails.Size = new Size(400, 43);
            installationDetails.TabIndex = 40;
            installationDetails.Text = "Expedited Install";
            installationDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // invertorDetails
            // 
            invertorDetails.Font = new Font("Arial", 9.5F);
            invertorDetails.ForeColor = Color.White;
            invertorDetails.Location = new Point(250, 205);
            invertorDetails.Name = "invertorDetails";
            invertorDetails.Padding = new Padding(0, 4, 0, 4);
            invertorDetails.Size = new Size(400, 43);
            invertorDetails.TabIndex = 36;
            invertorDetails.Text = "Regular without Battery";
            invertorDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // batteryDetails
            // 
            batteryDetails.Font = new Font("Arial", 9.5F);
            batteryDetails.ForeColor = Color.White;
            batteryDetails.Location = new Point(250, 150);
            batteryDetails.Name = "batteryDetails";
            batteryDetails.Padding = new Padding(0, 4, 0, 4);
            batteryDetails.Size = new Size(400, 43);
            batteryDetails.TabIndex = 32;
            batteryDetails.Text = "5KWh";
            batteryDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDetails
            // 
            panelDetails.Font = new Font("Arial", 9.5F);
            panelDetails.ForeColor = Color.White;
            panelDetails.Location = new Point(250, 95);
            panelDetails.Name = "panelDetails";
            panelDetails.Padding = new Padding(0, 4, 0, 4);
            panelDetails.Size = new Size(400, 43);
            panelDetails.TabIndex = 28;
            panelDetails.Text = "LONGi Solar 30-Cell x1";
            panelDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noOfDiscounts
            // 
            noOfDiscounts.BackColor = Color.White;
            noOfDiscounts.BorderStyle = BorderStyle.FixedSingle;
            noOfDiscounts.ForeColor = Color.Black;
            noOfDiscounts.Location = new Point(675, 565);
            noOfDiscounts.Margin = new Padding(0);
            noOfDiscounts.Name = "noOfDiscounts";
            noOfDiscounts.Size = new Size(160, 40);
            noOfDiscounts.TabIndex = 53;
            noOfDiscounts.Text = "0";
            noOfDiscounts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // netValue
            // 
            netValue.BackColor = Color.White;
            netValue.BorderStyle = BorderStyle.FixedSingle;
            netValue.ForeColor = Color.Black;
            netValue.Location = new Point(675, 455);
            netValue.Margin = new Padding(0);
            netValue.Name = "netValue";
            netValue.Size = new Size(160, 40);
            netValue.TabIndex = 49;
            netValue.Text = "0";
            netValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // discountValue
            // 
            discountValue.BackColor = Color.White;
            discountValue.BorderStyle = BorderStyle.FixedSingle;
            discountValue.ForeColor = Color.Black;
            discountValue.Location = new Point(675, 400);
            discountValue.Margin = new Padding(0);
            discountValue.Name = "discountValue";
            discountValue.Size = new Size(160, 40);
            discountValue.TabIndex = 47;
            discountValue.Text = "0";
            discountValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noOfDiscountsLabel
            // 
            noOfDiscountsLabel.AutoSize = true;
            noOfDiscountsLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            noOfDiscountsLabel.ForeColor = Color.White;
            noOfDiscountsLabel.Location = new Point(40, 565);
            noOfDiscountsLabel.Name = "noOfDiscountsLabel";
            noOfDiscountsLabel.Padding = new Padding(0, 4, 0, 4);
            noOfDiscountsLabel.Size = new Size(252, 43);
            noOfDiscountsLabel.TabIndex = 52;
            noOfDiscountsLabel.Text = "No. of Discounts";
            // 
            // netValueLabel
            // 
            netValueLabel.AutoSize = true;
            netValueLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            netValueLabel.ForeColor = Color.White;
            netValueLabel.Location = new Point(40, 455);
            netValueLabel.Name = "netValueLabel";
            netValueLabel.Padding = new Padding(0, 4, 0, 4);
            netValueLabel.Size = new Size(150, 43);
            netValueLabel.TabIndex = 48;
            netValueLabel.Text = "Net Value";
            // 
            // discountValueLabel
            // 
            discountValueLabel.AutoSize = true;
            discountValueLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            discountValueLabel.ForeColor = Color.White;
            discountValueLabel.Location = new Point(40, 400);
            discountValueLabel.Name = "discountValueLabel";
            discountValueLabel.Padding = new Padding(0, 4, 0, 4);
            discountValueLabel.Size = new Size(214, 43);
            discountValueLabel.TabIndex = 46;
            discountValueLabel.Text = "Discount (3%)";
            // 
            // averageValue
            // 
            averageValue.BackColor = Color.White;
            averageValue.BorderStyle = BorderStyle.FixedSingle;
            averageValue.ForeColor = Color.Black;
            averageValue.Location = new Point(675, 510);
            averageValue.Margin = new Padding(0);
            averageValue.Name = "averageValue";
            averageValue.Size = new Size(160, 40);
            averageValue.TabIndex = 51;
            averageValue.Text = "0";
            averageValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grossValue
            // 
            grossValue.BackColor = Color.White;
            grossValue.BorderStyle = BorderStyle.FixedSingle;
            grossValue.ForeColor = Color.Black;
            grossValue.Location = new Point(675, 345);
            grossValue.Margin = new Padding(0);
            grossValue.Name = "grossValue";
            grossValue.Size = new Size(160, 40);
            grossValue.TabIndex = 45;
            grossValue.Text = "0";
            grossValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // installationPercentage
            // 
            installationPercentage.BackColor = Color.White;
            installationPercentage.BorderStyle = BorderStyle.FixedSingle;
            installationPercentage.ForeColor = Color.Black;
            installationPercentage.Location = new Point(850, 260);
            installationPercentage.Margin = new Padding(0);
            installationPercentage.Name = "installationPercentage";
            installationPercentage.Size = new Size(100, 40);
            installationPercentage.TabIndex = 42;
            installationPercentage.Text = "0";
            installationPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // installationCostValue
            // 
            installationCostValue.BackColor = Color.White;
            installationCostValue.BorderStyle = BorderStyle.FixedSingle;
            installationCostValue.ForeColor = Color.Black;
            installationCostValue.Location = new Point(675, 260);
            installationCostValue.Margin = new Padding(0);
            installationCostValue.Name = "installationCostValue";
            installationCostValue.Size = new Size(160, 40);
            installationCostValue.TabIndex = 41;
            installationCostValue.Text = "0";
            installationCostValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // invertorsPercentage
            // 
            invertorsPercentage.BackColor = Color.White;
            invertorsPercentage.BorderStyle = BorderStyle.FixedSingle;
            invertorsPercentage.ForeColor = Color.Black;
            invertorsPercentage.Location = new Point(850, 205);
            invertorsPercentage.Margin = new Padding(0);
            invertorsPercentage.Name = "invertorsPercentage";
            invertorsPercentage.Size = new Size(100, 40);
            invertorsPercentage.TabIndex = 38;
            invertorsPercentage.Text = "0";
            invertorsPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // invertorsCostValue
            // 
            invertorsCostValue.BackColor = Color.White;
            invertorsCostValue.BorderStyle = BorderStyle.FixedSingle;
            invertorsCostValue.ForeColor = Color.Black;
            invertorsCostValue.Location = new Point(675, 205);
            invertorsCostValue.Margin = new Padding(0);
            invertorsCostValue.Name = "invertorsCostValue";
            invertorsCostValue.Size = new Size(160, 40);
            invertorsCostValue.TabIndex = 37;
            invertorsCostValue.Text = "0";
            invertorsCostValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // batteriesPercentage
            // 
            batteriesPercentage.BackColor = Color.White;
            batteriesPercentage.BorderStyle = BorderStyle.FixedSingle;
            batteriesPercentage.ForeColor = Color.Black;
            batteriesPercentage.Location = new Point(850, 150);
            batteriesPercentage.Margin = new Padding(0);
            batteriesPercentage.Name = "batteriesPercentage";
            batteriesPercentage.Size = new Size(100, 40);
            batteriesPercentage.TabIndex = 34;
            batteriesPercentage.Text = "0";
            batteriesPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // batteriesCostValue
            // 
            batteriesCostValue.BackColor = Color.White;
            batteriesCostValue.BorderStyle = BorderStyle.FixedSingle;
            batteriesCostValue.ForeColor = Color.Black;
            batteriesCostValue.Location = new Point(675, 150);
            batteriesCostValue.Margin = new Padding(0);
            batteriesCostValue.Name = "batteriesCostValue";
            batteriesCostValue.Size = new Size(160, 40);
            batteriesCostValue.TabIndex = 33;
            batteriesCostValue.Text = "0";
            batteriesCostValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelsPercentage
            // 
            panelsPercentage.BackColor = Color.White;
            panelsPercentage.BorderStyle = BorderStyle.FixedSingle;
            panelsPercentage.ForeColor = Color.Black;
            panelsPercentage.Location = new Point(850, 95);
            panelsPercentage.Margin = new Padding(0);
            panelsPercentage.Name = "panelsPercentage";
            panelsPercentage.Size = new Size(100, 40);
            panelsPercentage.TabIndex = 30;
            panelsPercentage.Text = "0";
            panelsPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelsCostValue
            // 
            panelsCostValue.BackColor = Color.White;
            panelsCostValue.BorderStyle = BorderStyle.FixedSingle;
            panelsCostValue.ForeColor = Color.Black;
            panelsCostValue.Location = new Point(675, 95);
            panelsCostValue.Margin = new Padding(0);
            panelsCostValue.Name = "panelsCostValue";
            panelsCostValue.Size = new Size(160, 40);
            panelsCostValue.TabIndex = 29;
            panelsCostValue.Text = "0";
            panelsCostValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noOfOrders
            // 
            noOfOrders.BackColor = Color.White;
            noOfOrders.BorderStyle = BorderStyle.FixedSingle;
            noOfOrders.ForeColor = Color.Black;
            noOfOrders.Location = new Point(675, 40);
            noOfOrders.Margin = new Padding(0);
            noOfOrders.Name = "noOfOrders";
            noOfOrders.Size = new Size(160, 40);
            noOfOrders.TabIndex = 26;
            noOfOrders.Text = "0";
            noOfOrders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // summaryMidLine
            // 
            summaryMidLine.BackColor = Color.White;
            summaryMidLine.Location = new Point(60, 320);
            summaryMidLine.Name = "summaryMidLine";
            summaryMidLine.Size = new Size(880, 5);
            summaryMidLine.TabIndex = 43;
            // 
            // averageValueLabel
            // 
            averageValueLabel.AutoSize = true;
            averageValueLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            averageValueLabel.ForeColor = Color.White;
            averageValueLabel.Location = new Point(40, 510);
            averageValueLabel.Name = "averageValueLabel";
            averageValueLabel.Padding = new Padding(0, 4, 0, 4);
            averageValueLabel.Size = new Size(235, 45);
            averageValueLabel.TabIndex = 50;
            averageValueLabel.Text = "Average Value";
            // 
            // grossValueLabel
            // 
            grossValueLabel.AutoSize = true;
            grossValueLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            grossValueLabel.ForeColor = Color.White;
            grossValueLabel.Location = new Point(40, 345);
            grossValueLabel.Name = "grossValueLabel";
            grossValueLabel.Padding = new Padding(0, 4, 0, 4);
            grossValueLabel.Size = new Size(188, 43);
            grossValueLabel.TabIndex = 44;
            grossValueLabel.Text = "Gross Value";
            // 
            // installationSummaryLabel
            // 
            installationSummaryLabel.AutoSize = true;
            installationSummaryLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            installationSummaryLabel.ForeColor = Color.White;
            installationSummaryLabel.Location = new Point(40, 260);
            installationSummaryLabel.Name = "installationSummaryLabel";
            installationSummaryLabel.Padding = new Padding(0, 4, 0, 4);
            installationSummaryLabel.Size = new Size(172, 43);
            installationSummaryLabel.TabIndex = 39;
            installationSummaryLabel.Text = "Installation";
            // 
            // invertorSummaryLabel
            // 
            invertorSummaryLabel.AutoSize = true;
            invertorSummaryLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            invertorSummaryLabel.ForeColor = Color.White;
            invertorSummaryLabel.Location = new Point(40, 205);
            invertorSummaryLabel.Name = "invertorSummaryLabel";
            invertorSummaryLabel.Padding = new Padding(0, 4, 0, 4);
            invertorSummaryLabel.Size = new Size(127, 43);
            invertorSummaryLabel.TabIndex = 35;
            invertorSummaryLabel.Text = "Invertor";
            // 
            // batterySummaryLabel
            // 
            batterySummaryLabel.AutoSize = true;
            batterySummaryLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            batterySummaryLabel.ForeColor = Color.White;
            batterySummaryLabel.Location = new Point(40, 150);
            batterySummaryLabel.Name = "batterySummaryLabel";
            batterySummaryLabel.Padding = new Padding(0, 4, 0, 4);
            batterySummaryLabel.Size = new Size(118, 43);
            batterySummaryLabel.TabIndex = 31;
            batterySummaryLabel.Text = "Battery";
            // 
            // panelsSummaryLabel
            // 
            panelsSummaryLabel.AutoSize = true;
            panelsSummaryLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            panelsSummaryLabel.ForeColor = Color.White;
            panelsSummaryLabel.Location = new Point(40, 95);
            panelsSummaryLabel.Name = "panelsSummaryLabel";
            panelsSummaryLabel.Padding = new Padding(0, 4, 0, 4);
            panelsSummaryLabel.Size = new Size(195, 43);
            panelsSummaryLabel.TabIndex = 27;
            panelsSummaryLabel.Text = "Solar Panels";
            // 
            // noOfOrdersLabel
            // 
            noOfOrdersLabel.AutoSize = true;
            noOfOrdersLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            noOfOrdersLabel.ForeColor = Color.White;
            noOfOrdersLabel.Location = new Point(40, 40);
            noOfOrdersLabel.Name = "noOfOrdersLabel";
            noOfOrdersLabel.Padding = new Padding(0, 4, 0, 4);
            noOfOrdersLabel.Size = new Size(206, 43);
            noOfOrdersLabel.TabIndex = 25;
            noOfOrdersLabel.Text = "No. of Orders";
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Font = new Font("Arial", 10F);
            summaryLabel.ForeColor = Color.FromArgb(255, 255, 192);
            summaryLabel.Location = new Point(20, 0);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Padding = new Padding(0, 4, 0, 4);
            summaryLabel.Size = new Size(211, 40);
            summaryLabel.TabIndex = 24;
            summaryLabel.Text = "Quote Summary";
            // 
            // summaryHeadingLine
            // 
            summaryHeadingLine.BackColor = Color.FromArgb(255, 255, 192);
            summaryHeadingLine.ForeColor = Color.FromArgb(255, 255, 192);
            summaryHeadingLine.Location = new Point(0, 20);
            summaryHeadingLine.Name = "summaryHeadingLine";
            summaryHeadingLine.Size = new Size(1000, 2);
            summaryHeadingLine.TabIndex = 23;
            // 
            // toolTip
            // 
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Info";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(192, 64, 0);
            cancelButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            cancelButton.FlatAppearance.BorderSize = 5;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            cancelButton.ForeColor = Color.FromArgb(255, 255, 192);
            cancelButton.Location = new Point(475, 750);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 52);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "&Cancel";
            toolTip.SetToolTip(cancelButton, "Go Back to previous screen");
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(192, 64, 0);
            submitButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            submitButton.FlatAppearance.BorderSize = 5;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            submitButton.ForeColor = Color.FromArgb(255, 255, 192);
            submitButton.Location = new Point(800, 750);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(200, 52);
            submitButton.TabIndex = 13;
            submitButton.Text = "&Submit";
            toolTip.SetToolTip(submitButton, "Press to view Loan Options");
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += SubmitButton_Click;
            // 
            // enterButton
            // 
            enterButton.BackColor = Color.FromArgb(192, 64, 0);
            enterButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            enterButton.FlatAppearance.BorderSize = 5;
            enterButton.FlatStyle = FlatStyle.Flat;
            enterButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            enterButton.ForeColor = Color.FromArgb(255, 255, 192);
            enterButton.Location = new Point(141, 388);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(200, 52);
            enterButton.TabIndex = 57;
            enterButton.Text = "&Enter";
            toolTip.SetToolTip(enterButton, "Press to view search results");
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += enterButton_Click;
            // 
            // openButton
            // 
            openButton.BackColor = Color.FromArgb(192, 64, 0);
            openButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            openButton.FlatAppearance.BorderSize = 5;
            openButton.FlatStyle = FlatStyle.Flat;
            openButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            openButton.ForeColor = Color.FromArgb(255, 255, 192);
            openButton.Location = new Point(605, 541);
            openButton.Name = "openButton";
            openButton.Size = new Size(200, 52);
            openButton.TabIndex = 19;
            openButton.Text = "O&pen";
            toolTip.SetToolTip(openButton, "Press to Open File");
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += openButton_Click;
            // 
            // clientDetailsPanel
            // 
            clientDetailsPanel.BackColor = Color.Maroon;
            clientDetailsPanel.Controls.Add(transactionDate);
            clientDetailsPanel.Controls.Add(transactionNumber);
            clientDetailsPanel.Controls.Add(emailTextBox);
            clientDetailsPanel.Controls.Add(phoneTextBox);
            clientDetailsPanel.Controls.Add(postcodeTextBox);
            clientDetailsPanel.Controls.Add(transactionLabel);
            clientDetailsPanel.Controls.Add(dateLabel);
            clientDetailsPanel.Controls.Add(nameTextBox);
            clientDetailsPanel.Controls.Add(emailLabel);
            clientDetailsPanel.Controls.Add(phoneLabel);
            clientDetailsPanel.Controls.Add(pastcodeLabel);
            clientDetailsPanel.Controls.Add(nameLabel);
            clientDetailsPanel.Controls.Add(submitButton);
            clientDetailsPanel.Controls.Add(cancelButton);
            clientDetailsPanel.Location = new Point(50, 50);
            clientDetailsPanel.Name = "clientDetailsPanel";
            clientDetailsPanel.Size = new Size(1425, 1075);
            clientDetailsPanel.TabIndex = 14;
            clientDetailsPanel.Visible = false;
            // 
            // transactionDate
            // 
            transactionDate.BackColor = Color.White;
            transactionDate.BorderStyle = BorderStyle.FixedSingle;
            transactionDate.Enabled = false;
            transactionDate.Font = new Font("Segoe UI", 12F);
            transactionDate.ForeColor = Color.Black;
            transactionDate.Location = new Point(800, 325);
            transactionDate.Margin = new Padding(0);
            transactionDate.Name = "transactionDate";
            transactionDate.Size = new Size(300, 50);
            transactionDate.TabIndex = 3;
            transactionDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // transactionNumber
            // 
            transactionNumber.BackColor = Color.White;
            transactionNumber.BorderStyle = BorderStyle.FixedSingle;
            transactionNumber.Enabled = false;
            transactionNumber.Font = new Font("Segoe UI", 12F);
            transactionNumber.ForeColor = Color.Black;
            transactionNumber.Location = new Point(800, 250);
            transactionNumber.Margin = new Padding(0);
            transactionNumber.Name = "transactionNumber";
            transactionNumber.Size = new Size(300, 50);
            transactionNumber.TabIndex = 1;
            transactionNumber.Text = "000000";
            transactionNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            emailTextBox.AccessibleName = "E-mail Address";
            emailTextBox.BackColor = Color.White;
            emailTextBox.Font = new Font("Segoe UI", 12F);
            emailTextBox.ForeColor = Color.Black;
            emailTextBox.Location = new Point(800, 625);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(300, 50);
            emailTextBox.TabIndex = 11;
            emailTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // phoneTextBox
            // 
            phoneTextBox.AccessibleName = "Telephone Number";
            phoneTextBox.BackColor = Color.White;
            phoneTextBox.Font = new Font("Segoe UI", 12F);
            phoneTextBox.ForeColor = Color.Black;
            phoneTextBox.Location = new Point(800, 550);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(300, 50);
            phoneTextBox.TabIndex = 9;
            phoneTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // postcodeTextBox
            // 
            postcodeTextBox.AccessibleName = "Postcode";
            postcodeTextBox.BackColor = Color.White;
            postcodeTextBox.Font = new Font("Segoe UI", 12F);
            postcodeTextBox.ForeColor = Color.Black;
            postcodeTextBox.Location = new Point(800, 475);
            postcodeTextBox.Name = "postcodeTextBox";
            postcodeTextBox.Size = new Size(300, 50);
            postcodeTextBox.TabIndex = 7;
            postcodeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // transactionLabel
            // 
            transactionLabel.AutoSize = true;
            transactionLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            transactionLabel.ForeColor = Color.White;
            transactionLabel.Location = new Point(375, 250);
            transactionLabel.Name = "transactionLabel";
            transactionLabel.Padding = new Padding(0, 4, 0, 4);
            transactionLabel.Size = new Size(304, 43);
            transactionLabel.TabIndex = 0;
            transactionLabel.Text = "Transaction Number";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            dateLabel.ForeColor = Color.White;
            dateLabel.Location = new Point(375, 325);
            dateLabel.Name = "dateLabel";
            dateLabel.Padding = new Padding(0, 4, 0, 4);
            dateLabel.Size = new Size(81, 43);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Date";
            // 
            // nameTextBox
            // 
            nameTextBox.AccessibleName = "Full Name";
            nameTextBox.BackColor = Color.White;
            nameTextBox.Font = new Font("Segoe UI", 12F);
            nameTextBox.ForeColor = Color.Black;
            nameTextBox.Location = new Point(800, 400);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(300, 50);
            nameTextBox.TabIndex = 5;
            nameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(375, 625);
            emailLabel.Name = "emailLabel";
            emailLabel.Padding = new Padding(0, 4, 0, 4);
            emailLabel.Size = new Size(231, 43);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "E-mail Address";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            phoneLabel.ForeColor = Color.White;
            phoneLabel.Location = new Point(375, 550);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Padding = new Padding(0, 4, 0, 4);
            phoneLabel.Size = new Size(283, 43);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Telephone Number";
            // 
            // pastcodeLabel
            // 
            pastcodeLabel.AutoSize = true;
            pastcodeLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            pastcodeLabel.ForeColor = Color.White;
            pastcodeLabel.Location = new Point(375, 475);
            pastcodeLabel.Name = "pastcodeLabel";
            pastcodeLabel.Padding = new Padding(0, 4, 0, 4);
            pastcodeLabel.Size = new Size(150, 43);
            pastcodeLabel.TabIndex = 6;
            pastcodeLabel.Text = "Postcode";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(375, 400);
            nameLabel.Name = "nameLabel";
            nameLabel.Padding = new Padding(0, 4, 0, 4);
            nameLabel.Size = new Size(157, 43);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Full Name";
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.Maroon;
            searchPanel.Controls.Add(openButton);
            searchPanel.Controls.Add(enterButton);
            searchPanel.Controls.Add(searchLabel);
            searchPanel.Controls.Add(searchInput);
            searchPanel.Controls.Add(searchResults);
            searchPanel.Controls.Add(searchOptions);
            searchPanel.Location = new Point(50, 500);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(1000, 625);
            searchPanel.TabIndex = 62;
            searchPanel.Visible = false;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchLabel.ForeColor = Color.FromArgb(255, 255, 192);
            searchLabel.Location = new Point(50, 244);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(334, 45);
            searchLabel.TabIndex = 61;
            searchLabel.Text = "Transaction Number:";
            // 
            // searchInput
            // 
            searchInput.AccessibleName = "Full Name";
            searchInput.BackColor = Color.White;
            searchInput.Font = new Font("Segoe UI", 12F);
            searchInput.ForeColor = Color.Black;
            searchInput.Location = new Point(50, 295);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(390, 50);
            searchInput.TabIndex = 56;
            searchInput.TextAlign = HorizontalAlignment.Center;
            // 
            // searchResults
            // 
            searchResults.BackColor = Color.FromArgb(192, 64, 0);
            searchResults.Font = new Font("Segoe UI", 12F);
            searchResults.ForeColor = Color.FromArgb(255, 255, 192);
            searchResults.FormattingEnabled = true;
            searchResults.HorizontalScrollbar = true;
            searchResults.ItemHeight = 45;
            searchResults.Items.AddRange(new object[] { "123456.txt", "123456.txt", "123456.txt", "123456.txt", "123456.txt", "123456.txt", "123456.txt", "123456.txt" });
            searchResults.Location = new Point(475, 53);
            searchResults.Name = "searchResults";
            searchResults.Size = new Size(486, 454);
            searchResults.TabIndex = 58;
            // 
            // searchOptions
            // 
            searchOptions.BackColor = Color.Maroon;
            searchOptions.Controls.Add(searchOption1);
            searchOptions.Controls.Add(searchOption2);
            searchOptions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchOptions.ForeColor = Color.FromArgb(255, 255, 192);
            searchOptions.Location = new Point(50, 40);
            searchOptions.Name = "searchOptions";
            searchOptions.Size = new Size(385, 170);
            searchOptions.TabIndex = 60;
            searchOptions.TabStop = false;
            searchOptions.Text = "Search By";
            // 
            // searchOption1
            // 
            searchOption1.AutoSize = true;
            searchOption1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchOption1.ForeColor = Color.FromArgb(255, 255, 192);
            searchOption1.Location = new Point(32, 49);
            searchOption1.Name = "searchOption1";
            searchOption1.Size = new Size(337, 49);
            searchOption1.TabIndex = 54;
            searchOption1.TabStop = true;
            searchOption1.Text = "Transaction Number";
            searchOption1.UseVisualStyleBackColor = true;
            searchOption1.CheckedChanged += searchOption1_CheckedChanged;
            // 
            // searchOption2
            // 
            searchOption2.AutoSize = true;
            searchOption2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchOption2.ForeColor = Color.FromArgb(255, 255, 192);
            searchOption2.Location = new Point(32, 99);
            searchOption2.Name = "searchOption2";
            searchOption2.Size = new Size(286, 49);
            searchOption2.TabIndex = 55;
            searchOption2.TabStop = true;
            searchOption2.Text = "Transaction Date";
            searchOption2.UseVisualStyleBackColor = true;
            searchOption2.CheckedChanged += searchOption2_CheckedChanged;
            // 
            // Solar4UFormApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(1524, 1179);
            Controls.Add(searchPanel);
            Controls.Add(summaryPanel);
            Controls.Add(optionsPanel);
            Controls.Add(selectionPanel);
            Controls.Add(clientDetailsPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Solar4UFormApp";
            Text = "Solar4U";
            Load += Solar4UFormApp_Load;
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            selectionPanel.ResumeLayout(false);
            selectionPanel.PerformLayout();
            batterySelection.ResumeLayout(false);
            batterySelection.PerformLayout();
            optionsPanel.ResumeLayout(false);
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            clientDetailsPanel.ResumeLayout(false);
            clientDetailsPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            searchOptions.ResumeLayout(false);
            searchOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoImage;
        private Panel selectionPanel;
        private ListBox brandList;
        private Panel optionsPanel;
        private ListBox sizeList;
        private RadioButton battery3RadioButton;
        private GroupBox batterySelection;
        private RadioButton battery1RadioButton;
        private RadioButton battery2RadioButton;
        private Label brandLabel;
        private Label sizeLabel;
        private Label effectLabel;
        private Label brandPriceLabel;
        private Panel summaryPanel;
        private Label quantityLabel;
        private TextBox quantityInput;
        private CheckBox expInstallCheckBox;
        private Button quoteButton;
        private Button exitButton;
        private Button summaryButton;
        private Button orderButton;
        private Button clearButton;
        private ToolTip toolTip;
        private Label summaryLabel;
        private Panel summaryHeadingLine;
        private Label averageValueLabel;
        private Label grossValueLabel;
        private Label installationSummaryLabel;
        private Label invertorSummaryLabel;
        private Label batterySummaryLabel;
        private Label panelsSummaryLabel;
        private Label noOfOrdersLabel;
        private Panel summaryMidLine;
        private Label batteriesPercentage;
        private Label batteriesCostValue;
        private Label panelsPercentage;
        private Label panelsCostValue;
        private Label noOfOrders;
        private Label installationPercentage;
        private Label installationCostValue;
        private Label invertorsPercentage;
        private Label invertorsCostValue;
        private Label averageValue;
        private Label grossValue;
        private Label discountValueLabel;
        private Label netValueLabel;
        private Label noOfDiscountsLabel;
        private Label noOfDiscounts;
        private Label netValue;
        private Label discountValue;
        private Label panelDetails;
        private Label batteryDetails;
        private Label invertorDetails;
        private Label installationDetails;
        private RadioButton battery4RadioButton;
        private Label discountOffer;
        private Panel clientDetailsPanel;
        private Button cancelButton;
        private Button submitButton;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label emailLabel;
        private Label phoneLabel;
        private Label pastcodeLabel;
        private Label transactionLabel;
        private Label dateLabel;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private TextBox postcodeTextBox;
        private Label transactionNumber;
        private Label transactionDate;
        private Button searchButton;
        private Panel searchPanel;
        private GroupBox searchOptions;
        private RadioButton searchOption1;
        private RadioButton searchOption2;
        private Label searchLabel;
        private TextBox searchInput;
        private ListBox searchResults;
        private Button openButton;
        private Button enterButton;
    }
}
