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
    public partial class UserWelcom : Form
    {
        public UserWelcom()
        {
            InitializeComponent();
        }

        private void btnPressMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + txtName.Text);
            txtName.Text = "";
            txtName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
