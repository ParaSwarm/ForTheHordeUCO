using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    interface Pipe
    {

        void attachFilter(Filter pmp, Filter snk);

        Filter Pump
        {
            get;
            set;
        }

        Filter Drain
        {
            get;
            set;
        }

        List<List<string>> Data
        {
            get;
            set;
        }
    }
}
