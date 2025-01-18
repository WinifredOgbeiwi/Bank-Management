using _70126_SyntaxSyndicate_Project2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _70126_SyntaxSyndicate_Project2
{
    public partial class ShowCustomerForm : Form
    {
        public ShowCustomerForm()
        {
            InitializeComponent();
           
        }
        private List<Customer> customers = new List<Customer>();
        private int displayCustomerIndex = 0;
        private void CustomerDetails(Customer customer)
        {
            customerName.Text = customer.Name;
            customerLastName.Text = customer.LastName;
            customerEmail.Text = customer.Email;
            customerContact.Text = customer.PhoneNumber;
            customerAddress.Text = customer.Address;
            customerBalance.Text = customer.Balance.ToString();
            customerPlan.Text = customer.Plan;
            customerSavings.Text = customer.Savings.ToString();
            customerAcctNum.Text = customer.AccountNumber;
            customerID.Text = customer.ID;
            pictureBox1.ImageLocation = customer.Photo;
        }
        private void ShowCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fileStream = new FileStream("CustomerFile.txt", FileMode.Open, FileAccess.Read);
                StreamReader fileReader = new StreamReader(fileStream);
                while (!fileReader.EndOfStream)
                {
                    string customerDetails = fileReader.ReadLine();
                    string[] section = customerDetails.Split('&');

                    if (section.Length == 11) 
                    {
                        customers.Add(new Customer
                        {
                            Name = section[0].Trim(),
                            LastName = section[1].Trim(),
                            PhoneNumber = section[2].Trim(),
                            Email = section[3].Trim(),
                            Address = section[4].Trim(),
                            Plan = section[5].Trim(),
                            Balance = Convert.ToDecimal(section[6].Trim()), 
                            Savings = Convert.ToDecimal(section[7].Trim()),
                            ID = section[8].Trim(),
                            AccountNumber = section[9].Trim(),
                            Photo = section[10].Trim()
                        });
                    }
                    else
                    {
                        MessageBox.Show("Customer data format is incorrect, skipping this entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                labelPagination.Text = $" {displayCustomerIndex + 1} from {customers.Count}";
                fileReader.Close();
                fileStream.Close();

              
                if (customers.Count > 0)
                {
                    CustomerDetails(customers[displayCustomerIndex]);
                }
                else
                {
                    MessageBox.Show("No customers found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        public void RefreshCustomerData()
        { 
        
        customers.Clear();

             try
             {
                 FileStream fileStream = new FileStream("CustomerFile.txt", FileMode.Open, FileAccess.Read);
        StreamReader fileReader = new StreamReader(fileStream);
                 while (!fileReader.EndOfStream)
                 {
                     string customerDetails = fileReader.ReadLine();
        string[] section = customerDetails.Split('&');

                     if (section.Length == 11)
                     {
                         customers.Add(new Customer
                         {
                             Name = section[0].Trim(),
                             LastName = section[1].Trim(),
                             PhoneNumber = section[2].Trim(),
                             Email = section[3].Trim(),
                             Address = section[4].Trim(),
                             Plan = section[5].Trim(),
                             Balance = Convert.ToDecimal(section[6].Trim()),
                             Savings = Convert.ToDecimal(section[7].Trim()),
                             ID = section[8].Trim(),
                             AccountNumber = section[9].Trim(),
                             Photo = section[10].Trim()
                         });
    }
                     else
                     {
                         MessageBox.Show("Customer data format is incorrect, skipping this entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }

                 fileReader.Close();
fileStream.Close();

                 if (customers.Count > 0)
                 {
                     CustomerDetails(customers[displayCustomerIndex]);
                 }
                 else
                 {
                     MessageBox.Show("No customers found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     this.Close();
    }
}
             catch (Exception ex)
             {
                 MessageBox.Show($"An error occurred while loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
}


private void buttonControlBal_Click(object sender, EventArgs e)
        { 
        Customer selectedCustomer = customers[displayCustomerIndex];
        CustomerAccountControl customerAccountControl = new CustomerAccountControl(
     selectedCustomer.AccountNumber,
     selectedCustomer.ID,
   selectedCustomer.Balance,
     selectedCustomer.Savings);
        customerAccountControl.ShowDialog();
             RefreshCustomerData();
    }

    private void buttonPrev_Click_1(object sender, EventArgs e)
        { 

             if (customers.Count > 0 && displayCustomerIndex > 0)
             {
                 displayCustomerIndex--;
                 CustomerDetails(customers[displayCustomerIndex]);
        labelPagination.Text = $" {displayCustomerIndex + 1} from {customers.Count}";
             }
             else
             {
                 MessageBox.Show("This is the first customer.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }

         }

        private void buttonNext_Click(object sender, EventArgs e)
        { 
            if (customers.Count > 0 && displayCustomerIndex<customers.Count - 1)
            {
                displayCustomerIndex++;
                CustomerDetails(customers[displayCustomerIndex]);
        labelPagination.Text = $" {displayCustomerIndex + 1} from {customers.Count}";
            }
            else
            {
                MessageBox.Show("This is the last customer.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCustomerEdit_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = customers[displayCustomerIndex];
            EditCustomer editCustomer = new EditCustomer(selectedCustomer.Name,selectedCustomer.LastName, selectedCustomer.Email,selectedCustomer.PhoneNumber,selectedCustomer.Address, selectedCustomer.Plan, selectedCustomer.Photo,selectedCustomer.ID,selectedCustomer.AccountNumber,selectedCustomer.Balance, selectedCustomer.Savings );
            editCustomer.ShowDialog();
            RefreshCustomerData();


        }
    }

}
