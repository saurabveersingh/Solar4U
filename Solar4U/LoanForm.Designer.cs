namespace Solar4U
{
    partial class LoanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanForm));
            transactionLabel = new Label();
            dateLabel = new Label();
            nameLabel = new Label();
            postcodeLabel = new Label();
            phoneLabel = new Label();
            emailLabel = new Label();
            panelsLabel = new Label();
            batteryLabel = new Label();
            invertorLabel = new Label();
            installationLabel = new Label();
            netValLabel = new Label();
            transactionNumber = new Label();
            installationDetails = new Label();
            invertorDetails = new Label();
            batteryDetails = new Label();
            panelsDetails = new Label();
            emailDetails = new Label();
            phoneDetails = new Label();
            postcodeDetails = new Label();
            nameDetails = new Label();
            shortDate = new Label();
            netValDetails = new Label();
            loanOptions = new GroupBox();
            loanOption4 = new RadioButton();
            loanOption1 = new RadioButton();
            loanOption2 = new RadioButton();
            loanOption3 = new RadioButton();
            loanOffer = new Label();
            proceedButton = new Button();
            backButton = new Button();
            toolTip1 = new ToolTip(components);
            loanOptions.SuspendLayout();
            SuspendLayout();
            // 
            // transactionLabel
            // 
            transactionLabel.AutoSize = true;
            transactionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transactionLabel.Location = new Point(50, 50);
            transactionLabel.Name = "transactionLabel";
            transactionLabel.Size = new Size(324, 45);
            transactionLabel.TabIndex = 8;
            transactionLabel.Text = "Transaction Number";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(50, 100);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(90, 45);
            dateLabel.TabIndex = 10;
            dateLabel.Text = "Date";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(50, 150);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(171, 45);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Full Name";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            postcodeLabel.Location = new Point(50, 200);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new Size(157, 45);
            postcodeLabel.TabIndex = 14;
            postcodeLabel.Text = "Postcode";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(50, 250);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(306, 45);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "Telephone Number";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(50, 300);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(211, 45);
            emailLabel.TabIndex = 18;
            emailLabel.Text = "Email Adress";
            // 
            // panelsLabel
            // 
            panelsLabel.AutoSize = true;
            panelsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelsLabel.Location = new Point(50, 350);
            panelsLabel.Name = "panelsLabel";
            panelsLabel.Size = new Size(115, 45);
            panelsLabel.TabIndex = 20;
            panelsLabel.Text = "Panels";
            // 
            // batteryLabel
            // 
            batteryLabel.AutoSize = true;
            batteryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            batteryLabel.Location = new Point(50, 400);
            batteryLabel.Name = "batteryLabel";
            batteryLabel.Size = new Size(130, 45);
            batteryLabel.TabIndex = 22;
            batteryLabel.Text = "Battery";
            // 
            // invertorLabel
            // 
            invertorLabel.AutoSize = true;
            invertorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invertorLabel.Location = new Point(50, 450);
            invertorLabel.Name = "invertorLabel";
            invertorLabel.Size = new Size(142, 45);
            invertorLabel.TabIndex = 24;
            invertorLabel.Text = "Invertor";
            // 
            // installationLabel
            // 
            installationLabel.AutoSize = true;
            installationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            installationLabel.Location = new Point(50, 500);
            installationLabel.Name = "installationLabel";
            installationLabel.Size = new Size(187, 45);
            installationLabel.TabIndex = 26;
            installationLabel.Text = "Installation";
            // 
            // netValLabel
            // 
            netValLabel.AutoSize = true;
            netValLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            netValLabel.Location = new Point(50, 550);
            netValLabel.Name = "netValLabel";
            netValLabel.Size = new Size(164, 45);
            netValLabel.TabIndex = 28;
            netValLabel.Text = "Net Value";
            // 
            // transactionNumber
            // 
            transactionNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            transactionNumber.Location = new Point(375, 50);
            transactionNumber.Name = "transactionNumber";
            transactionNumber.Size = new Size(350, 45);
            transactionNumber.TabIndex = 9;
            transactionNumber.Text = "000000";
            transactionNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // installationDetails
            // 
            installationDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            installationDetails.Location = new Point(375, 500);
            installationDetails.Name = "installationDetails";
            installationDetails.Size = new Size(350, 45);
            installationDetails.TabIndex = 27;
            installationDetails.Text = "000000";
            installationDetails.TextAlign = ContentAlignment.MiddleRight;
            // 
            // invertorDetails
            // 
            invertorDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invertorDetails.Location = new Point(375, 450);
            invertorDetails.Name = "invertorDetails";
            invertorDetails.Size = new Size(350, 45);
            invertorDetails.TabIndex = 25;
            invertorDetails.Text = "000000";
            invertorDetails.TextAlign = ContentAlignment.MiddleRight;
            // 
            // batteryDetails
            // 
            batteryDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            batteryDetails.Location = new Point(375, 400);
            batteryDetails.Name = "batteryDetails";
            batteryDetails.Size = new Size(350, 45);
            batteryDetails.TabIndex = 23;
            batteryDetails.Text = "Not Required";
            batteryDetails.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelsDetails
            // 
            panelsDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelsDetails.Location = new Point(375, 350);
            panelsDetails.Name = "panelsDetails";
            panelsDetails.Size = new Size(350, 45);
            panelsDetails.TabIndex = 21;
            panelsDetails.Text = "000000";
            panelsDetails.TextAlign = ContentAlignment.MiddleRight;
            // 
            // emailDetails
            // 
            emailDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailDetails.Location = new Point(375, 300);
            emailDetails.Name = "emailDetails";
            emailDetails.Size = new Size(350, 45);
            emailDetails.TabIndex = 19;
            emailDetails.Text = "000000";
            emailDetails.TextAlign = ContentAlignment.MiddleRight;
            // 
            // phoneDetails
            // 
            phoneDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneDetails.Location = new Point(375, 250);
            phoneDetails.Name = "phoneDetails";
            phoneDetails.Size = new Size(350, 45);
            phoneDetails.TabIndex = 17;
            phoneDetails.Text = "000000";
            phoneDetails.TextAlign = ContentAlignment.MiddleRight;
            // 
            // postcodeDetails
            // 
            postcodeDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            postcodeDetails.Location = new Point(375, 200);
            postcodeDetails.Name = "postcodeDetails";
            postcodeDetails.Size = new Size(350, 45);
            postcodeDetails.TabIndex = 15;
            postcodeDetails.Text = "000000";
            postcodeDetails.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameDetails
            // 
            nameDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameDetails.Location = new Point(375, 150);
            nameDetails.Name = "nameDetails";
            nameDetails.Size = new Size(350, 45);
            nameDetails.TabIndex = 13;
            nameDetails.Text = "000000";
            nameDetails.TextAlign = ContentAlignment.MiddleRight;
            // 
            // shortDate
            // 
            shortDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shortDate.Location = new Point(375, 100);
            shortDate.Name = "shortDate";
            shortDate.Size = new Size(350, 45);
            shortDate.TabIndex = 11;
            shortDate.Text = "000000";
            shortDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // netValDetails
            // 
            netValDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            netValDetails.Location = new Point(375, 550);
            netValDetails.Name = "netValDetails";
            netValDetails.Size = new Size(350, 45);
            netValDetails.TabIndex = 29;
            netValDetails.Text = "000000";
            netValDetails.TextAlign = ContentAlignment.MiddleRight;
            // 
            // loanOptions
            // 
            loanOptions.BackColor = Color.Gray;
            loanOptions.Controls.Add(loanOption4);
            loanOptions.Controls.Add(loanOption1);
            loanOptions.Controls.Add(loanOption2);
            loanOptions.Controls.Add(loanOption3);
            loanOptions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loanOptions.ForeColor = Color.White;
            loanOptions.Location = new Point(50, 650);
            loanOptions.Name = "loanOptions";
            loanOptions.Size = new Size(675, 270);
            loanOptions.TabIndex = 6;
            loanOptions.TabStop = false;
            loanOptions.Text = "Loan Options";
            // 
            // loanOption4
            // 
            loanOption4.AutoSize = true;
            loanOption4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loanOption4.ForeColor = Color.White;
            loanOption4.Location = new Point(15, 199);
            loanOption4.Name = "loanOption4";
            loanOption4.Size = new Size(241, 49);
            loanOption4.TabIndex = 3;
            loanOption4.TabStop = true;
            loanOption4.Text = "Not Required";
            loanOption4.UseVisualStyleBackColor = true;
            // 
            // loanOption1
            // 
            loanOption1.AutoSize = true;
            loanOption1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loanOption1.ForeColor = Color.White;
            loanOption1.Location = new Point(15, 49);
            loanOption1.Name = "loanOption1";
            loanOption1.Size = new Size(583, 49);
            loanOption1.TabIndex = 0;
            loanOption1.TabStop = true;
            loanOption1.Text = "1 Year (1.25%), Repayment = $200000";
            loanOption1.UseVisualStyleBackColor = true;
            // 
            // loanOption2
            // 
            loanOption2.AutoSize = true;
            loanOption2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loanOption2.ForeColor = Color.White;
            loanOption2.Location = new Point(15, 99);
            loanOption2.Name = "loanOption2";
            loanOption2.Size = new Size(583, 49);
            loanOption2.TabIndex = 1;
            loanOption2.TabStop = true;
            loanOption2.Text = "3 Year (1.25%), Repayment = $200000";
            loanOption2.UseVisualStyleBackColor = true;
            // 
            // loanOption3
            // 
            loanOption3.AutoSize = true;
            loanOption3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loanOption3.ForeColor = Color.White;
            loanOption3.Location = new Point(15, 149);
            loanOption3.Name = "loanOption3";
            loanOption3.Size = new Size(583, 49);
            loanOption3.TabIndex = 2;
            loanOption3.TabStop = true;
            loanOption3.Text = "5 Year (1.25%), Repayment = $200000";
            loanOption3.UseVisualStyleBackColor = true;
            // 
            // loanOffer
            // 
            loanOffer.AutoSize = true;
            loanOffer.Font = new Font("Segoe UI", 10F);
            loanOffer.Location = new Point(56, 923);
            loanOffer.Name = "loanOffer";
            loanOffer.Size = new Size(533, 37);
            loanOffer.TabIndex = 7;
            loanOffer.Text = "*Free System Insurance on 5 Year loan term!";
            loanOffer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // proceedButton
            // 
            proceedButton.BackColor = Color.LightGray;
            proceedButton.FlatAppearance.BorderColor = Color.Gray;
            proceedButton.FlatAppearance.BorderSize = 5;
            proceedButton.FlatStyle = FlatStyle.Flat;
            proceedButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            proceedButton.ForeColor = Color.Black;
            proceedButton.Location = new Point(425, 1000);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(200, 52);
            proceedButton.TabIndex = 5;
            proceedButton.Text = "&Proceed";
            toolTip1.SetToolTip(proceedButton, "Proceed with the order.");
            proceedButton.UseVisualStyleBackColor = false;
            proceedButton.Click += ProceedButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.LightGray;
            backButton.FlatAppearance.BorderColor = Color.Gray;
            backButton.FlatAppearance.BorderSize = 5;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            backButton.ForeColor = Color.Black;
            backButton.Location = new Point(150, 1000);
            backButton.Name = "backButton";
            backButton.Size = new Size(200, 52);
            backButton.TabIndex = 4;
            backButton.Text = "&Back";
            toolTip1.SetToolTip(backButton, "Go back to Previous Screen");
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += BackButton_Click;
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 1129);
            Controls.Add(backButton);
            Controls.Add(proceedButton);
            Controls.Add(loanOffer);
            Controls.Add(loanOptions);
            Controls.Add(netValDetails);
            Controls.Add(shortDate);
            Controls.Add(nameDetails);
            Controls.Add(postcodeDetails);
            Controls.Add(phoneDetails);
            Controls.Add(emailDetails);
            Controls.Add(panelsDetails);
            Controls.Add(batteryDetails);
            Controls.Add(invertorDetails);
            Controls.Add(installationDetails);
            Controls.Add(transactionNumber);
            Controls.Add(netValLabel);
            Controls.Add(installationLabel);
            Controls.Add(invertorLabel);
            Controls.Add(batteryLabel);
            Controls.Add(panelsLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneLabel);
            Controls.Add(postcodeLabel);
            Controls.Add(nameLabel);
            Controls.Add(dateLabel);
            Controls.Add(transactionLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoanForm";
            Text = "LoanForm";
            loanOptions.ResumeLayout(false);
            loanOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label transactionLabel;
        private Label dateLabel;
        private Label nameLabel;
        private Label postcodeLabel;
        private Label phoneLabel;
        private Label emailLabel;
        private Label panelsLabel;
        private Label batteryLabel;
        private Label invertorLabel;
        private Label installationLabel;
        private Label netValLabel;
        private Label transactionNumber;
        private Label installationDetails;
        private Label invertorDetails;
        private Label batteryDetails;
        private Label panelsDetails;
        private Label emailDetails;
        private Label phoneDetails;
        private Label postcodeDetails;
        private Label nameDetails;
        private Label shortDate;
        private Label netValDetails;
        private GroupBox loanOptions;
        private RadioButton loanOption4;
        private RadioButton loanOption1;
        private RadioButton loanOption2;
        private RadioButton loanOption3;
        private Label loanOffer;
        private Button proceedButton;
        private Button backButton;
        private ToolTip toolTip1;
    }
}