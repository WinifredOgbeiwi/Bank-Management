using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70126_SyntaxSyndicate_Project2
{
    internal class Customer : Person
    {
        private string plan, accountNumber;
        private decimal savings;
        public string Plan
        {
            get { return plan; }
            set { 
                
                plan = value;
            }
        }

   
        public decimal Savings
        {
            get { return savings; }
            set { savings =Utils.ValidateEdge(Convert.ToInt16(value)); }
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
       
        public override string DetailSaved()
        {
            return $"{Name}^{LastName}^+48{PhoneNumber}^{Email}^{Address}^{Plan}^{Balance}^{Savings}^{ID}^{AccountNumber}^{Photo}";
        }

        }
}
