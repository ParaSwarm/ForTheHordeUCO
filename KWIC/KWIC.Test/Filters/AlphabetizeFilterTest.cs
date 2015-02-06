using Homework_1;
using Homework_1.Filters;
using Homework_1.Pipes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC.Test.Filters
{
    [TestClass]
    public class AlphabetizeFilterTest
    {
        [TestMethod]
        public void PullData_CanSetSource()
        {
            var data = new List<List<string>> { new List<string> { "TestData1", "TestData2" } };
            var filter = new AlphabetizeFilter();
            var pipe = new GenericPipe(data);

            filter.Source = pipe;

            filter.PullData();

            Assert.AreEqual(filter.TempStorage, data);
        }
    }
}
