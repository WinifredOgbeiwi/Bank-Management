using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace _70126_SyntaxSyndicate_Project2
{


    public enum Role
    {
        Select_a_role = 0,
        Intern = 20,
        HR = 30,
        Developer = 40,
        Manager = 50,
       
    }

    internal class Staff : Person
    {
        private Role role;
        private int hours, extraHours;
        private decimal salaryPh, extraSalaryPh;

        public Role Role
        {
            get { return role; }
            set
            {
                role = value;
                SalaryPh = (decimal)role;
            }
        }
        public int Hours
        {
            get { return hours; }
            set { hours = value; } 
        }

        public int ExtraHours
        {
            get { return extraHours; }
            set { extraHours = value; }
        }


        public decimal SalaryPh { get; private set; }

        public decimal ExtraSalaryPh {
            get { return SalaryPh +(SalaryPh * 0.40M); }
        }


        public override string DetailSaved()
        {
            return $"{Name}^{LastName}^{Email}^+48{PhoneNumber}^{Address}^{ID}^{Role}^{Hours}^{ExtraHours}^{SalaryPh}^{Balance}^{Photo}";
        }

    }
}

