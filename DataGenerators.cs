using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static TestDataGenerator.DataLoaders;

namespace TestDataGenerator
{
    internal class DataGenerators
    {
        private static DataLoaders.NamesData _namesData;
        private static DataLoaders.AddressData _addressData;
        private static DataLoaders.BankingData _bankingData;
        private static DataLoaders.DomainData _domainData;
        private static DataLoaders.MedicationData _medicationData;
        private static DataLoaders.DiseaseData _diseaseData;

        public static void InitializeData()
        {
            string basePath = AppContext.BaseDirectory;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                basePath = Path.GetDirectoryName(AppContext.BaseDirectory);
            }

            string jsonFolder = Path.Combine(basePath, "JSONs");

            string jsonFilePathPersons = Path.Combine(jsonFolder, "person.json");
            string jsonFilePathFinance = Path.Combine(jsonFolder, "finance.json");
            string jsonFilePathCity = Path.Combine(jsonFolder, "address.json");
            string jsonFilePathMails = Path.Combine(jsonFolder, "domains.json");
            string jsonFilePathDisease = Path.Combine(jsonFolder, "diseases.json");
            string jsonFilePathMedication = Path.Combine(jsonFolder, "medications.json");

            _namesData = DataLoaders.LoadNamesData(jsonFilePathPersons);
            _addressData = DataLoaders.LoadAddressData(jsonFilePathCity);
            _bankingData = DataLoaders.LoadBankData(jsonFilePathFinance);
            _domainData = DataLoaders.LoadDomainData(jsonFilePathMails);
            _medicationData = DataLoaders.LoadMedicationData(jsonFilePathMedication);
            _diseaseData = DataLoaders.LoadDiseaseData(jsonFilePathDisease);
        }


        private static Random random = new Random();
        public static PersonName GenerateRandomName(DataLoaders.NamesData namesData)
        {
            var gender = random.Next(2) == 0 ? "female" : "male";
            var randomFirstName = namesData.Names[gender][random.Next(namesData.Names[gender].Count)];
            var randomSurname = namesData.Surnames[random.Next(namesData.Surnames.Count)];

            return new PersonName
            {
                FirstName = randomFirstName,
                Surname = randomSurname
            };
        }

        public static Address GenerateRandomAddress(DataLoaders.AddressData addressData)
        {
            var stateList = addressData.States.Keys.ToList();
            var state = stateList[random.Next(stateList.Count)];

            var cityList = addressData.States[state];
            var city = cityList[random.Next(cityList.Count)];

            var streetAddressList = addressData.Street.Name;
            var streetAddress = streetAddressList[random.Next(streetAddressList.Count)];

            var streetPostfixList = addressData.Street.Postfix;
            var streetPostfix = streetPostfixList[random.Next(streetPostfixList.Count)];

            var postcode = random.Next(1000, 9000);

            return new Address
            {
                State = state,
                City = city,
                StreetAddress = streetAddress,
                StreetPostfix = streetPostfix,
                Postcode = postcode.ToString()
            };
        }

        public static FinancialData GenerateFinancialData(DataLoaders.BankingData bankingData)
        {
            var bankList = bankingData.Banks;
            var bankName = bankList[random.Next(bankList.Count)];

            var routingNumber = random.Next(10000000, 99999999); 
            var accountNumber = random.Next(100000000, 999999999);
            var bankAccount = $"{routingNumber}-{accountNumber}";

            return new FinancialData
            {
                BankName = bankName,
                Account = bankAccount
            };
        }
        public static string GenerateEmails(PersonName personName, DataLoaders.DomainData domainData)
        {
            var domainList = domainData.Domain;
            var domainName = domainList[random.Next(domainList.Count)];

            var firstName = personName.FirstName.ToLower();
            var surname = personName.Surname.ToLower();

            var emailPatterns = new List<Func<string, string, string>>
            {
                (fn, sn) => $"{fn}{sn}@{domainName}",
                (fn, sn) => $"{fn}.{sn}@{domainName}",
                (fn, sn) => $"{fn}{random.Next(100, 1000)}@{domainName}",
                (fn, sn) => $"{fn}.{sn}{random.Next(100, 1000)}@{domainName}"
            };

            var selectedPattern = emailPatterns[random.Next(emailPatterns.Count)];

            var emailAddress = selectedPattern(firstName, surname);

            return emailAddress;
        }
        public static string GenerateDiseaseData(DataLoaders.DiseaseData diseaseData)
        {
            var diseaseList = diseaseData.Disease;
            var diseaseName = diseaseList[random.Next(diseaseList.Count)];

            return diseaseName;
        }
        public static string GenerateMedicationData(DataLoaders.MedicationData medicationData)
        {
            var medicationList = medicationData.Medication;
            var medicationName = medicationList[random.Next(medicationList.Count)];

            return medicationName;
        }

        public static DataLoaders.NamesData GetNamesData()
        {
            return _namesData;
        }

        public static DataLoaders.AddressData GetAddressData()
        {
            return _addressData;
        }

        public static DataLoaders.BankingData GetBankingData()
        {
            return _bankingData;
        }

        public static DataLoaders.DomainData GetDomainData()
        {
            return _domainData;
        }

        public static DataLoaders.MedicationData GetMedicationData()
        {
            return _medicationData;
        }

        public static DataLoaders.DiseaseData GetDiseaseData()
        {
            return _diseaseData;
        }

    }
    public static class SSNGenerator
    {
        private static Random random = new Random();
        public static string GenerateRandomSSN()
        {
            int area = random.Next(100, 999);
            int group = random.Next(10, 99);
            int serial = random.Next(1000, 9999);
            return $"{area:000}-{group:00}-{serial:0000}";
        }
    }

    public static class PasswordGenerator
    {
        private static Random random = new Random();
        private const string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Digits = "0123456789";
        private const string SpecialCharacters = "!@#$%^&*()-_=+[{]};:'\",<.>/?\\|`~";

        public static string GenerateRandomPassword(int minLength = 8, int maxLength = 30)
        {
            int length = random.Next(minLength, maxLength + 1);
            string passwordChars = LowercaseLetters + UppercaseLetters + Digits + SpecialCharacters;
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = passwordChars[random.Next(passwordChars.Length)];
            }
            return new string(password);
        }
    }

    public static class PhoneNumberGenerator
    {
        private static Random random = new Random();

        public static string GenerateRandomPhoneNumber()
        {
            int areaCode = random.Next(100, 1000);
            int exchange = random.Next(100, 1000);
            int lineNumber = random.Next(1000, 10000);

            return $"+1 ({areaCode}) {exchange}-{lineNumber}";
        }
    }
}
