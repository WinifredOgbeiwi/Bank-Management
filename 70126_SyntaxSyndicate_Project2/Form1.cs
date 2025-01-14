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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addCustomerbutton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void showCustomerbutton_Click(object sender, EventArgs e)
        {
            ShowCustomerForm showCustomerForm = new ShowCustomerForm();
            showCustomerForm.ShowDialog();
        }

        private void addStaffbutton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void showStaffbutton_Click(object sender, EventArgs e)
        {
            ShowCustomerForm showCustomerForm= new ShowCustomerForm();
            showCustomerForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
