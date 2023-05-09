using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGenerator
{
    public class PersonName
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {Surname}";
        }
    }  
}
