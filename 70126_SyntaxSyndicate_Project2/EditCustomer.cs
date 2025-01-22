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
    public partial class EditCustomer : Form
    {
        private Form passwordForm;
        private Action refreshdata;
        public EditCustomer( Action _refreshData, Form prevform, string name, string lastName, string email,string phoneNumber, string address, string plan, string photo, string customerID, string accountNum, decimal balance, decimal savings, string password )
        {
            InitializeComponent();
            refreshdata = _refreshData;
            passwordForm = prevform;
            textBoxName.Text = name;
            textBoxLastName.Text = lastName;
            textBoxEmail.Text = email;
            textBoxContact.Text = phoneNumber;
            textBoxAddress.Text = address;
            comboBoxPlan.DataSource = Utils.Plans(); 
            comboBoxPlan.SelectedItem = plan;
            textBoxAcctNum.Text = accountNum;
            textBoxBalance.Text = balance.ToString();
            textBoxSavings.Text = savings.ToString();
            textBoxCustID.Text = customerID;
            pictureBox.ImageLocation = photo;
            textBoxPassword.Text = password;
    
        }

        private void buttonExit_Add_Click(object sender, EventArgs e)
        {
            this.Close();
            passwordForm.Close();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {

        }
        private void buttonPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.jpeg";
            
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.UpdateCustomerInFile(textBoxCustID.Text, textBoxName.Text,textBoxLastName.Text,textBoxEmail.Text,textBoxContact.Text,textBoxAddress.Text,comboBoxPlan.SelectedItem.ToString(),pathname.Text,textBoxAcctNum.Text,Convert.ToDecimal(textBoxBalance.Text),Convert.ToDecimal(textBoxSavings.Text), textBoxPassword.Text);
                
               
                if (MessageBox.Show("Changes Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    
                    this.Close();
                    passwordForm.Close();
                    refreshdata?.Invoke();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Can not save modification", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

    
    }
}
