using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _70126_SyntaxSyndicate_Project2
{
    public partial class ManageStaffs : Form
    {
        public ManageStaffs(string staffID,decimal salaryPh, decimal extraSalaryPerHour, int hours, int extraHours, decimal balance )
        {
            InitializeComponent();
            staffID1.Text = staffID;
            sph.Text = salaryPh.ToString();
            esph.Text = extraSalaryPerHour.ToString();
            extra.Text = extraHours.ToString();
            hr.Text = hours.ToString();
            bal.Text = balance.ToString();


        }




        private void buttonAddHours_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxHours.Text) || (string.IsNullOrEmpty(textBoxExtraHours.Text)))
                {
                    MessageBox.Show("Please enter a number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    
                    int InputedHour = string.IsNullOrEmpty(textBoxHours.Text) ? 0 : Utils.ValidateEdge(Convert.ToInt16(textBoxHours.Text));
                    if (InputedHour == -1) return;
                    int InputedExtraHours = string.IsNullOrEmpty(textBoxExtraHours.Text) ? 0 :  Utils.ValidateEdge(Convert.ToInt16(textBoxExtraHours.Text));
                    if (InputedHour == -1) return;



                    MessageBox.Show("Hours Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    decimal staffHourCal = Convert.ToDecimal(sph.Text) * InputedHour;
                    decimal staffUnpaidHourCal = Convert.ToDecimal(esph.Text) * InputedExtraHours;
                    decimal staffUnpaidBal = staffHourCal + staffUnpaidHourCal;
                    unbal.Text = staffUnpaidBal.ToString();
                    staffHours.Text = staffHourCal.ToString("F2");
                    staffExtraHours.Text = staffUnpaidHourCal.ToString("F2");
                    staffUnpaidBalance.Text = staffUnpaidBal.ToString("F2");
                    toSavehr.Text = textBoxHours.Text;
                    toSaveextra.Text = textBoxExtraHours.Text;
                    textBoxExtraHours.Text = string.Empty;
                    textBoxHours.Text = string.Empty;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (staffExtraHours.Text == "0" || staffHours.Text == "0" || staffUnpaidBalance.Text == "0")
            {
                MessageBox.Show("Please enter hours or extra hours", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               



            }
            else
            {
                decimal newbal = Convert.ToDecimal(bal.Text) + Convert.ToDecimal(staffUnpaidBalance.Text);
                int newhr = Convert.ToInt16(hr.Text) + Convert.ToInt16(toSavehr.Text);
                int newextra =  Convert.ToInt16(extra.Text) + Convert.ToInt16(toSaveextra.Text);
                Utils.UpdateCustomerHours(staffID1.Text, newhr, newextra, newbal);
                MessageBox.Show("Payment made!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                staffHours.Text = "0";
                staffExtraHours.Text = "0";
                staffUnpaidBalance.Text = "0";
            }
        }




        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 private void unpaidHours_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxExtraHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBoxHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void staffExtraHours_Click(object sender, EventArgs e)
        {

        }

        private void labelExtraHours_Click(object sender, EventArgs e)
        {

        }

        private void labelBalance_Click(object sender, EventArgs e)
        {

        }

        private void staffID1_Click(object sender, EventArgs e)
        {

        }

        private void labelCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxWithdraw_Enter(object sender, EventArgs e)
        {

        }

        private void sph_Click(object sender, EventArgs e)
        {

        }

        private void staffUnpaidBalance_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void esph_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void hr_Click(object sender, EventArgs e)
        {

        }

        private void bal_Click(object sender, EventArgs e)
        {

        }

        private void extra_Click(object sender, EventArgs e)
        {

        }

        private void unbal_Click(object sender, EventArgs e)
        {

        }

        private void toSavehr_Click(object sender, EventArgs e)
        {

        }

        private void toSaveextra_Click(object sender, EventArgs e)
        {

        }
    }
}
