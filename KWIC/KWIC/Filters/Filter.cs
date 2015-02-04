using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    abstract class Filter
    {
        private TextParser parseText;
        protected TextParser ParseText
        {
            get { return parseText; }
            set { parseText = value; }
        }
        protected List<List<string>> tempStorage;
        public List<List<string>> TempStorage
        {
            get { return tempStorage; }
            set { tempStorage = value; }
        }

        private Pipe source;
        public Pipe Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }

        private Pipe sink;
        public Pipe Sink
        {
            get
            {
                return sink;
            }
            set
            {
                sink = value;
            }
        }


        public void attachPipe(Pipe src, Pipe snk = null)
        {
            source = src;
            sink = snk;
        }

        public void pullData(List<List<string>> input)
        {
            tempStorage = new List<List<string>>();
            tempStorage = input;
        }


    abstract public void pushData();
    abstract public void pullData();
    abstract public bool action();
    }
}
