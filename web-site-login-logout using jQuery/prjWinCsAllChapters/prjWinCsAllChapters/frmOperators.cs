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
    public partial class frmOperators : Form
    {
        public frmOperators()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            //once you click the button then we reccuperate value 1 and value 2
            // and store them in text valuemof lblResult
            Single val1, val2, result;
            val1 = Convert.ToSingle(txtValue1.Text);
            val2 = Convert.ToSingle(txtValue2.Text);
            result = val1 + val2;
            lblResult.Text = "Addition of " + val1 + " and " + val2 +
                " equal " + result;
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            Single val1, val2, result;
            val1 = Convert.ToSingle(txtValue1.Text);
            val2 = Convert.ToSingle(txtValue2.Text);
            result = val1 - val2;
            lblResult.Text = "Substraction of " + val1 + " and " + val2 +
                " equal " + result;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Single val1, val2, result;
            val1 = Convert.ToSingle(txtValue1.Text);
            val2 = Convert.ToSingle(txtValue2.Text);
            result = val1 * val2;
            lblResult.Text = "Multiplication of " + val1 + " and " + val2 +
                " equal " + result;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Single val1, val2, result;
            val1 = Convert.ToSingle(txtValue1.Text);
            val2 = Convert.ToSingle(txtValue2.Text);
            result = val1 / val2;
            lblResult.Text = "Division of " + val1 + " and " + val2 +
                " equal " + result;
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            Single val1, val2, result;
            val1 = Convert.ToSingle(txtValue1.Text);
            val2 = Convert.ToSingle(txtValue2.Text);
            result = val1 % val2;
            lblResult.Text = "Modulo of " + val1 + " and " + val2 +
                " equal " + result;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Single  val1, val2;
            bool result;
            val1 = Convert.ToSingle(txtValue1.Text);
            val2 = Convert.ToSingle(txtValue2.Text);
            result = val1 == val2;
            lblResult.Text = val1 + " is equal to " + val2 + " is " + result;
        }

        private void btnGreater_Click(object sender, EventArgs e)
        {
            Single val1, val2;
            bool result;
            val1 = Convert.ToSingle(txtValue1.Text);
            val2 = Convert.ToSingle(txtValue2.Text);
            result = val1 > val2;
            lblResult.Text = val1 + " is greater than " + val2 + " is " + result;
        }

        private void btnSmaller_Click(object sender, EventArgs e)
        {
            Single val1, val2;
            bool result;
            val1 = Convert.ToSingle(txtValue1.Text);
            val2 = Convert.ToSingle(txtValue2.Text);
            result = val1 < val2;
            lblResult.Text = val1 + " is smaller than  " + val2 + " is " + result;
        }

        private void btnDifferent_Click(object sender, EventArgs e)
        {
            Single val1, val2;
            bool result;
            val1 = Convert.ToSingle(txtValue1.Text);
            val2 = Convert.ToSingle(txtValue2.Text);
            result = val1 != val2;
            lblResult.Text = val1 + " is not equal to " + val2 + " is " + result;
        }

        private void frmOperators_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //txtValue1.Text = "";
            //txtValue2.Text = "";
            lblResult.Text = "";
            txtValue1.Clear();
            txtValue2.Clear();
       
          

        }
    }
}
