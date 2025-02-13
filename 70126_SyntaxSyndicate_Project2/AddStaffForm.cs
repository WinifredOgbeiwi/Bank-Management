﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            utils.SetPlaceholder(textBoxContact, "123456789");
            utils.SetComboBoxPlaceholder(comboBoxRole);

            //Getting auto customer id
            Customer customer = new Customer();
       
            char[] letter = { 'T', 'L', 'X', 'Y', 'Z' };
            customer.ID = Utils.GeneratedUserID(letter);

            textBoxCustID.Text = customer.ID;

            ////adding role to input
            comboBoxRole.DataSource = Enum.GetNames(typeof(Role));

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
                string filePath = openFileDialog1.FileName;

                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Staff_Images");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string combineFilePath = Path.Combine(folderPath, Path.GetFileName(filePath));
                File.Copy(filePath, combineFilePath, true);
                pictureBox.Image = Image.FromFile(combineFilePath);

                pathname.Text = combineFilePath;
                //openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.jpeg";
                //if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                //    pathname.Text = openFileDialog1.FileName;
                //}
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
            staff.Role = (Role)Enum.Parse(typeof(Role), comboBoxRole.SelectedItem.ToString());
            staff.Photo = pathname.Text;
            staff.Balance = 0.00m;
            staff.Hours = 0;
            staff.ExtraHours = 0;


            string validation = Utils.FieldsValidation(staff);


            if (validation != null)
            {
                MessageBox.Show(validation, " Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (staff.Role == Role.Select_a_role)
            {
                MessageBox.Show("Please select a Role", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {

                Utils utils = new Utils();
                utils.SaveFile("StaffFile.txt", staff.DetailSaved(), "Staff details saved");
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowStafff showStafff = new ShowStafff();
            showStafff.ShowDialog();
        }
    }

}
