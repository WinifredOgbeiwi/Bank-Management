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
        private string plan, accountNumber, balance,savings;
        public string Plan
        {
            get { return plan; }
            set { 
                
                plan = value;
            }
        }

        public string Balance
        {
            get { return balance; }
            set { balance = Utils.ValidateEdge(Convert.ToInt32(value)).ToString(); }
        }
        public string Savings
        {
            get { return savings; }
            set { savings = Utils.ValidateEdge(0).ToString(); }
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
       
        public override string DetailSaved()
        {
            return $"{Name}&{LastName}&{PhoneNumber}&{Email}&{Address}&{Plan}&{Balance}&{Savings}&{ID}&{AccountNumber}&{Photo}";
        }

        }
}
