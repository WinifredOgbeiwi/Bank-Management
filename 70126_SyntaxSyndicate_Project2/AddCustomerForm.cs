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
            utils.SetPlaceholder(textBoxAddress, "ul.123 address 789");
            utils.SetPlaceholder(textBoxBalance, "1000");
            utils.SetPlaceholder(textBoxContact, "+48 578 3728 243");
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
            openFileDialog1.Title = "Select Profile Image";
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
            customer.Balance = Convert.ToInt32(textBoxBalance.Text);
            customer.Plan = comboBoxPlan.SelectedItem.ToString();
            customer.Savings = 0;
            customer.AccountNumber = textBoxAcctNum.Text;
            customer.ID = textBoxCustID.Text;
           customer.Photo = pathname.Text;
            Utils utils = new Utils();
            utils.SaveFile("CustomerFile.txt", customer.DetailSaved(), "Customer details saved");

        }

        private void buttonExit_Add_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}