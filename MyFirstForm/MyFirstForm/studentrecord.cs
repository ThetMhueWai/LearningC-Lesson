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
    public partial class studentrecord : Form
    {
        public studentrecord()
        {
            InitializeComponent();
        }

        private void btnrecord_Click(object sender, EventArgs e)
        {
            String name, dob, gender=null, coursename;
            name = txtName.Text;
            dob = txtdof.Text;

            if (rdomale.Checked == true)
            {
                gender = rdomale.Text;
            }
            else if (rdofemale.Checked == true)
            {
                gender = rdofemale.Text;
            }

            coursename = cbocourse.SelectedItem.ToString();
            String ln = Environment.NewLine;

            lblDisplay.Text += ln + name + " | " + dob + " | " + gender + " | " + coursename;

            txtName.Text = "";
            txtdof.Text = "";
            cbocourse.SelectedIndex = 0;
            rdomale.Checked = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
