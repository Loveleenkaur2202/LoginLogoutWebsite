using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace prjWinCsAllChapters
{
    public partial class frmStructures : Form
    {
        public frmStructures()
        {
            InitializeComponent();
        }
        struct country{
            public string Name;
            public string Langauage;
       }

        country[] tabCounts = new country[50];
        Int16 nbCount;
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter myfile = new StreamWriter("products.txt",true);
            myfile.Write("\norange\n");
            myfile.Write("mango\n");
            myfile.WriteLine("pamplemousse");
            myfile.Write("banana");

            //myfile.Write("sardine\n");
            //myfile.Write("chocolate\n");
            //myfile.WriteLine("apple");
            //myfile.Write("ananas");


            myfile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(Int16 i = 0; i<nbCount; i++)
            {
                if (tabCounts[i].Name == cboCountry.SelectedItem.ToString())
                {
                    string tmp = "In " + tabCounts[i].Name + "we speak " 
                        + tabCounts[i].Langauage;
                    MessageBox.Show(tmp);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           country newC;
            newC.Name = "Quebec";
            newC.Langauage = "Francais";
            //add the newcountry at the end of the array
            tabCounts[nbCount] = newC;
            // or version without newC 
            //tabCounts[nbCount].Name = "Quebec";
            //tabCounts[nbCount].Langauage = "Francais";
            nbCount++;

            //write the array back to the text file 
           StreamWriter myfile = new StreamWriter("countries.txt");
            for(Int16 i = 0; i < nbCount; i++)
            {
                myfile.WriteLine(tabCounts[i].Name);
                myfile.WriteLine(tabCounts[i].Langauage);
            }
            myfile.Close();
        }

        private void frmStructures_Load(object sender, EventArgs e)
        {
            //open the file for reading
            StreamReader myfile = new StreamReader("Countries.txt");
            Int16 i =0;
            while (myfile.EndOfStream == false)
            {
                //fill the array with the text file contents
                tabCounts[i].Name = myfile.ReadLine();
                tabCounts[i].Langauage = myfile.ReadLine();
                i++;
                //fill the combobox
                // cboCountry.Items.Add(tabCounts[i].Name);
                
                //cboCountry.Items.Add(tabCounts[i].Name);
                //i++;
            }
            nbCount = i;
            //string tmp="";
            //tmp = myfile.ReadLine();
            //tmp = myfile.ReadLine();
            //tmp = myfile.ReadLine();
            //tmp += myfile.ReadLine();
            //tmp += myfile.ReadLine();
            //string tmp = myfile.ReadToEnd();
            //while(myfile.EndOfStream == false)
            //{
            //  cboCountry.Items.Add( myfile.ReadLine());
            //tmp = myfile.ReadLine();
            //}

            myfile.Close();

            //MessageBox.Show(tmp);
        }
    }
}
