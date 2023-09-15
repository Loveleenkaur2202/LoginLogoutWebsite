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
    public partial class frmVideo : Form
    {
        public frmVideo()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string info;
            Single amountDue = 0;
            string title = "Client Information Validation";
            info = "Client : " + txtName.Text + "\n";
            info += "Password : " + txtPassword.Text + "\n";
            info += "Address : " + txtAddress.Text + "\n";
            info += "Proof ID: ";
            /*
            if (chkId.Checked== true)
            {
                info += "Yes";
            }
            else
            {
                info += "No";
            }
            */
            //info += "Proof ID: " + (chkId.Checked == true ? "YES" : "No"+ "\n");
            info += chkId.Checked ? "YES" : "No";
            info += "\n";
            info += "Status : ";

            if (radSingle.Checked == true)
            {
                info += "Single";
            }
            else if (radMarried.Checked == true)
            {
                info += "Married";
            }
            else if (radSeparated.Checked == true)
            {
                info += "Separated";
            }
            else //if(radCommonLaw.Checked == true)
            {
                info += "Common Law";
            }

            info += "\n" + "Card: ";

            if (radVisa.Checked == true)
            {
                info += "Visa";
            }
            else if (radAmerican.Checked == true)
            {
                info += "American Xpress";
            }
            else //if (radMastercard.Checked == true)
            {
                info += "Mastercard";
            }
            txtCardNumber.Focus();

            info += "\n" + "N: " + txtCardNumber.Text + "\n";

            info += "Rented movies: \n";


            for (Int16 i = 0; i < lstMovies.Items.Count; i++)
            {
                info += "   -" + lstMovies.Items[i] + "\n";
            }

            info += "Special: " + cboSpecial.SelectedItem.ToString() + "\n";
            info += "Amount due: ";
            Int16 nbFilms = Convert.ToInt16(lstMovies.Items.Count);
            /*if (cboSpecial.SelectedIndex == 0 || cboSpecial.SelectedIndex == 1)

            {
                amountDue = nbFilms * 4;
            
    .              //amountDue = (nbFilm + 1)*2 .or 2*nbFilm + 2;
            }*/
              info += amountDue + "$";
            
           
            
            info += "\n"; 
            info = info + "Are all the infos correct ? ";


            MessageBox.Show(info, title, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void chkId_CheckedChanged(object sender, EventArgs e)
        {/*
            if(chkId.Checked == true)
            {
                btnRent.Enabled = true;
            }
            else
            {
                btnRent.Enabled = false;
            }*/
            //btnRent.Enabled = (chkId.Checked == true) ? true : false;
             btnRent.Enabled = chkId.Checked;
            //radSingle.Checked = true;
            //radVisa.Checked = true;



        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsLetter(e.KeyChar) == false)
                e.Handled = true;//Disable the digits

        }

        private void txtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false)
            {

                e.Handled = true; // disable the character
            }
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
           
            btnRent.Enabled = false;
            radSingle.Checked = true;
            radVisa.Checked = true;
            lblTitle.Visible = txtTitle.Visible = btnAdd.Visible = false;
            /*lstMovies.Items.Add("Sholay");
            lstMovies.Items.Add("Titanic");
            lstMovies.Items.Add("Disco Dancer");
            */
            btnReturn.Visible = false;

            cboSpecial.Items.Add("Regular");
            cboSpecial.Items.Add("Free PopCorn");
            cboSpecial.Items.Add("2 For 1");

            cboSpecial.SelectedIndex = 0;


        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            lblTitle.Visible = txtTitle.Visible = btnAdd.Visible = true;
        }

        private void lstRented_SelectedIndexChanged(object sender, EventArgs e)
        {   if(lstMovies.SelectedIndex != -1)
            {
                btnReturn.Visible = true;
            }
           
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            if (title != "")
            {
                if (lstMovies.Items.Contains(title) == false)
                {
                    lstMovies.Items.Add(title);
                }
            }


            txtTitle.Clear();
            lblTitle.Visible = txtTitle.Visible = btnAdd.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //lstMovies.Items.Remove(lstMovies.SelectedItem);
            lstMovies.Items.RemoveAt(lstMovies.SelectedIndex);
            btnReturn.Visible = false;
        }

       
    }
}
