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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this program ?",
                 "Closing Warning", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
            
        }

        private void mnuOperators_Click(object sender, EventArgs e)
        {
            //create a new object from the class frmoperator
            frmOperators frmOp = new frmOperators();
            
            //lets show the frmOp
            frmOp.Show();
            frmOp.MdiParent = this;
        }

        private void mnuConditions_Click(object sender, EventArgs e)
        {
            frmCondition frmCo = new frmCondition();

            //lets show the frmCo
            frmCo.Show();
            frmCo.MdiParent = this;
        }

        private void mnuConditionalStructures_Click(object sender, EventArgs e)
        {
            frmConditionalStructures frmCoSt = new frmConditionalStructures();

            //lets show the frmCoSt
            frmCoSt.Show();
            frmCoSt.MdiParent = this;
        }

        private void mnuVideo_Click(object sender, EventArgs e)
        {
            frmVideo frmVd = new frmVideo();

            frmVd.Show();
            frmVd.MdiParent = this;
            //to center the formChild inside the MDI
            frmVd.Left = (this.Width - frmVd.Width)/2;
            frmVd.Top = (this.Height-frmVd.Height)/2;

           
        }

        private void mnuBook_Click(object sender, EventArgs e)
        {
            frmAddressBook fa= new frmAddressBook();

            fa.Show();
            fa.MdiParent = this;
            //to center the formChild inside the MDI
            fa.Left = (this.Width - fa.Width) / 2;
            fa.Top = (this.Height - fa.Height) / 2;

        }

        private void mnuTimeSheet_Click(object sender, EventArgs e)
        {
            frmTimeSheet frmTimeSheet = new frmTimeSheet();

            //lets show the frmtimesheet
            frmTimeSheet.Show();
            frmTimeSheet.MdiParent = this;
        }
    }
}
