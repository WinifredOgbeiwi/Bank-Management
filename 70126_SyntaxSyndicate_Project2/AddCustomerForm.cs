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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _70126_SyntaxSyndicate_Project2
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }
        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            //Adding Placeholder
            Utils utils = new Utils();
            utils.SetPlaceholder(textBoxName, "Name");
            utils.SetPlaceholder(textBoxLastName, "Last Name");
            utils.SetPlaceholder(textBoxEmail, "your@email.com");
            utils.SetPlaceholder(textBoxAddress, "ul.street 1/w2,01-234,city");
            utils.SetPlaceholder(textBoxBalance, "0000");
            utils.SetPlaceholder(textBoxContact, "123456789");
            utils.SetComboBoxPlaceholder(comboBoxPlan);

            //Getting auto customer id and account number
            Customer customer = new Customer();
            customer.AccountNumber = Utils.GeneratedAccountNumber();
            char[] letter = { 'A', 'B', 'C', 'D' };
            customer.ID = Utils.GeneratedUserID(letter);   
            textBoxAcctNum.Text = customer.AccountNumber;
            textBoxCustID.Text = customer.ID;


            //adding plans to input
            comboBoxPlan.DataSource = Utils.Plans();
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                pathname.Text = openFileDialog1.FileName;
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.Name = textBoxName.Text;
            customer.Email = textBoxEmail.Text;
            customer.LastName = textBoxLastName.Text;
            customer.Address = textBoxAddress.Text;
            customer.PhoneNumber = textBoxContact.Text;
            customer.Balance = textBoxBalance.Text;
            customer.Plan = comboBoxPlan.SelectedItem.ToString();
            customer.Savings = 0.ToString();
            customer.AccountNumber = textBoxAcctNum.Text;
            customer.ID = textBoxCustID.Text;
            customer.Photo = pathname.Text;

            string validation = Utils.FieldsValidation(customer);
               

            if (validation != null)
            {
                MessageBox.Show(validation, " Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(customer.Balance) || customer.Balance == "0")
            {
                MessageBox.Show("Please enter a valid balance greater than zero", " Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(customer.Plan) || customer.Plan == "Plan")
            {
                MessageBox.Show("Please select a plan", " Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
       
                Utils utils = new Utils();
                utils.SaveFile("CustomerFile.txt", customer.DetailSaved(), "Customer details saved");
            }
        }

        private void buttonExit_Add_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}