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
    public partial class ShowCustomerForm : Form
    {
        public ShowCustomerForm()
        {
            InitializeComponent();
        }

        private List<string> imagePaths = new List<string>();
        private int currentImageIndex = 0;

        private void ShowCustomer_Load(object sender, EventArgs e)
        {


       
        FileStream fileStream = new FileStream("CustomerFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader fileReader = new StreamReader(fileStream);
            while (!fileReader.EndOfStream)
            {
                string customerDetails = fileReader.ReadLine();
                imagePaths.Add(customerDetails);
                
            }
            fileReader.Close();
            fileStream.Close();

            if (imagePaths.Count > 0 && currentImageIndex >= 0 && currentImageIndex < imagePaths.Count)
            {
                pictureBox1.ImageLocation = imagePaths[currentImageIndex];
            }
            else
            {
                MessageBox.Show("No images available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


















        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 }
}
