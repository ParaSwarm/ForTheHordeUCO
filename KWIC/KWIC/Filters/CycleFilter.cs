using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Filters
{
    class CycleFilter : Filter
    {
        public override bool action()
        {
           string newData = "";
 
            pullData();

            foreach (List<string> sentence in TempStorage)
            {


                
                
                for (int x = 0; x < sentence.Count; x++)
                {
                    string front ="";
                    string back = "";

                    for (int y = x; y < sentence.Count; y++)
                    {
                        front += sentence.ElementAt(y).Trim() + " ";
                    }

                    for (int y = 0; y < x; y++)
                    {
                        back += sentence.ElementAt(y).Trim() + " ";
                    }

                    newData += (front + back).Trim() + Environment.NewLine;
                }

            }

            Console.WriteLine(newData.Trim());

            ParseText = new TextParser(newData.Trim());
            TempStorage = ParseText.SentenceList;

            try
            {
                if (Sink.Data != null)
                    pushData();
            }
            catch (NullReferenceException ex)
            {
                
            }
          
            return true;
        }

        public override void pullData()
        {
            tempStorage = Source.Data;
        }

        public override void pushData()
        {
            Sink.Data = tempStorage;
        }
    }
}
