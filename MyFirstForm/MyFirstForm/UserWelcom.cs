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
            MessageBox.Show("Hello Thet Mhue");
        }
    }
}
