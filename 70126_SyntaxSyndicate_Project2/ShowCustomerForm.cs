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

                    if (section.Length == 11) // Ensure there are 11 parts for a valid customer
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

                // Display the first customer if available
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

        private void CustomerDetails(Customer customer)
        {
            customerName.Text = customer.Name;
            customerLastName.Text = customer.LastName;
            customerEmail.Text = customer.Email;
            customerContact.Text = customer.PhoneNumber;
            customerAddress.Text = customer.Address;
            customerBalance.Text = customer.Balance.ToString("F2"); 
            customerPlan.Text = customer.Plan;
            customerSavings.Text = customer.Savings.ToString("F2");
            customerAcctNum.Text = customer.AccountNumber;
            customerID.Text = customer.ID;
            pictureBox1.ImageLocation = customer.Photo;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (customers.Count > 0 && displayCustomerIndex > 0)
            {
                displayCustomerIndex--;
                CustomerDetails(customers[displayCustomerIndex]);
            }
            else
            {
                MessageBox.Show("This is the first customer.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            if (customers.Count > 0 && displayCustomerIndex < customers.Count - 1)
            {
                displayCustomerIndex++;
                CustomerDetails(customers[displayCustomerIndex]);
            }
            else
            {
                MessageBox.Show("This is the last customer.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RefreshCustomerData()
        {
            // Clear current data
            customers.Clear();

            // Reload customer data from the file
            try
            {
                FileStream fileStream = new FileStream("CustomerFile.txt", FileMode.Open, FileAccess.Read);
                StreamReader fileReader = new StreamReader(fileStream);
                while (!fileReader.EndOfStream)
                {
                    string customerDetails = fileReader.ReadLine();
                    string[] section = customerDetails.Split('&');

                    if (section.Length == 11) // Ensure there are 11 parts for a valid customer
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

                // If customers are available, update the displayed details
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
