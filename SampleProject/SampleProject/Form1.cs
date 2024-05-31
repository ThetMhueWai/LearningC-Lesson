using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleProject
{
    public partial class Form1 : Form
    {
        LibraryDatasetTableAdapters.stafftbTableAdapter staff= new LibraryDatasetTableAdapters.stafftbTableAdapter();
        DataTable staffdta = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Clearall() 
        {
            txtaName.Text = "";
            txtaAddress.Text = "";
            txtaEmail.Text = "";
            txtaPassword.Text = "";
            txtaPhone.Text = "";
        }
        public void staffAutoID()
        {
            staffdta = staff.GetData();

            if (staffdta.Rows.Count == 0)
            {
                txtAID.Text = "S001";
            }
            else
            {
                int size = staffdta.Rows.Count - 1;
                string oldid = staffdta.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(1, 3));

                if(newid>=1 && newid<9)
                {
                    txtAID.Text = "S00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtAID.Text = "S0" + (newid + 1);
                }
                else if(newid >= 99 && newid < 999)
                {
                    txtAID.Text = "S" + (newid + 1);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            staffAutoID();
        }

        private void bthClear_Click(object sender, EventArgs e)
        {
            Clearall();
        }

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            String password = txtaPassword.Text;
            if (txtaName.Text == "")
            {
                MessageBox.Show("Fill Admin Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaName.Focus();
            }
            else if (txtaAddress.Text == "")
            {
                MessageBox.Show("Fill Admin Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtaEmail.Text == "")
            {
                MessageBox.Show("Fill Admin Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaEmail.Focus();
            }
            else if (txtaPassword.Text == "")
            {
                MessageBox.Show("Fill Admin Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaPassword.Focus();
            }
            else if (txtaPhone.Text == "")
            {
                MessageBox.Show("Fill Admin Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaPhone.Focus();
            }
            else if(txtaPassword.Text.Length >= 8 || txtaPassword.Text.Length < 16)
            {
                MessageBox.Show("Please Vaild Password Length, Should enter between 8 and 16", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaPassword.Focus();
            }
            else if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Please should include Upper Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaPassword.Focus();
            }
            else if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Please should include lower Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaPassword.Focus();
            }
            else if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Please should include digit Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaPassword.Focus();
            }
            else
            { 
                
            }
        }
    }
}
