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
    public partial class formatException : Form
    {
        public formatException()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                num = Convert.ToInt32(txtMark.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
