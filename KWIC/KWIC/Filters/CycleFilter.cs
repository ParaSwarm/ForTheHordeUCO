using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_1.Filters
{
    class CycleFilter : Filter
    {
        public override bool Action()
        {
            string newData = "";

            PullData();

            foreach (List<string> sentence in TempStorage)
            {
                for (int x = 0; x < sentence.Count; x++)
                {
                    string front = "";
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
                    PushData();
            }
            catch (NullReferenceException ex)
            {

            }

            return true;
        }

        public override void PullData()
        {
            tempStorage = Source.Data;
        }

        public override void PushData()
        {
            Sink.Data = tempStorage;
        }
    }
}
