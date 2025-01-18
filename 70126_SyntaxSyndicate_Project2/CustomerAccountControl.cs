using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _70126_SyntaxSyndicate_Project2
{
    public partial class CustomerAccountControl : Form
    {
        public CustomerAccountControl(string accountNumber,string customerID, string balance, string savings)
        {
            InitializeComponent();
            customerAcctNum.Text = accountNumber;
            customerID1.Text = customerID;
            customerBalance.Text = balance;
            customerSavings.Text = savings;
        }
      

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                decimal currentBalance = Convert.ToDecimal(customerBalance.Text);
                decimal withdrawalAmount = Convert.ToDecimal(textBoxWithdraw.Text);

                if (withdrawalAmount <= 0)
                {
                    MessageBox.Show("Withdrawal amount must be greater than zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (withdrawalAmount > currentBalance)
                {
                    MessageBox.Show("Insufficient balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal newBalance = currentBalance - withdrawalAmount;
                customerBalance.Text = newBalance.ToString();
                MessageBox.Show("Withdrawal successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               textBoxWithdraw.Text = string.Empty;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void buttonSaving_Click(object sender, EventArgs e)
        {
            try
            {
                decimal currentSaving = Convert.ToDecimal(customerSavings.Text);
                decimal currentBalance = Convert.ToDecimal(customerBalance.Text);
                decimal savingAmount = Convert.ToDecimal(textBoxSaving.Text);
                

                if (savingAmount <= 0)
                {
                    MessageBox.Show("Savings amount must be greater than zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (savingAmount > currentBalance)
                {
                    MessageBox.Show("Insufficient balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal newBalance = currentBalance - savingAmount;
                decimal newBalanceSaving = savingAmount + currentSaving;
                customerSavings.Text = newBalanceSaving.ToString();
                customerBalance.Text = newBalance.ToString();

                MessageBox.Show("Saving successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSaving.Text = string.Empty;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                decimal currentBalance = Convert.ToDecimal(customerBalance.Text);
                decimal depositAmount = Convert.ToDecimal(textBoxDeposit.Text);

                if (depositAmount <= 0)
                {
                    MessageBox.Show("Deposit amount must be greater than zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal newBalance = currentBalance + depositAmount;
                customerBalance.Text = newBalance.ToString();

                Utils.UpdateCustomerBalanceInFile(customerID1.Text, newBalance);
                MessageBox.Show("Deposit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDeposit.Text = string.Empty;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void labelCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void customerID_Click(object sender, EventArgs e)
        {

        }

        private void CustomerAccountControl_Load(object sender, EventArgs e)
        {

        }

        private void textBoxWithdraw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
