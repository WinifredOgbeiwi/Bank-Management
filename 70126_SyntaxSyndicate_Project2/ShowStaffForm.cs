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
using static _70126_SyntaxSyndicate_Project2.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _70126_SyntaxSyndicate_Project2
{
    public partial class ShowStaffForm : Form
    {
        public ShowStaffForm()
        {
            InitializeComponent();
        }

   
        private List<Staff> staffs = new List<Staff>();
        private int displayStaffIndex = 0;
        private void StaffDetails(Staff staff)
        {
            staffName.Text = staff.Name;
            staffLastName.Text = staff.LastName;
            staffEmail.Text = staff.Email;
            staffContact.Text = staff.PhoneNumber;
            staffAddress.Text = staff.Address;
            staffBalance.Text = staff.Balance.ToString();
            staffRole.Text = staff.Role.ToString();
            staffExtraHours.Text = staff.ExtraHours.ToString();
     staffHours.Text = staff.Hours.ToString();
            staffSalary.Text = staff.SalaryPh.ToString();

            staffID.Text = staff.ID;
            pictureBox1.ImageLocation = staff.Photo;
        }
        private void ShowStaffForm_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fileStream = new FileStream("StaffFile.txt", FileMode.Open, FileAccess.Read);
                StreamReader fileReader = new StreamReader(fileStream);
                while (!fileReader.EndOfStream)
                {
                    string staffDetails = fileReader.ReadLine();
                    string[] section = staffDetails.Split('^');

                    //if (section.Length == 12)
                    //{
                        staffs.Add(new Staff
                        {
                            Name = section[0].Trim(),
                            LastName = section[1].Trim(),
                            Email = section[2].Trim(),
                            PhoneNumber = section[3].Trim(),
                            Address = section[4].Trim(),
                            ID = section[5].Trim(),
                            Role = (Role)Enum.Parse(typeof(Role), section[6].Trim()),
                    Hours = Convert.ToInt16(section[7].Trim()),
                            ExtraHours = Convert.ToInt16(section[8].Trim()), 
                            
                            Balance = Convert.ToDecimal(section[10].Trim()),
                            Photo = section[11].Trim()
                        });
                    //}


                    //else
                    //{
                        //MessageBox.Show("Customer data format is incorrect, skipping this entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                labelPagination.Text = $" {displayStaffIndex + 1} from {staffs.Count}";
                fileReader.Close();
                fileStream.Close();


                if (staffs.Count > 0)
                {
                    StaffDetails(staffs[displayStaffIndex]);
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

        public void RefreshStaffData()
        {

            staffs.Clear();

            try
            {
                FileStream fileStream = new FileStream("StaffFile.txt", FileMode.Open, FileAccess.Read);
                StreamReader fileReader = new StreamReader(fileStream);
                while (!fileReader.EndOfStream)
                {
                    string customerDetails = fileReader.ReadLine();
                    string[] section = customerDetails.Split('^');


                    staffs.Add(new Staff
                    {
                        Name = section[0].Trim(),
                        LastName = section[1].Trim(),
                        Email = section[2].Trim(),
                        PhoneNumber = section[3].Trim(),
                        Address = section[4].Trim(),
                        ID = section[5].Trim(),
                        Role = (Role)Enum.Parse(typeof(Role), section[6].Trim()),
                    Hours = Convert.ToInt16(section[7].Trim()),
                        ExtraHours = Convert.ToInt16(section[8].Trim()),
                        //SalaryPh = Convert.ToDecimal(section[9].Trim()),
                        Balance = Convert.ToDecimal(section[10].Trim()),
                        Photo = section[11].Trim()
                    });
                }


                fileReader.Close();
                fileStream.Close();

                if (staffs.Count > 0)
                {
                    StaffDetails(staffs[displayStaffIndex]);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxShowCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void customerSavings_Click(object sender, EventArgs e)
        {

        }

        private void labelHours_Click(object sender, EventArgs e)
        {

        }

        private void staffBalance_Click(object sender, EventArgs e)
        {

        }

        private void labelExtraHours_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (staffs.Count > 0 && displayStaffIndex < staffs.Count - 1)
            {
                displayStaffIndex++;
                StaffDetails(staffs[displayStaffIndex]);
                labelPagination.Text = $" {displayStaffIndex + 1} from {staffs.Count}";
            }
            else
            {
                MessageBox.Show("This is the last staff.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (staffs.Count > 0 && displayStaffIndex > 0)
            {
                displayStaffIndex--;
                StaffDetails(staffs[displayStaffIndex]);
                labelPagination.Text = $" {displayStaffIndex + 1} from {staffs.Count}";
            }
            else
            {
                MessageBox.Show("This is the first staff.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonstaffManaging_Click(object sender, EventArgs e)
        {
            Staff selectedStaff = staffs[displayStaffIndex];
            
            ManageStaffs manageStaffs = new ManageStaffs(selectedStaff.ID, selectedStaff.SalaryPh, selectedStaff.ExtraSalaryPh, selectedStaff.Hours,selectedStaff.ExtraHours,selectedStaff.Balance);
            manageStaffs.ShowDialog();

  
            RefreshStaffData();
        }
    }
}
