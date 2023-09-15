using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsAllChapters
{
    public partial class frmExamReview : Form
    {
        public frmExamReview()
        {
            InitializeComponent();
        }
        //structure declarartion
        struct Question
        {
            public string TheQuestion;
            public string Answer1;
            public string Answer2;
            public string Answer3;
            public string AnswerR;

        }
        //array declaration
        static Question[] tabQuestions = new Question[25];
        static Int16 nbQuest;//to know the number of question 
        static string rightAnswer;
        private void ReadFileToArray()
        {
            StreamReader myfile = new StreamReader("Questions.txt");
            Int16 i = 0;
            while (myfile.EndOfStream == false)
            {
                tabQuestions[i].TheQuestion = myfile.ReadLine();
                tabQuestions[i].Answer1 = myfile.ReadLine();
                tabQuestions[i].Answer2 = myfile.ReadLine();
                tabQuestions[i].Answer3 = myfile.ReadLine();
                tabQuestions[i].AnswerR = myfile.ReadLine();
                
                //at the same rime, fill the cboQuestions with the questions
                cboQuestions.Items.Add(tabQuestions[i].TheQuestion);
                i++;
            }
            nbQuest = i;

        }


        private void frmExamReview_Load(object sender, EventArgs e)
        {
            this.Height = 170;
            ReadFileToArray();

        }

        private void radAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 448;
            if (radAnswer1.Text == rightAnswer)
            {
                lblResult.Text = "Bravo, you got the right answer";

            }
            else
            {
                lblResult.Text = "Tabarnouche, you got the wrong answer";

            }
        }

        private void radAnswer2_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 448;
            if (radAnswer2.Text == rightAnswer)
            {
                lblResult.Text = "Bravo, you got the right answer";

            }
            else
            {
                lblResult.Text = "Tabarnouche, you got the wrong answer";

            }
        }

        private void radAnswer3_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 448;
            if (radAnswer3.Text == rightAnswer)
            {
                lblResult.Text = "Bravo, you got the right answer";

            }
            else
            {
                lblResult.Text = "Tabarnouche, you got the wrong answer";

            }
        }

        private void cboQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Height = 335;

            //loop version to find the question selected in the array
            string quest = cboQuestions.SelectedIndex.ToString();
            //for(Int16 i = 0; i < nbQuest; i++)
            //{
                //if(quest == tabQuestions[i].TheQuestion)
                //{
                   // radAnswer1.Text = tabQuestions[i].Answer1;
                    //radAnswer2.Text = tabQuestions[i].Answer2;
                    //radAnswer3.Text = tabQuestions[i].Answer3;

                //}
            //}
            Int32 indx = cboQuestions.SelectedIndex;
            radAnswer1.Text = tabQuestions[indx].Answer1;
            radAnswer2.Text = tabQuestions[indx].Answer2;
            radAnswer3.Text = tabQuestions[indx].Answer3;
            rightAnswer = tabQuestions[indx].AnswerR;



        }
    }
}
