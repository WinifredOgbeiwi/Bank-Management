using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _70126_SyntaxSyndicate_Project2
{
    public partial class PasswordForm : Form
    {
        private string password, name, lastName, email, phoneNumber, address, plan, photo, id, accountNumber;
        private Action refreshData;
        private void buttonExit_Add_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal balance, saving;
        public PasswordForm(Action refresh, string _name, string _lastName, string _email, string _phoneNumber, string _address, string _plan, string _photo, string _id, string _accountNumber, decimal _balance, decimal _savings, string _password)
        {
            InitializeComponent();
            refreshData = refresh;
            password = _password;
            lastName = _lastName;
            email = _email;
            phoneNumber = _phoneNumber;
            address = _address;
            plan = _plan;
            photo = _photo;
            id = _id;
            name = _name;
            balance = _balance;
            saving = _savings;
            accountNumber = _accountNumber;
        }


        private void ShowEditCustomerForm()
        {
            
            EditCustomer editCustomer = new EditCustomer(refreshData, this, name, lastName, email, phoneNumber, address, plan, photo, id, accountNumber, balance, saving, password);

         
            editCustomer.ShowDialog();
        }

      
        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == password)
            {
                ShowEditCustomerForm();
            }
            else MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OKCancel);
        }
    }
}
