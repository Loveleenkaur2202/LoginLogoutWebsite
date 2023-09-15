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
    public partial class frmCondition : Form
    {
        public frmCondition()
        {
            InitializeComponent();
        }

        private void txtValue1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radAddition_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Single val1, val2;

            //verification of empty textboxes
            if (txtValue1.Text == "")
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Please provide Value 1";
                txtValue1.Focus();
            }
            else if (txtValue2.Text == "")
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Please provide Value 2";
                txtValue2.Focus();
            }
            else
            {
                lblResult.ForeColor = Color.Blue;
                val1 = Convert.ToSingle(txtValue1.Text);
                val2 = Convert.ToSingle(txtValue2.Text);

                // Arihematic operators
                if (radAddition.Checked)
                {
                    Single result = val1 + val2;
                    lblResult.Text = "Addition of " + val1 + " and " + val2 + " equal " + result;
                }
                else if (radSubstraction.Checked)
                {
                    Single result = val1 - val2;
                    lblResult.Text = "Subtraction of " + val1 + " and " + val2 + " equal " + result;
                }
                else if (radMultiplication.Checked)
                {
                    Single result = val1 * val2;
                    lblResult.Text = "Multiplication of " + val1 + " and " + val2 + " equal " + result;
                }
                else if (radDivision.Checked)
                {
                    Single result = val1 / val2;
                    lblResult.Text = "Division of " + val1 + " and " + val2 + " equal " + result;
                }
                else if (radModulo.Checked)
                {
                    Single result = val1 % val2;
                    lblResult.Text = "Modulo of " + val1 + " and " + val2 + " equal " + result;
                }

                // Comparison Operators
                else if (radEqual.Checked)
                {
                    bool result = val1 == val2;
                    lblResult.Text = val1 + " is equal to " + val2 + " is " + result;
                }
                else if (radGreater.Checked)
                {
                    bool result = val1 > val2;
                    lblResult.Text = val1 + " is greater than " + val2 + " is " + result;
                }
                else if (radSmaller.Checked)
                {
                    bool result = val1 < val2;
                    lblResult.Text = val1 + " is smaller than " + val2 + " is " + result;
                }
                else if (radNotEqual.Checked)
                {
                    bool result = val1 < val2;
                    lblResult.Text = val1 + " not equal to " + val2 + " is " + result;
                }
                else if (radGreaterEqual.Checked)
                {
                    bool result = val1 >= val2;
                    lblResult.Text = val1 + " is greater than or equal to  " + val2 + " is " + result;
                }
                else if (radSmallerEqual.Checked)
                {
                    bool result = val1 <= val2;
                    lblResult.Text = val1 + " is smaller than or equal to " + val2 + " is " + result;
                }

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtValue1.Text = "";
            txtValue2.Text = "";
            lblResult.Text = "";
            radAddition.Checked = false;
            radSubstraction.Checked = false;
            radMultiplication.Checked = false;
            radDivision.Checked = false;
            radModulo.Checked = false;
            radEqual.Checked = false;
            radGreater.Checked = false;
            radSmaller.Checked = false;
            radNotEqual.Checked = false;
            radGreaterEqual.Checked = false;
            radSmallerEqual.Checked = false;

        }

        private void radGreaterEqual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtValue1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtValue2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false)
                e.Handled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
    

