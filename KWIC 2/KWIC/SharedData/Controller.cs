using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Forms;

namespace KWIC_Shared.SharedData
{
    class Controller
    {
        private LineStorage storage;
        private CircularShift cycle;

        public string CycleOutput
        {
            get { return cycle.CycledSentence; }
        }

        private List<string> noiseWords;
        public List<string> NoiseWords
        {
            get { return noiseWords; }
            set{noiseWords = value;}
        }

        public Controller()
        {
           NoiseWords = new List<string>();
           cycle = new CircularShift();
           initNoiseWords("noise.txt");
        }

   
        public void initStorage(string value)
        {
            storage = new LineStorage(value);
            cycle.Setup(storage, NoiseWords);
        }


        public void initNoiseWords(string fname)
        {
            StreamReader stream = new StreamReader(fname);
            string word;

            try
            {
                while ((word = stream.ReadLine()) != null)
                {
                    NoiseWords.Add(word.TrimEnd('\r', '\n'));
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Error Loading noise list.", "Noise Word List Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

    }
}
