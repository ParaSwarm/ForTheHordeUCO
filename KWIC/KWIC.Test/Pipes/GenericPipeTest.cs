using Homework_1;
using Homework_1.Filters;
using Homework_1.Pipes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC.Test.Pipes
{
    [TestClass]
    public class GenericPipeTest
    {
        [TestMethod]
        public void Can_Initilize()
        {
            var data = new List<List<string>> { new List<string> { "TestData1", "TestData2" } };
            var filterPump = new CycleFilter();
            var midFilter = new CycleFilter();
            var filterDrain = new CycleFilter();
            var pipeTransfer = new GenericPipe();
            var pipeTransferInput = new GenericPipe();


            filterPump.PullData(data);
            pipeTransferInput.AttachFilter(filterPump, midFilter);
            pipeTransferInput.Pump.PushData();
            pipeTransferInput.Drain.PullData();
            pipeTransfer.AttachFilter(midFilter, filterDrain);

            pipeTransfer.Pump.PushData();
            pipeTransfer.Drain.PullData();

            Assert.AreEqual(data, filterDrain.TempStorage);
            Assert.AreSame(midFilter, pipeTransfer.Pump);
        }
    }
}
