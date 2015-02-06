using System.Collections.Generic;

namespace Homework_1.Pipes
{
    public class GenericPipe : IPipe
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

                try
                {
                    if (Pump != null)
                    {
                        Pump.Sink = this;
                    }
                }
                catch
                {

                }
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
                try
                {
                    if (Drain != null)
                    {
                        Drain.Source = this;
                    }
                }
                catch{ }

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
