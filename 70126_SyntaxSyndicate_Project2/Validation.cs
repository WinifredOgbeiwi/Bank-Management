using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70126_SyntaxSyndicate_Project2
{
    internal class Validation
    {
        public string FieldsValidation(Person person)
        {
            if (person.Name == "Name")
            {
                return "Please enter a name";
            }

            else if (person.LastName == "Last Name")
            {
                return "Please enter a last name";
            }

            else if (person.PhoneNumber == "123456789")
            {
                return "Please enter a phone number";
            }

            else if (person.PhoneNumber.Length != 9)
            {
                return "Phone Number must be 9 characters";
            }

            else if (!person.PhoneNumber.All(char.IsDigit))
            {
                return "Phone Number must contain only digits";
            }
            else if (person.Email == "your@email.com")
            {
                return "Please enter an email";
            }
            else if (!Utils.IsValidEmail(person.Email))
            {
                return "Please enter a valid email";
            }
            else if (person.Address == "ul.street 1/w2,01-234,city")
            {
                return "Please enter an address";
            }

            else if (person.Photo == "label3")
            {
                return "Please upload a photo";
            }
            return null;
        }
    }
}
