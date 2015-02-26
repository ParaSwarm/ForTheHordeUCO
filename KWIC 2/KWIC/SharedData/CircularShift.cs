using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KWIC_Shared.SharedData
{
    class CircularShift
    {
       
        

        private string cycledSentence;

        public string CycledSentence
        {
            get { return cycledSentence; }
            set { cycledSentence = value; }
        }
 
         public void Setup(LineStorage lines, List<string> noise)
        {
            string newData = "";
            bool noiseFound;

            foreach (List<string> sentence in lines.Words)
            {
                string tempData = "";
                noiseFound = false;
                for (int x = 0; x < sentence.Count; x++) 
                {
                    string front = "";
                    string back = "";

                    for(int y = x; y < sentence.Count; y++)
                    {
                        front += sentence.ElementAt(y).Trim() + " ";
                        foreach(string n in noise)
                        {
                            if( front.Trim().ToLower() == n.ToLower())
                            {
                                noiseFound = true;
                                break;
                            }
                        }
                    }

                    if(noiseFound)
                    {
                        noiseFound = false;
                        continue;
                    }
                    for(int y = 0; y < x; y++)
                    {
                        back += sentence.ElementAt(y).Trim() + " ";
                    }

                    
                    newData += (front + back).Trim() + Environment.NewLine;
                }
            }

            CycledSentence = newData;

        
        }
    }
}
