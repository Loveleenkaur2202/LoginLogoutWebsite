using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsAllChapters
{
    public partial class frmTimeSheet : Form
    {
        public frmTimeSheet()
        {
            InitializeComponent();
        }

        private void frmTimeSheet_Load(object sender, EventArgs e)
        {/*
            lblResult.Text = DateTime.Today.ToString()+"\n" ;
            lblResult.Text += DateTime.Today.Day.ToString() + "\n";
            lblResult.Text += DateTime.Now.ToString() + "\n";
            lblResult.Text += DateTime.Now.Day.ToString() + "\n";
            lblResult.Text += DateTime.Now.ToLongTimeString().ToString()+"\n";
            lblResult.Text += Convert.ToInt32(DateTime.Today.DayOfWeek).ToString()+"\n";
            
            DateTime myBday = new DateTime(2002, 5, 22);
            //lblResult.Text = myBday.DayOfWeek.ToString();
            lblResult.Text = myBday.ToLongTimeString();
          */
            lblToday.Text = "Today " + DateTime.Today.ToShortDateString() + "\n";
            lblToday.Text += "Time " + DateTime.Now.ToLongTimeString().ToString();
        }
        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            txtTimeIn.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            txtTimeOut.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            DateTime timeIn, timeOut;
            timeIn = Convert.ToDateTime(txtTimeIn.Text);
            timeOut = Convert.ToDateTime(txtTimeOut.Text);

            Int32 h, mn, s, hin, min, sin, hout, mout, sout;

            hin = timeIn.Hour;
            min = timeIn.Minute;
            sin = timeIn.Second;

            hout = timeOut.Hour;
            mout = timeOut.Minute;
            sout = timeOut.Second;
            
          

        }
    }
}
