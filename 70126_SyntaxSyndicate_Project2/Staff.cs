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
    internal class Staff:Person
    {
        private string role;
        private int hours, extraHours;
            private decimal salaryPH;

        public string Role
        {
            get { return role; }
            set {role = value;}
        }
        public int Hours
        {
            get { return hours; }
            set { hours = Utils.ValidateEdge(0); }
        }
        public int ExtraHours
        {
            get { return extraHours; }
            set { hours = Utils.ValidateEdge(0); }
        }
        public decimal SalaryPh
        {
            get { return salaryPH; }
            set { salaryPH = Utils.ValidateEdge(0); }
        }
        public override string DetailSaved()
        {
            return $"{Name}&{LastName}&{PhoneNumber}&{Email}&{Address}&{ID}&{Role}&{Photo}";
        }

    }
}

