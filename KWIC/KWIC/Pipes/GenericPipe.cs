using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Pipes
{
    class GenericPipe : Pipe
    {
        public GenericPipe()
        {
            Data = null;
            attachFilter(null, null);
        }
        public GenericPipe(List<List<string>> input)
        {
            Data = input;
            attachFilter(null, null);
        }

        public GenericPipe(Filter pmp, Filter drn)
        {
            attachFilter(pmp, drn);
        }
        public void attachFilter(Filter pmp, Filter drn)
        {
            pump = pmp;
            drain = drn;
        }

        private Filter pump;
        public Filter Pump
        {
            get
            {
                return pump;
            }
            set
            {
                pump = value;
            }
        }

        protected Filter drain;
        public Filter Drain
        {
            get
            {
                return drain;
            }
            set
            {
                drain = value;
            }
        }

        protected List<List<string>> data;
        public List<List<string>> Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
    }
}
