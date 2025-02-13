﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _70126_SyntaxSyndicate_Project2
{
    internal class Person
    {

        private string name, lastName, photo, address, email, id, phoneNumber, password;
        private decimal balance;

        public string Name
        {
            get { return name; }
            set { name = Utils.capitalized(value);}
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = Utils.capitalized(value); }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value;}
        }
    
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public virtual string ID
        {
            get { return id; }
            set { id = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public virtual string DetailSaved()
        {
            return null;
        }
    }
};
