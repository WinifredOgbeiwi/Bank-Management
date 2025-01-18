using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _70126_SyntaxSyndicate_Project2.Utils;

namespace _70126_SyntaxSyndicate_Project2
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void buttonExit_AddStaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            //Adding Placeholder
            Utils utils = new Utils();
            utils.SetPlaceholder(textBoxName, "Name");
            utils.SetPlaceholder(textBoxLastName, "Last Name");
            utils.SetPlaceholder(textBoxEmail, "your@email.com");
            utils.SetPlaceholder(textBoxAddress, "ul.street 1/w2,01-234,city");
            utils.SetPlaceholder(textBoxBalance, "0000");
            utils.SetPlaceholder(textBoxContact, "123456789");
            utils.SetComboBoxPlaceholder(comboBoxRole);

            //Getting auto customer id
            Customer customer = new Customer();
       
            char[] letter = { 'T', 'L', 'X', 'Y', 'Z' };
            customer.ID = Utils.GeneratedUserID(letter);

            textBoxCustID.Text = customer.ID;

            ////adding role to input
           comboBoxRole.Items.Insert(0, "Select a role");

        
            comboBoxRole.DataSource = Enum.GetValues(typeof(Utils.Role));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Name = textBoxName.Text;
            staff.LastName = textBoxLastName.Text;
            staff.Email = textBoxEmail.Text;
            staff.PhoneNumber = textBoxContact.Text;
            staff.Address = textBoxAddress.Text;
            staff.ID = textBoxCustID.Text;
            staff.Role = comboBoxRole.SelectedItem.ToString();
            staff.Photo = pathname.Text;
            staff.Balance = 0;
            staff.Hours = 0;
            staff.ExtraHours = 0;

            string validation = Utils.FieldsValidation(staff);


            if (validation != null)
            {
                MessageBox.Show(validation, " Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
            else if (string.IsNullOrWhiteSpace(staff.Role) || staff.Role == "Select Role")
            {
                MessageBox.Show("Please select a plan", " Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {

                Utils utils = new Utils();
                utils.SaveFile("StaffFile.txt", staff.DetailSaved(), "Staff details saved");
            }
        }
    }

}
