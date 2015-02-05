using System.Collections.Generic;

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

        private IPipe source;
        public IPipe Source
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

        private IPipe sink;
        public IPipe Sink
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

        public void AttachPipe(IPipe src, IPipe snk = null)
        {
            source = src;
            sink = snk;
        }

        public void PullData(List<List<string>> input)
        {
            tempStorage = new List<List<string>>();
            tempStorage = input;
        }


        abstract public void PushData();
        abstract public void PullData();
        abstract public bool Action();
    }
}
