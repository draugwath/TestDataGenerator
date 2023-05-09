using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGenerator
{
    public class DataConstructor
    {
        public string PersonName { get; set; }
        public string Address { get; set; }
        public string SSNNumber { get; set; }
        public string BankDetails { get; set; }
        public string Email { get; set; }
        public string Credentials { get; set; }
        public string PhoneNumber { get; set; }
        public string Disease { get; set; }
        public string Medication { get; set; }

        public DataConstructor(string personName, string address, string SSN, string bankDetails, string email, string credentials, string phoneNumber, string disease, string medication)
        {
            PersonName = personName;
            Address = address;
            SSNNumber = SSN;
            BankDetails = bankDetails;
            Email = email;
            Credentials = credentials;
            PhoneNumber = phoneNumber;
            Disease = disease;
            Medication = medication;
        }
    }
}
