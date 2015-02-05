using System.Collections.Generic;

namespace Homework_1.Pipes
{
    class GenericPipe : IPipe
    {
        public GenericPipe()
        {
            Data = null;
            AttachFilter(null, null);
        }

        public GenericPipe(List<List<string>> input)
        {
            Data = input;
            AttachFilter(null, null);
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

        public GenericPipe(Filter pumpFilter, Filter drainFilter)
        {
            AttachFilter(pumpFilter, drainFilter);
        }

        public void AttachFilter(Filter pumpFilter, Filter drainFilter)
        {
            Pump = pumpFilter;
            Drain = drainFilter;
        }
    }
}
