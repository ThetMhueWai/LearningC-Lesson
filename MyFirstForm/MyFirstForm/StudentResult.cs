using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
    public partial class StudentResult : Form
    {
        public StudentResult()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string stName;
            int mark;
            stName = txtstName.Text;
            mark = Convert.ToInt32(txtMark.Text);
            if (mark >= 40 && mark < 60)
            {
                lblresult.Text = "Congratulation " + stName + "! You have got a Pass";
            }
            else if(mark >= 60 && mark < 70)
            {
                lblresult.Text = "Congratulation " + stName + "! You have got a Merit";
            }
            else if (mark >= 70 && mark < 100)
            {
                lblresult.Text = "Congratulation " + stName + "! You have got a Destinction";
            }
            else if (mark < 40)
            {
                lblresult.Text = "Sorry " + stName + "! You have got a Fail";
            }
            else
            {
                lblresult.Text = stName + " mark is wrong because it is greater than 100";
            }
            txtstName.Text = "";
            txtMark.Text = "";
            txtstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
