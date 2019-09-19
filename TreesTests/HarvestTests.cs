using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees;

namespace Trees.Tests
{
    [TestClass()]
    public class HarvestTests
    {
        [TestMethod()]
        public void harvestTest()
        {
            
            int harvest1 = Harvest.HarvestTwoSections(new int[] { 20, 20, 20, 0, 0, 0, 10, 10 }, 3, 2);
            Assert.Equals(harvest1, 80);
        }
    }
}