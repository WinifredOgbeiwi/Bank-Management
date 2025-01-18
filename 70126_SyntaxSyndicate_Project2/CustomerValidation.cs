using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70126_SyntaxSyndicate_Project2
{

    internal class CustomerValidation : Validation
    {
        public string customerValidation(Customer customer)
        {
            if (customer == null)
            {
                return "Customer information is required";
            }

            else if (customer.Balance <= 0)
            {
                return "Please enter a valid balance greater than zero";
            }

            else if (string.IsNullOrWhiteSpace(customer.Plan) || customer.Plan == "Plan")
            {
                return "Please select a plan";
            }

            return null;
        }
    }
}