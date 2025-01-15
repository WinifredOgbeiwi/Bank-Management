using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70126_SyntaxSyndicate_Project2
{
    internal class Customer : Person
    {
        private string plan, accountNumber;
        private int balance, savings;
        public string Plan
        {
            get { return plan; }
            set { plan = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = Utils.ValidateEdge(value); }
        }
        public int Savings
        {
            get { return savings; }
            set { balance = Utils.ValidateEdge(0); }
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = $"5585 {Utils.GenerateUniqueID()} {Utils.GenerateUniqueID()} {Utils.GenerateUniqueID()}"; }
        }
        public override string ID
        {
            set
            {
                char[] letter = { 'A', 'B', 'C', 'D' };
                base.ID = $"{Utils.GenerateUniqueLetter(letter)}-{Utils.GenerateUniqueID()}";
            }
        }
        public override string DetailSaved { get => base.DetailSaved; set => base.DetailSaved = value; }
        {

        }
}
