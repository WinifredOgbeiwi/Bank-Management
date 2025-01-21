using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Drawing;
using System.IO;
using _70126_SyntaxSyndicate_Project2;
using System.Net;

namespace _70126_SyntaxSyndicate_Project2
{
    internal class Utils
    {
        //VALIDATION OF EMAIL
      

       // ERROR MESSAGESES


        //ID  - (1) random letters (2) random numbers
        private static Random random = new Random();
        public static string GenerateUniqueID()
        {
            return random.Next(1000, 9999).ToString();
        }
        public static string GenerateUniqueLetter(char[] letters)
        {
            int index = random.Next(letters.Length);
            return letters[index].ToString();
        }

        // converting negative numbers to positive
        public static int ValidateEdge(int value)
        {
            if (value < 0)
            {
                MessageBox.Show("Value cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return value;
        }

        // plan list 
        public static List<string> Plans()
        {
            List<string> plans = new List<string> { "Plan","Premium", "Basic", "Business", "Student" };
            return plans;
        }

        //placeholder
        public void SetPlaceholder(TextBox textBox, string placeholderText)
        {

            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        public void SetComboBoxPlaceholder(ComboBox comboBox)
        {
            comboBox.Items.Insert(0, "Select Plan");
            comboBox.SelectedIndex = 0;
            comboBox.ForeColor = Color.Gray;
            comboBox.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBox.SelectedIndex == 0)
                {
                    comboBox.ForeColor = Color.Gray;
                }
                else comboBox.ForeColor = Color.Black;

            };
        }

        //SAVING FILE
        public void SaveFile(string filename, string details, string message)
        {

            FileStream file = new FileStream(filename, FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(file);
            streamWriter.WriteLine(details);
            streamWriter.Close();
            file.Close();
            MessageBox.Show(message);
        }


        //Generated account number
        public static string GeneratedAccountNumber()
        {
            return $"5585 {Utils.GenerateUniqueID()} {Utils.GenerateUniqueID()} {Utils.GenerateUniqueID()}";
        }

        public static string GeneratedUserID(char[] userLetters)
        {
            return $"{Utils.GenerateUniqueLetter(userLetters)}-{Utils.GenerateUniqueID()}";
        }

        //
        public static void UpdateCustomerBalanceInFile(string customerId, decimal newBalance)
        {
            string filePath = "CustomerFile.txt";
            List<string> customerFile = new List<string>();

            try
            {
                customerFile = File.ReadAllLines(filePath).ToList();

                for (int i = 0; i < customerFile.Count; i++)
                {
                    string[] section = customerFile[i].Split('^');
                    if (section[8].Trim() == customerId)
                    {

                        section[6] = newBalance.ToString("F2");
                        customerFile[i] = string.Join("^", section);
                        break;
                    }
                }


                File.WriteAllLines(filePath, customerFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void UpdateCustomerBalanceAndSavingsInFile(string customerId, decimal newBalance, decimal newSavings)
        {
            string filePath = "CustomerFile.txt";
            List<string> customerFile = new List<string>();

            try
            {
                customerFile = File.ReadAllLines(filePath).ToList();

                for (int i = 0; i < customerFile.Count; i++)
                {
                    string[] section = customerFile[i].Split('^');
                    if (section[8].Trim() == customerId)
                    {
                        section[7] = newSavings.ToString("F2");

                        section[6] = newBalance.ToString("F2");
                        

                        customerFile[i] = string.Join("^", section);
                        break;
                    }
                }


                File.WriteAllLines(filePath, customerFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void UpdateCustomerInFile(string customerId, string name, string lastName, string email, string phoneNumber, string address, string plan, string photo, string accountNum, decimal balance, decimal savings)
            {
            string filePath = "CustomerFile.txt";
            List<string> customerFile = new List<string>();

            try
            {
                customerFile = File.ReadAllLines(filePath).ToList();

                for (int i = 0; i < customerFile.Count; i++)
                {
                    string[] section = customerFile[i].Split('^');
                    if (section[8].Trim() == customerId)
                    {
                        section[0] = name.Trim();
                        section[1] = lastName.Trim();
                        section[2] = phoneNumber.Trim();
                        section[3] = email.Trim();
                        section[4] = address.Trim();
                        section[5] = plan.Trim();
                        section[6] = balance.ToString();
                        section[7] = savings.ToString();
                        section[9] = accountNum.Trim();
                        if (!string.IsNullOrEmpty(photo))
                        {
                            section[10] = photo.Trim();
                        }
                        

                        customerFile[i] = string.Join("^", section);
                        break;
                    }
                }


                File.WriteAllLines(filePath, customerFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //capitalized text
        public static string capitalized(string text)
        {
            char text1 = text[0];
            string fullText = text1.ToString().ToUpper() + text.Substring(1).ToLower();
            return fullText;
        }

        //validation
        public static bool IsValidEmail(string email)
        {
            try
            {
                // Regular expression pattern for valid email
                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern);
            }
            catch
            {
                return false;
            }
        }
       
        public static string FieldsValidation(Person person)
        {
            string balance = person.Balance.ToString();
            if (person.Name == "Name")
            {
                return "Please enter a name";
            }

            else if ( person.LastName == "Last Name")
            {
                return "Please enter a last name";
            }

            else if (person.PhoneNumber == "123456789")
            {
                return "Please enter a phone number";
            }

            else if (person.PhoneNumber.Length != 9)
            {
                return "Phone Number must be 9 characters";
            }

            else if (!person.PhoneNumber.All(char.IsDigit))
            {
                return "Phone Number must contain only digits";
            }
            else if ( person.Email == "your@email.com")
            {
                return "Please enter an email";
            }
            else if (!IsValidEmail(person.Email))
            {
                return "Please enter a valid email";
            }
            else if ( person.Address == "ul.street 1/w2,01-234,city")
            {
                return "Please enter an address";
            }
            else if (person.Balance == 0)
            {
                MessageBox.Show("Please enter balance", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else if (!decimal.TryParse(balance, out _))
            {
                MessageBox.Show("Enter numeric number for balance", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }

            else if (person.Photo == "label3")
            {
                return "Please upload a photo";
            }
            return null;
        }

     


        public static void UpdateCustomerHours(string staffId, int newHours, int newExtraHours, decimal bal)
        {
            string filePath = "StaffFile.txt";
            List<string> staffFile = new List<string>();

            try
            {
                staffFile = File.ReadAllLines(filePath).ToList();

                for (int i = 0; i < staffFile.Count; i++)
                {
                    string[] section = staffFile[i].Split('^');
                    if (section[5].Trim() == staffId)
                    {

                        section[7] = newHours.ToString();
                        section[8] = newExtraHours.ToString();
                        section[10] = bal.ToString();

                        staffFile[i] = string.Join("^", section);
                        break;
                    }
                }


                File.WriteAllLines(filePath, staffFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}
