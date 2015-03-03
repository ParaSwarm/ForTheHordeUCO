using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC_Shared.SharedData
{
   
    class AlphabetShift
    {
        private List<string> alpha_block = new List<string>();
        public List<string> Alpha_Block
        {
            set { alpha_block = value; }
            get { return alpha_block; }
        }


        private string alphabet;
        public string Alphabet
        {
            get { return alphabet; }
            set { alphabet = value; }
        }

        public void Setup(List<string> temp)
        {

            StringCompare compare = new StringCompare();
            Alpha_Block = temp;
            Alphabet = "";

            Alpha_Block.Sort(compare);
            Alpha_Block.Sort(compare);

            for(int x = 0; x < Alpha_Block.Count; x++)
            {
                Alphabet += Alpha_Block.ElementAt(x) + Environment.NewLine;
            }
        }
    }

    public class StringCompare : Comparer<string>
    {
        public override int Compare(string x, string y)
        {
        
            return x.Trim().CompareTo(y.Trim());
        }
    }
}
