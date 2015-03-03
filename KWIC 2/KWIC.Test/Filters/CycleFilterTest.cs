using KWIC_Shared;
using KWIC_Shared.Filters;
using KWIC_Shared.Pipes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC.Test.Filters
{
        [TestClass]
        public class CycleFilterTest
        {
            [TestMethod]
            public void PullData_CanSetSource()
            {
                var data = new List<List<string>> { new List<string> { "TestData1", "TestData2" } };
                var filter = new CycleFilter();
                var pipe = new GenericPipe(data);

                filter.Source = pipe;

                filter.PullData();

                Assert.AreEqual(filter.TempStorage, data);
            }

            [TestMethod]
            public void PushData_CanSetSink()
            {
                var data = new List<List<string>> { new List<string> { "TestSinkData1", "TestSinkData2" } };
                var filterPump = new CycleFilter();
                var filterDrain = new CycleFilter();
                var pipe = new GenericPipe(data);
                var pipeSink = new GenericPipe();

                filterPump.Source = pipe;
                filterPump.Sink = pipeSink;
                filterPump.PullData();
                filterPump.PushData();

                filterDrain.Source = pipeSink;
                filterDrain.PullData();


                Assert.AreEqual(filterDrain.TempStorage, data);
            }
        }
    }
