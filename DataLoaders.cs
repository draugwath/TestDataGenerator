using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGenerator
{
    internal class DataLoaders
    {
        public class NamesData
        {
            public Dictionary<string, List<string>> Names { get; set; }
            public List<string> Surnames { get; set; }
        }

        public static NamesData LoadNamesData(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var namesData = JsonConvert.DeserializeObject<NamesData>(json);
            return namesData;
        }

        public class AddressData
        {
            public Dictionary<string, List<string>> States { get; set; }
            public StreetData Street { get; set; }
        }

        public class StreetData
        {
            public List<string> Name { get; set; }
            public List<string> Postfix { get; set; }
        }

        public static AddressData LoadAddressData(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var addressData = JsonConvert.DeserializeObject<AddressData>(json);
            return addressData;
        }

        public class BankingData
        {
            public List<string> Banks { get; set; }
        }

        public static BankingData LoadBankData(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var bankingData = JsonConvert.DeserializeObject<BankingData>(json);
            return bankingData;
        }

        public class DomainData
        {
            public List<string> Domain { get; set; }
        }

        public static DomainData LoadDomainData(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var domainData = JsonConvert.DeserializeObject<DomainData>(json);
            return domainData;
        }

        public class DiseaseData
        {
            public List<string> Disease { get; set; }
        }

        public static DiseaseData LoadDiseaseData(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var diseaseData = JsonConvert.DeserializeObject<DiseaseData>(json);
            return diseaseData;
        }

        public class MedicationData
        {
            public List<string> Medication { get; set; }
        }

        public static MedicationData LoadMedicationData(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var medicationData = JsonConvert.DeserializeObject<MedicationData>(json);
            return medicationData;
        }

    }
}
