using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.SharedData
{
    class LineStorage
    {

        private List<List<string>> words = new List<List<string>>();

        public List<List<string>> Words
        {
            get { return words; }
        }

        public void addWord(int line, string word)
        {
            Words[line].Add(word);
        }

        public string getWord(int line, int word)
        {
            return Words[line][word];
        }

        public void setChar(int line, int word, int c, char value)
        {
            Words[line][word].ToCharArray()[c] = value;
        }

        public char getChar(int line, int word, int c)
        {
            return Words[line][word][c];
        }


        public LineStorage(string line)
        {
            if (line == null)
                return;

            int next = 0;

            for (int x = 0; x < line.Length; x++)
            {
                string data;

                switch (line[x])
                {
                    case '\r':
                    case '\n':
                        if (next == x)
                            continue;

                        data = line.Substring(next, (x - next) + 1).Trim();
                        if (data.Length < 2)
                            continue;
                        Console.WriteLine("Here is the data: " + data);
                        Words.Add(ParseLine(data));
                        next = x + 1;
                        break;
                    default:
                        if (x == line.Length - 1)
                        {
                            data = line.Substring(next, (x - next) + 1).Trim();
                            if (data.Length <= 2)
                                break;

                            Console.WriteLine("Here is the data: " + data);
                            Words.Add(ParseLine(line.Substring(next, (x - next) + 1)));
                            return;
                        }
                        break;

                }
            }
        }

        private int previous;
        public int Previous
        {
            get { return previous; }
            set { previous = value; }
        }

        private List<string> ParseLine(string line)
        {
            List<string> sentence = new List<string>();
            Previous = 0;

            for (int x = 0; x < line.Length; x++)
            {
                if (line[x].Equals(' '))
                {
                    if (Previous == 0)
                    {
                        sentence.Add(line.SubString(0, (x)).TrimEnd('\r', '\n'));
                    }
                    else
                    {
                        sentence.Add(line.Substring(Previous + 1, (x - Previous - 1)).TrimEnd('\r', '\n'));
                    }

                    Previous = x;
                }
            }

            sentence.Add(line.Substring((Previous + 1), (line.Length - (Previous + 1))).TrimEnd('\r', '\n'));
        }

    }
}
