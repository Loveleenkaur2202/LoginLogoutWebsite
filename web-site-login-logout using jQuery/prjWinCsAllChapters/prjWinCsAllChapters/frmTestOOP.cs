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
    public partial class frmTestOOP : Form
    {
        public frmTestOOP()
        {
            InitializeComponent();
        }

        private void frmTestOOP_Load(object sender, EventArgs e)
        {
            //clsTime rv = new clsTime();
            //rv.SetTime(23,59,59);
            //rv.SetTime(11,200,40);

            //rv.Hour = 20;
            //rv.Minute = 200;
            //rv.Second = 50;

            //lblResult.Text = rv.toStringUniversal();
            //lblResult.Text = rv.toStringStandard();

            //DateTime.Today.Day = 55;
            clsDate bday = new clsDate();
            bday.SetDate(25, 11, 2022);
            lblResult.Text = bday.ToNumber() + "\n";
            lblResult.Text += bday.ToLetter();
        }
    }
}
