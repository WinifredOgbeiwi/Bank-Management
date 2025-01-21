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
    public partial class ShowStafff : Form
    {
        public ShowStafff()
        {
            InitializeComponent();
        }
        private List<Staff> staffs = new List<Staff>();
        private int displayStaffIndex = 0;
 
        
        private void ShowStafff_Load(object sender, EventArgs e)
        {
      
        }

    
       
        private void button1_Click(object sender, EventArgs e)
        {
            ShowStaffForm frm = new ShowStaffForm();
            frm.ShowDialog();
        }
    }
}
