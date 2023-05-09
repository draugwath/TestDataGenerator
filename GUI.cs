using TestDataGenerator;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace TestDataGenerator
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            DataGenerators.InitializeData();
        }

        private void UncheckAll()
        {
            personNameCheckBox.Checked = false;
            phoneNumberCheckBox.Checked = false;
            emailCheckBox.Checked = false;
            ssnCheckBox.Checked = false;
            addressCheckBox.Checked = false;
            diseaseCheckBox.Checked = false;
            medicationCheckBox.Checked = false;
            credentialsCheckBox.Checked = false;
            bankDetailsCheckBox.Checked = false;
        }
        private void GenerateData()
        {
            // Get the number of rows and files from the input fields
            if (!int.TryParse(numberOfRowsTextBox.Text, out int numberOfRows) || numberOfRows < 1)
            {
                MessageBox.Show("Please enter a valid number of rows.");
                return;
            }
            if (!int.TryParse(numberOfFilesTextBox.Text, out int numberOfFiles) || numberOfFiles < 1)
            {
                MessageBox.Show("Please enter a valid number of files.");
                return;
            }

            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string outputDirectory = Path.Combine(exeDirectory, "Output");

            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            // Generate the data
            for (int file = 0; file < numberOfFiles; file++)
            {
                string[] selectedOptions = GetSelectedOptions();

                if (selectedOptions.Length == 0)
                {
                    MessageBox.Show("Please select at least one data type to generate.");
                    return;
                }

                // Generate a random file name
                string randomFileName = Path.GetRandomFileName();
                string outputPath = Path.Combine(outputDirectory, $"{randomFileName}.csv");

                GenerateTestData(numberOfRows, selectedOptions, outputPath);
            }

            MessageBox.Show("Data exported to CSV files successfully.");
        }

        private string[] GetSelectedOptions()
        {
            List<string> options = new List<string>();

            if (personNameCheckBox.Checked) options.Add("Person");
            if (addressCheckBox.Checked) options.Add("Address");
            if (ssnCheckBox.Checked) options.Add("SSN");
            if (bankDetailsCheckBox.Checked) options.Add("BankDetails");
            if (emailCheckBox.Checked) options.Add("Email");
            if (credentialsCheckBox.Checked) options.Add("Credentials");
            if (phoneNumberCheckBox.Checked) options.Add("Phone");
            if (diseaseCheckBox.Checked) options.Add("Disease");
            if (medicationCheckBox.Checked) options.Add("Medication");

            return options.ToArray();
        }
        private void ButtonPII_Click(object sender, EventArgs e)
        {
            UncheckAll();
            personNameCheckBox.Checked = true;
            phoneNumberCheckBox.Checked = true;
            emailCheckBox.Checked = true;
            ssnCheckBox.Checked = true;
            addressCheckBox.Checked = true;
        }

        private void PhiButton_Click(object sender, EventArgs e)
        {
            UncheckAll();
            personNameCheckBox.Checked = true;
            emailCheckBox.Checked = true;
            diseaseCheckBox.Checked = true;
            medicationCheckBox.Checked = true;
        }

        private void FinancialButton_Click(object sender, EventArgs e)
        {
            UncheckAll();
            personNameCheckBox.Checked = true;
            emailCheckBox.Checked = true;
            credentialsCheckBox.Checked = true;
            bankDetailsCheckBox.Checked = true;
        }


        private void GenerateTestData(int numberOfRows, string[] selectedOptions, string outputPath)
        {
            List<DataConstructor> data = new List<DataConstructor>();

            for (int i = 0; i < numberOfRows; i++)
            {
                string personName = null, address = null, ssn = null, bankDetails = null, email = null, credentials = null, phoneNumber = null, disease = null, medication = null;

                // Always generate the name for consistency between name and email
                var randomPersonName = DataGenerators.GenerateRandomName(DataGenerators.GetNamesData());
                if (selectedOptions.Contains("Person"))
                {
                    personName = $"{randomPersonName.FirstName} {randomPersonName.Surname}";
                }

                if (selectedOptions.Contains("Address"))
                {
                    var randomAddress = DataGenerators.GenerateRandomAddress(DataGenerators.GetAddressData());
                    address = $"\"{randomAddress.StreetAddress} {randomAddress.StreetPostfix}, {randomAddress.City}, {randomAddress.State} | {randomAddress.Postcode}\"";
                }

                if (selectedOptions.Contains("Email"))
                {
                    email = DataGenerators.GenerateEmails(randomPersonName, DataGenerators.GetDomainData());
                }

                if (selectedOptions.Contains("SSN"))
                {
                    ssn = SSNGenerator.GenerateRandomSSN();
                }

                if (selectedOptions.Contains("BankDetails"))
                {
                    var financialData = DataGenerators.GenerateFinancialData(DataGenerators.GetBankingData());
                    bankDetails = $"{financialData.BankName} | {financialData.Account}";
                }

                if (selectedOptions.Contains("Credentials"))
                {
                    credentials = PasswordGenerator.GenerateRandomPassword();
                }

                if (selectedOptions.Contains("Disease"))
                {
                    disease = DataGenerators.GenerateDiseaseData(DataGenerators.GetDiseaseData());
                }

                if (selectedOptions.Contains("Medication"))
                {
                    medication = DataGenerators.GenerateMedicationData(DataGenerators.GetMedicationData());
                }

                if (selectedOptions.Contains("Phone"))
                {
                    phoneNumber = PhoneNumberGenerator.GenerateRandomPhoneNumber();
                }

                DataConstructor testData = new DataConstructor(personName, address, ssn, bankDetails, email, credentials, phoneNumber, disease, medication);
                data.Add(testData);
            }

            // Export the data to CSV
            ExportToCsv(data, numberOfRows, selectedOptions, outputPath);
        }

        public static void ExportToCsv(List<DataConstructor> data, int numberOfRows, string[] selectedOptions, string outputPath)
        {
            var csv = new StringBuilder();
            var headerBuilder = new StringBuilder();

            // Dynamically generate the header
            foreach (var option in selectedOptions)
            {
                switch (option)
                {
                    case "Person":
                        headerBuilder.Append("Person Name,");
                        break;
                    case "Address":
                        headerBuilder.Append("Address,");
                        break;
                    case "SSN":
                        headerBuilder.Append("SSN,");
                        break;
                    case "BankDetails":
                        headerBuilder.Append("Bank Details,");
                        break;
                    case "Email":
                        headerBuilder.Append("Email,");
                        break;
                    case "Credentials":
                        headerBuilder.Append("Credentials,");
                        break;
                    case "Phone":
                        headerBuilder.Append("Phone Number,");
                        break;
                    case "Disease":
                        headerBuilder.Append("Disease,");
                        break;
                    case "Medication":
                        headerBuilder.Append("Medication,");
                        break;
                }
            }

            // Remove trailing comma and add header to CSV
            string header = headerBuilder.ToString().TrimEnd(',');
            csv.AppendLine(header);

            for (int i = 0; i < numberOfRows; i++)
            {
                var rowBuilder = new StringBuilder();

                foreach (var option in selectedOptions)
                {
                    switch (option)
                    {
                        case "Person":
                            rowBuilder.Append($"{data[i].PersonName},");
                            break;
                        case "Address":
                            rowBuilder.Append($"{data[i].Address},");
                            break;
                        case "SSN":
                            rowBuilder.Append($"{data[i].SSNNumber},");
                            break;
                        case "BankDetails":
                            rowBuilder.Append($"{data[i].BankDetails},");
                            break;
                        case "Email":
                            rowBuilder.Append($"{data[i].Email},");
                            break;
                        case "Credentials":
                            rowBuilder.Append($"{data[i].Credentials},");
                            break;
                        case "Phone":
                            rowBuilder.Append($"{data[i].PhoneNumber},");
                            break;
                        case "Disease":
                            rowBuilder.Append($"{data[i].Disease},");
                            break;
                        case "Medication":
                            rowBuilder.Append($"{data[i].Medication},");
                            break;
                    }
                }

                // Remove trailing comma and add row to CSV
                string row = rowBuilder.ToString().TrimEnd(',');
                csv.AppendLine(row);
            }

            File.WriteAllText(outputPath, csv.ToString());
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateData();
        }
    }
}


