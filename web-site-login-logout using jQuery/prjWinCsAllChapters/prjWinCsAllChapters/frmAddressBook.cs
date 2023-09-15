using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsAllChapters
{
    public partial class frmAddressBook : Form
    {
        public frmAddressBook()
        {
            InitializeComponent();
        }

        private void frmAddressBook_Load(object sender, EventArgs e)
        {
            //string aString = "Loveleen";
            //lblResult.Text = aString.Length.ToString();
            //lblResult.Text = aString.ToUpper();
           // lblResult.Text = aString.Contains("as").ToString(); 
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullname, lname, fname, address, city, province, PC, CPPC;
            Int16 posC1,posC2;
            fullname = txtFullname.Text;
            fullname = fullname.Trim();
            if(fullname.Length == 0)
            {
                MessageBox.Show("Please enter Lastname, Firstname");
                txtFullname.Focus();
                return;
            }

            //recuprate the position of comma1
            posC1 = Convert.ToInt16(fullname.IndexOf(","));
            if(posC1 == -1)
            {
                MessageBox.Show("Please enter comma between Lastname and Firstname");
                txtFullname.Focus();
                return;
            }
            //recuprate the lastname
            lname = fullname.Substring(0, posC1);
            lname = lname.Trim();
            if (lname.Length == 0)
            {
                MessageBox.Show("Please enter a Lastname");
                txtFullname.Focus();
                return;
            }
            //find the firstname
            fname = fullname.Substring(posC1 + 1);
            fname = fname.Trim();
            if (fname.Length == 0)
            {
                MessageBox.Show("Please enter a Firstname");
                txtFullname.Focus();
                return;
            }
            
            //recuprat the value of address
            address = txtAddress.Text.Trim();
           
            
            if (address.Length == 0)
            {
                MessageBox.Show("Please enter address");
                txtAddress.Focus();
                return;
            }
            
            CPPC = txtCPPC.Text;
            CPPC = CPPC.Trim();
            if (CPPC.Length == 0)
            {
                MessageBox.Show("Please enter city, province, postal code");
                txtCPPC.Focus();
                return;
            }

            //recuprate the position of comma2

            posC1 = Convert.ToInt16(CPPC.IndexOf(","));
            posC2 = Convert.ToInt16(CPPC.IndexOf(",", posC1 + 2));
       
            
            if (posC1 == -1)
            {
                MessageBox.Show("Please enter comma between city and province ");
                txtCPPC.Focus();
                return;
            }
            if (posC2 == -1)
            {
                MessageBox.Show("Please enter comma between province and postal code ");
                txtCPPC.Focus();
                return;
            }

            //find the city
            city = CPPC.Substring(0, posC1);
            city = city.Trim();
            if (city.Length == 0)
            {
                MessageBox.Show("Please enter your city");
                txtCPPC.Focus();
                return;
            }
            //finding province
            province = CPPC.Substring(posC1+1, posC2 -posC1-1);
            province = province.Trim();
            if (province.Length == 0)
            {
                MessageBox.Show("Please enter your province");
                txtCPPC.Focus();
                return;
            }
            //find the postal code
            PC = CPPC.Substring(posC2+1);
            PC = PC.Trim();
            if (PC.Length == 0)
            {
                MessageBox.Show("Please enter your Postal Code");
                txtCPPC.Focus();
                return;
            }

            //putting the first letter in upper and the rest in lowet case
            lname = lname.Substring(0, 1).ToUpper() + lname.Substring(1).ToLower();
            fname = fname.Substring(0, 1).ToUpper() + fname.Substring(1).ToLower();
            city = city.Substring(0, 1).ToUpper() + city.Substring(1).ToLower();
            province = province.Substring(0, 1).ToUpper() + province.Substring(1).ToLower();
            PC = PC.ToUpper();

            //display info in the labels
            lblLastname.Text = lname;
            lblFirstname.Text = fname;
            lblAddress.Text = address;
            lblCity.Text = city;
            lblProvince.Text = province;
            lblPC.Text = PC;
        }

    }
}
