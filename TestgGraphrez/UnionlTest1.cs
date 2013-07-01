using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestgGraphrez
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, 3, 0.001);
            Assert.AreEqual(3, 6, 0.001);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, 3, 0.001);
        }
    }
}