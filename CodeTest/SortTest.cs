using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    using NUnit.Framework;
    [TestFixture()]
    class SortTest
    {
        [Test()]
        public void testColinScore()
        {
            Sort sorter = new Sort(@"C:\Users\shum\Documents\Freelancer\Code Test\names.txt");
            Assert.AreEqual(49714, sorter.items.Where(x => x.word == "COLIN").FirstOrDefault().score);
        }
    }
}
