using System;
using System.Windows.Forms;

namespace TestDataGenerator
{
    partial class GUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            generateButton = new Button();
            personNameCheckBox = new CheckBox();
            addressCheckBox = new CheckBox();
            ssnCheckBox = new CheckBox();
            bankDetailsCheckBox = new CheckBox();
            emailCheckBox = new CheckBox();
            credentialsCheckBox = new CheckBox();
            phoneNumberCheckBox = new CheckBox();
            diseaseCheckBox = new CheckBox();
            medicationCheckBox = new CheckBox();
            numberOfRows = new Label();
            numberOfRowsTextBox = new TextBox();
            label1 = new Label();
            numberOfFilesTextBox = new TextBox();
            buttonPII = new Button();
            buttonPHI = new Button();
            buttonFinancial = new Button();
            SuspendLayout();
            // 
            // generateButton
            // 
            generateButton.Location = new Point(448, 520);
            generateButton.Margin = new Padding(6, 7, 6, 7);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(217, 62);
            generateButton.TabIndex = 0;
            generateButton.Text = "Generate Data";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += GenerateButton_Click;
            // 
            // personNameCheckBox
            // 
            personNameCheckBox.AutoSize = true;
            personNameCheckBox.Location = new Point(41, 32);
            personNameCheckBox.Margin = new Padding(6, 7, 6, 7);
            personNameCheckBox.Name = "personNameCheckBox";
            personNameCheckBox.Size = new Size(110, 36);
            personNameCheckBox.TabIndex = 0;
            personNameCheckBox.Text = "Name";
            personNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressCheckBox
            // 
            addressCheckBox.AutoSize = true;
            addressCheckBox.Location = new Point(40, 96);
            addressCheckBox.Margin = new Padding(6, 7, 6, 7);
            addressCheckBox.Name = "addressCheckBox";
            addressCheckBox.Size = new Size(130, 36);
            addressCheckBox.TabIndex = 1;
            addressCheckBox.Text = "Address";
            addressCheckBox.UseVisualStyleBackColor = true;
            // 
            // ssnCheckBox
            // 
            ssnCheckBox.AutoSize = true;
            ssnCheckBox.Location = new Point(40, 160);
            ssnCheckBox.Margin = new Padding(6, 7, 6, 7);
            ssnCheckBox.Name = "ssnCheckBox";
            ssnCheckBox.Size = new Size(90, 36);
            ssnCheckBox.TabIndex = 2;
            ssnCheckBox.Text = "SSN";
            ssnCheckBox.UseVisualStyleBackColor = true;
            // 
            // bankDetailsCheckBox
            // 
            bankDetailsCheckBox.AutoSize = true;
            bankDetailsCheckBox.Location = new Point(40, 224);
            bankDetailsCheckBox.Margin = new Padding(6, 7, 6, 7);
            bankDetailsCheckBox.Name = "bankDetailsCheckBox";
            bankDetailsCheckBox.Size = new Size(177, 36);
            bankDetailsCheckBox.TabIndex = 3;
            bankDetailsCheckBox.Text = "Bank Details";
            bankDetailsCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailCheckBox
            // 
            emailCheckBox.AutoSize = true;
            emailCheckBox.Location = new Point(40, 288);
            emailCheckBox.Margin = new Padding(6, 7, 6, 7);
            emailCheckBox.Name = "emailCheckBox";
            emailCheckBox.Size = new Size(103, 36);
            emailCheckBox.TabIndex = 4;
            emailCheckBox.Text = "Email";
            emailCheckBox.UseVisualStyleBackColor = true;
            // 
            // credentialsCheckBox
            // 
            credentialsCheckBox.AutoSize = true;
            credentialsCheckBox.Location = new Point(40, 352);
            credentialsCheckBox.Margin = new Padding(6, 7, 6, 7);
            credentialsCheckBox.Name = "credentialsCheckBox";
            credentialsCheckBox.Size = new Size(165, 36);
            credentialsCheckBox.TabIndex = 5;
            credentialsCheckBox.Text = "Credentials";
            credentialsCheckBox.UseVisualStyleBackColor = true;
            // 
            // phoneNumberCheckBox
            // 
            phoneNumberCheckBox.AutoSize = true;
            phoneNumberCheckBox.Location = new Point(40, 416);
            phoneNumberCheckBox.Margin = new Padding(6, 7, 6, 7);
            phoneNumberCheckBox.Name = "phoneNumberCheckBox";
            phoneNumberCheckBox.Size = new Size(209, 36);
            phoneNumberCheckBox.TabIndex = 6;
            phoneNumberCheckBox.Text = "Phone Number";
            phoneNumberCheckBox.UseVisualStyleBackColor = true;
            // 
            // diseaseCheckBox
            // 
            diseaseCheckBox.AutoSize = true;
            diseaseCheckBox.Location = new Point(40, 480);
            diseaseCheckBox.Margin = new Padding(6, 7, 6, 7);
            diseaseCheckBox.Name = "diseaseCheckBox";
            diseaseCheckBox.Size = new Size(127, 36);
            diseaseCheckBox.TabIndex = 7;
            diseaseCheckBox.Text = "Disease";
            diseaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // medicationCheckBox
            // 
            medicationCheckBox.AutoSize = true;
            medicationCheckBox.Location = new Point(40, 544);
            medicationCheckBox.Margin = new Padding(6, 7, 6, 7);
            medicationCheckBox.Name = "medicationCheckBox";
            medicationCheckBox.Size = new Size(166, 36);
            medicationCheckBox.TabIndex = 8;
            medicationCheckBox.Text = "Medication";
            medicationCheckBox.UseVisualStyleBackColor = true;
            // 
            // numberOfRows
            // 
            numberOfRows.AutoSize = true;
            numberOfRows.Location = new Point(296, 32);
            numberOfRows.Margin = new Padding(6, 0, 6, 0);
            numberOfRows.Name = "numberOfRows";
            numberOfRows.Size = new Size(187, 32);
            numberOfRows.TabIndex = 9;
            numberOfRows.Text = "Number of rows";
            // 
            // numberOfRowsTextBox
            // 
            numberOfRowsTextBox.Location = new Point(496, 32);
            numberOfRowsTextBox.Margin = new Padding(6, 7, 6, 7);
            numberOfRowsTextBox.Name = "numberOfRowsTextBox";
            numberOfRowsTextBox.Size = new Size(176, 39);
            numberOfRowsTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 96);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 11;
            label1.Text = "Number of files";
            // 
            // numberOfFilesTextBox
            // 
            numberOfFilesTextBox.Location = new Point(496, 96);
            numberOfFilesTextBox.Margin = new Padding(6, 7, 6, 7);
            numberOfFilesTextBox.Name = "numberOfFilesTextBox";
            numberOfFilesTextBox.Size = new Size(176, 39);
            numberOfFilesTextBox.TabIndex = 12;
            // 
            // buttonPII
            // 
            buttonPII.Location = new Point(512, 160);
            buttonPII.Name = "buttonPII";
            buttonPII.Size = new Size(150, 46);
            buttonPII.TabIndex = 13;
            buttonPII.Text = "PII";
            buttonPII.UseVisualStyleBackColor = true;
            this.buttonPII.Click += new System.EventHandler(ButtonPII_Click);
            // 
            // buttonPHI
            // 
            buttonPHI.Location = new Point(512, 256);
            buttonPHI.Name = "buttonPHI";
            buttonPHI.Size = new Size(150, 46);
            buttonPHI.TabIndex = 14;
            buttonPHI.Text = "PHI";
            buttonPHI.UseVisualStyleBackColor = true;
            this.buttonPHI.Click += new System.EventHandler(PhiButton_Click);
            // 
            // buttonFinancial
            // 
            buttonFinancial.Location = new Point(512, 352);
            buttonFinancial.Name = "buttonFinancial";
            buttonFinancial.Size = new Size(150, 46);
            buttonFinancial.TabIndex = 15;
            buttonFinancial.Text = "Financial";
            buttonFinancial.UseVisualStyleBackColor = true;
            this.buttonFinancial.Click += new System.EventHandler(FinancialButton_Click);

            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 613);
            Controls.Add(buttonFinancial);
            Controls.Add(buttonPHI);
            Controls.Add(buttonPII);
            Controls.Add(generateButton);
            Controls.Add(numberOfFilesTextBox);
            Controls.Add(label1);
            Controls.Add(numberOfRowsTextBox);
            Controls.Add(numberOfRows);
            Controls.Add(personNameCheckBox);
            Controls.Add(medicationCheckBox);
            Controls.Add(diseaseCheckBox);
            Controls.Add(addressCheckBox);
            Controls.Add(phoneNumberCheckBox);
            Controls.Add(ssnCheckBox);
            Controls.Add(credentialsCheckBox);
            Controls.Add(bankDetailsCheckBox);
            Controls.Add(emailCheckBox);
            Margin = new Padding(6, 7, 6, 7);
            Name = "GUI";
            Text = "Test Data Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox personNameCheckBox;
        private System.Windows.Forms.CheckBox addressCheckBox;
        private System.Windows.Forms.CheckBox ssnCheckBox;
        private System.Windows.Forms.CheckBox bankDetailsCheckBox;
        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.CheckBox credentialsCheckBox;
        private System.Windows.Forms.CheckBox phoneNumberCheckBox;
        private System.Windows.Forms.CheckBox diseaseCheckBox;
        private System.Windows.Forms.CheckBox medicationCheckBox;
        private System.Windows.Forms.Label numberOfRows;
        private System.Windows.Forms.TextBox numberOfRowsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfFilesTextBox;
        private Button buttonPII;
        private Button buttonPHI;
        private Button buttonFinancial;
    }

}