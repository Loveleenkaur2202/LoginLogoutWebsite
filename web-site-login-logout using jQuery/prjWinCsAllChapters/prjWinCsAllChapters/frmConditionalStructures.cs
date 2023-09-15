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
    public partial class frmConditionalStructures : Form
    {
        public frmConditionalStructures()
        {
            InitializeComponent();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsLetter(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtGradeNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtGradeAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 'A' && e.KeyChar <= 'E' || e.KeyChar >= 'a' && e.KeyChar <= 'e' || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void btnClearNumeric_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtGradeNumeric.Text = "";
            lblResult.Text = "";
            radMale.Checked = true;
            radFemale.Checked = false;
        }

        private void btnClearAlpha_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtGradeAlpha.Text = "";
            lblResult.Text = "";
            radMale.Checked = true;
            radFemale.Checked = false;
        }

        private void btnEvaluateNumeric_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Please enter your name";
                txtName.Focus();
            }
            else if (txtGradeNumeric.Text == "")
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Please provide your grade(0-100)";
                txtGradeNumeric.Focus();
            }

            else
            {
                Single grade_num = Convert.ToSingle(txtGradeNumeric.Text);
                string result_grade;
                if (grade_num <= 100 && grade_num >= 90)
                {
                    result_grade = "A";
                }
                else if (grade_num < 90 && grade_num >= 80)
                {
                    result_grade = "B";
                }
                else if (grade_num < 80 && grade_num >= 70)
                {
                    result_grade = "C";
                }
                else if (grade_num < 70 && grade_num >= 60)
                {
                    result_grade = "D";
                }
                else if (grade_num < 60 && grade_num >= 0)
                {
                    result_grade = "E";
                }
                else
                {
                    result_grade = "INVALID GRADE";
                }

                lblResult.ForeColor = Color.Blue;
                if (radMale.Checked == true)
                {
                    lblResult.Text = "Sir " + txtName.Text + ", with " + txtGradeNumeric.Text + ", you have " + result_grade;
                }
                else
                {
                    lblResult.Text = "Miss " + txtName.Text + ", with " + txtGradeNumeric.Text + ", you have " + result_grade;
                }
            }

        }

        private void btnEvaluateAlpha_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Please enter your name";
                txtName.Focus();
            }

            else if (txtGradeAlpha.Text == "")
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Please provide your grade(A to E)";
                txtGradeAlpha.Focus();
            }
            else
            {
                string result_grade;
                string grade_alpha = txtGradeAlpha.Text;
                if (grade_alpha.Equals("a") || grade_alpha.Equals("A"))
                {
                    result_grade = "90 to 100";
                }
                else if (grade_alpha.Equals("b") || grade_alpha.Equals("B"))
                {
                    result_grade = "80 to 89";
                }
                else if (grade_alpha.Equals("c") || grade_alpha.Equals("C"))
                {
                    result_grade = "70 to 79";
                }
                else if (grade_alpha.Equals("d") || grade_alpha.Equals("D"))
                {
                    result_grade = "60 to 69";
                }
                else if (grade_alpha.Equals("e") || grade_alpha.Equals("E"))
                {
                    result_grade = "0 to 59";
                }
                else
                {
                    result_grade = "Invalid";
                }
                lblResult.ForeColor = Color.Blue;
                if (radMale.Checked == true)
                {
                    lblResult.Text = "Sir " + txtName.Text + ", with " + txtGradeNumeric.Text + ", you have " + result_grade;
                }
                else
                {
                    lblResult.Text = "Miss " + txtName.Text + ", with " + txtGradeNumeric.Text + ", you have " + result_grade;
                }
            }
        }

       
    }
}

       
    

    

