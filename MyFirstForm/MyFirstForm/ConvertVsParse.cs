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
    public partial class ConvertVsParse : Form
    {
        public ConvertVsParse()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int a;
            string b = null;
            if(b == null)
            {
                a = Convert.ToInt32(b);
                MessageBox.Show("Converting String is a numeric representation: " + a);
            }
            
            

        }
    }
}
