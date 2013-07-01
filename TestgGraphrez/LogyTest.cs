using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class LogyTest
    {
        [TestMethod]
        public void TestInt()
        {
            Logy calc = new Logy();
            Assert.AreEqual(1, calc.Calculate(2, 2), 0.001);
        }

    }
}