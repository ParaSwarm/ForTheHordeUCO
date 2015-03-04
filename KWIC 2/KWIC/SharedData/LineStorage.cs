using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWIC_Shared.SharedData
{
    class LineStorage
    {

        private List<List<string>> words = new List<List<string>>();

        public int SentenceCount
        {
            get { return words.Count; }
        }


       
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
            string message = "";

            try 
            { 
                message = Words[line][word];
            }
            catch(Exception ex)
            {
                 if (Words.Count < line)
                     message = "Line does not exist";
                 else
                     message = "Word does not exist";

                MessageBox.Show(message + ". Please check your indexes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }


            return message;
        }

        public List<List<string>> getSentences()
        {
            List<List<string>> temp = new List<List<string>>();
            temp.AddRange(words);

            return temp;    
        }

        public string getSentence(int line)
        {
            string sentence = "";
            
            try
            {
                List<string> temp = Words[line];
                for (int x = 0; x < temp.Count; x++)
                {
                    sentence += temp[x] + " ";
                }

            }
            catch (Exception ex)
            {
            
                MessageBox.Show("Selected Index out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

           
            return sentence.Trim();
        }

        public void setChar(int line, int word, int c, char value)
        {

            try
            {
                StringBuilder newWord = new StringBuilder();

                newWord.Append(Words[line][word].ToString());

                newWord[c] = value;
                Words[line][word] = newWord.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Character could not be set: Please check your indexies", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        public char getChar(int line, int word, int c)
        {
            char message =  ' ';

            try
            {
                message = Words[line][word][c];

            } catch (Exception ex)
            {
                MessageBox.Show("Character could not be set: Please check your indexies", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ' ';
            }
            return message;
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
                            if (!line.Contains(' '))
                            {
                                List<String> temp = new List<String>();

                                temp.Add(line);
                                Words.Add(temp);
                                data = line;
                            }
                            else
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
                        sentence.Add(line.Substring(0, (x)).TrimEnd('\r', '\n'));
                    }
                    else
                    {
                        sentence.Add(line.Substring(Previous + 1, (x - Previous - 1)).TrimEnd('\r', '\n'));
                    }

                    Previous = x;
                }
            }

            sentence.Add(line.Substring((Previous + 1), (line.Length - (Previous + 1))).TrimEnd('\r', '\n'));
            return sentence;
        }

    }
}
