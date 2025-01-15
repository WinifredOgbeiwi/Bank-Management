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
                        Balance = 3445,
                        Savings = Convert.ToDecimal(section[7]),
                        ID = section[8].Trim(),
                        AccountNumber = section[9].Trim(),
                        Photo = section[10].Trim()

                    }
     );
                }
                else
                {
                    MessageBox.Show("Customer data format is incorrect, skip this entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            fileReader.Close();
            fileStream.Close();
            
            if (customers.Count > 0 && displayCustomerIndex >= 0 && displayCustomerIndex < customers.Count)
            {
                Customer customer = customers[displayCustomerIndex];
              customerName.Text = customer.Name;
                customerLastName.Text = customer.LastName;
                customerEmail.Text = customer.Email;
                customerContact.Text = customer.PhoneNumber;
                customerAddress.Text = customer.Address;
                customerBalance.Text = customer.Balance.ToString();
                customerPlan.Text = customer.Plan.ToString();
                customerSavings.Text = customer.Savings.ToString();
                customerAcctNum.Text = customer.AccountNumber;
                customerID.Text = customer.ID;
                pictureBox1.ImageLocation = customer.Photo;
            }
           
            else
            {
                MessageBox.Show("Failed to Load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }


















        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 }
}
