﻿using System;
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
<<<<<<< HEAD
            switch (String.Compare(x, y))
            {
                case -1:
                    if (x.ToLower()[0] == y.ToLower()[0])
                    {
                        if (Char.IsLower(x[0]) && Char.IsUpper(y[0]))
                            return -1;
                        if (Char.IsUpper(x[0]) && Char.IsLower(y[0]))
                            return 1;
                    }
                    return -1;
                case 0:
                    return 0;
                case 1:
                    if (x.ToUpper()[0] == y.ToUpper()[0])
                    {
                        if (Char.IsLower(x[0]) && Char.IsUpper(y[0]))
                            return -1;
                        if (Char.IsUpper(x[0]) && Char.IsLower(y[0]))
                            return 1;
                    }
                    return 1;
            }


            if (x.Length > 1)
            { }
            else
            { return -1; }
            if (y.Length > 1)
            { }
            else
                return 1;

            return Compare(x.Substring(1), y.Substring(1));
        }
      
=======
            if (x.Equals(y))
                return 0;
        //    if(x.ToLower()[0] == y.ToLower()[0])
           //     return iterate(x, y, 0);


            return String.Compare(x, y);
        }


    //    public int iterate(string x, string y, int depth)
   //     {
   //         int val = 0;

            
   //         if(x.Substring(depth + 1, x.Length).ToLower() == y.Substring(depth + 1, y.Length).ToLower())
   //         {
        //        return iterate(x, y, 0);
      //      }
     //       return val;
        //}
>>>>>>> origin/master
    }
}
