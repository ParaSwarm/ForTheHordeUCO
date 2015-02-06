using Homework_1.Filters;
using Homework_1.Pipes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Homework_1
{
    public partial class Form1 : Form
    {
        private TextParser data;
        private string input;

        private GenericPipe pipeA;
        private GenericPipe pipeB;

        private CycleFilter cycler;
        private AlphabetizeFilter alphabetize;

        private string Input
        {
            get { return input; }
            set { input = value; }
        }


        public Form1()
        {
            InitializeComponent();
            pipeA = new GenericPipe();
            pipeB = new GenericPipe();

            cycler = new CycleFilter();
            alphabetize = new AlphabetizeFilter();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        public void btnRun_Click(object sender, EventArgs e)
        {
            string temp = txtInput.Text.ToString();

            if (temp != "")
            {
                data = new TextParser(temp);

                pipeA.Data = data.SentenceList;


                pipeB.AttachFilter(cycler, alphabetize);

                cycler.Source = pipeA;
                cycler.Sink = pipeB;



                cycler.PullData();
                cycler.Action();

                pipeB.Data = cycler.TempStorage;

                alphabetize.Source = pipeB;
                alphabetize.PullData();
                alphabetize.Action();


                foreach (List<string> list in alphabetize.TempStorage)
                {
                    foreach (string test in list)
                    {
                        txtOutput.Text += test + " ";
                    }

                    txtOutput.Text += Environment.NewLine;
                }
            }
        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
