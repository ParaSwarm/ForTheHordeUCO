using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_1.Filters
{
    class AlphabetizeFilter : Filter
    {

       public override bool action()
        {

            pullData();

            ListStringCompare compare = new ListStringCompare();

           TempStorage.Sort(compare);
            
       
            pushData();
            return true;
        }

        public override void pullData()
        {
            tempStorage = Source.Data;
        }

        public override void pushData()
        {
         //   Sink.Data = tempStorage;
        }
    }


    public class ListStringCompare : Comparer<List<string>>
    {
        public override int Compare(List<string> x, List<string> y)
        {
           return x.ElementAt(0).CompareTo(y.ElementAt(0));
        }
    }
}
