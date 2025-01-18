using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _70126_SyntaxSyndicate_Project2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
 
        private void addCustomerbutton_Click_1(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void showCustomerbutton_Click_1(object sender, EventArgs e)
        {
            ShowCustomerForm showCustomerForm = new ShowCustomerForm();
            showCustomerForm.ShowDialog();
        }

        private void addStaffbutton_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffForm = new AddStaffForm();
            addStaffForm.ShowDialog();
        }

        private void showStaffbutton_Click(object sender, EventArgs e)
        {
            ShowStaffForm showStaffForm = new ShowStaffForm();
            showStaffForm.ShowDialog();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}