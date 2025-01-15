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

namespace _70126_SyntaxSyndicate_Project2
{
    internal class Utils
    {
        //VALIDATION OF EMAIL
        public bool IsValidEmail(string email)
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


        //ERROR MESSAGESES


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
            return value < 0 ? -value : value;
        }

        // plan list 
        public static List<string> Plans()
        {
            List<string> plans = new List<string> { "Plan","Basic", "Premium", "VIP" };
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
     public void SaveFile (string filename, string details, string message)
        {
           
            FileStream file = new FileStream(filename, FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(file);
            streamWriter.WriteLine(details);
            streamWriter.Close();
            file.Close();
          MessageBox.Show(message);
        }


      

        }


}
