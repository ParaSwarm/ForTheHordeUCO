using KWIC_Shared.SharedData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KWIC_Shared
{
    public partial class Form1 : Form
    {
        private Controller mainControl;


        public Form1()
        {
            InitializeComponent();
            mainControl = new Controller();
            chkNoise.Checked = true;
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        public void btnRun_Click(object sender, EventArgs e)
        {
            string temp = txtInput.Text.Trim().ToString();

            if (temp != "")
            {
                if (chkNoise.Checked)
                    mainControl.enableFilter(true, "noise2.txt");
                else
                    mainControl.clearNoise();
                
                mainControl.initStorage(temp);
            }
            else
            {
                MessageBox.Show("Please enter at least one word", "Empty Input Line", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            txtOutput.Text = mainControl.AlphaOutput;

            

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
