using System;
using System.Collections.Generic;

namespace Homework_1
{
    class TextParser
    {
        private List<List<string>> sentenceList = new List<List<string>>();
        public List<List<string>> SentenceList
        {
            get { return sentenceList; }
        }

       public TextParser(string temp)
        {
            if (temp == null)
                return;

            int nextSentence = 0;

            for (int x = 0; x < temp.Length; x++)
            {
                string data;

                switch (temp[x])
                {
                    case '\r':
                    case  '\n':
                        if (nextSentence == x)
                            continue;
                        data = temp.Substring(nextSentence, (x - nextSentence) + 1).Trim();
                        if (data.Length < 2)
                            continue;

                        Console.WriteLine("Here is data: " + data);
                        sentenceList.Add(ParseLine(data));
                        nextSentence = x + 1;
                        break;
                    default:
                        if (x == temp.Length - 1)
                        {

                            data = temp.Substring(nextSentence, (x - nextSentence) + 1);
                            if (data.Length <= 2)
                                break;
                          
                            Console.WriteLine("Here is data: " + data);
                            sentenceList.Add(ParseLine(temp.Substring(nextSentence, (x - nextSentence) + 1)));
                            return;
                        }
                        break;              
                }
            }
            
        }

        private int previousWordIndex;
        public int PreviousWordIndex
        {
            get { return previousWordIndex; }
            set { previousWordIndex = value; }
        }

        private List<string> ParseLine(string temp)
        {
            List<string> sentence = new List<string>();

            previousWordIndex = 0;

            for (int x = 0; x < temp.Length; x++)
            {

                if (temp[x].Equals(' '))
                {
                    if (previousWordIndex == 0)
                    {
                        sentence.Add(temp.Substring(0, (x - previousWordIndex)).TrimEnd('\r','\n'));
                    }
                    else
                    {
                        sentence.Add(temp.Substring(previousWordIndex + 1, (x - previousWordIndex - 1)).TrimEnd('\r','\n'));
                    }

                    previousWordIndex = x;
                }
                Console.WriteLine(x + " of " +temp.Length);
            }

            sentence.Add(temp.Substring((previousWordIndex + 1), (temp.Length - (previousWordIndex + 1))).TrimEnd('\r', '\n'));

            return sentence;
        }
        
    }
}
