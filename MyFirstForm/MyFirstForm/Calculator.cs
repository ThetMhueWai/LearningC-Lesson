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
    public partial class Calculator : Form
    {
        public int firstnum=0, secondnum=0, total = 0;
        
        public Calculator()
        {
            InitializeComponent();

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            
        }
       
        private void btnplus_Click(object sender, EventArgs e)
        {
            if (txtFirstNum.Text != "")
            {
                firstnum = Int32.Parse(txtFirstNum.Text);
                secondnum = Int32.Parse(txtSecondNum.Text);
                int result = firstnum + secondnum;
                MessageBox.Show("Result = " + result, "Show Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstNum.Text = "";
                txtSecondNum.Text = "";
            }
            else
            {
                MessageBox.Show("Please write first num and second num","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstNum.Focus();
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToInt32(txtFirstNum.Text);
            secondnum = Convert.ToInt32(txtSecondNum.Text);
            int result = firstnum - secondnum;
            MessageBox.Show("Result = " + result, "Show Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFirstNum.Text = "";
            txtSecondNum.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToInt32(txtFirstNum.Text);
            secondnum = Convert.ToInt32(txtSecondNum.Text);
            int result = firstnum / secondnum;
            MessageBox.Show("Result = " + result, "Show Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFirstNum.Text = "";
            txtSecondNum.Text = "";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToInt32(txtFirstNum.Text);
            secondnum = Convert.ToInt32(txtSecondNum.Text);
            int result = firstnum * secondnum;
            MessageBox.Show("Result = " + result, "Show Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFirstNum.Text = "";
            txtSecondNum.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNum.Text = "";
            txtSecondNum.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
