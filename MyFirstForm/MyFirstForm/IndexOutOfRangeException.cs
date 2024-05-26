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
    public partial class IndexOutOfRangeException : Form
    {
        public IndexOutOfRangeException()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int[] arrnum = {1,2,3,4,5};
            for (int i = 0; i <= 5; i++ )
            {
                lblDisplay.Text += arrnum[i] + "|";
            }
        }

        
    }
}
