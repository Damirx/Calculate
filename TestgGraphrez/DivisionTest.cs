using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class DivisionTest
    {
        [TestMethod]
        public void TestInt()
        {
            Division calc = new Division();

            Assert.AreEqual(1, calc.Calculate(2, 2), 0.001);
            

        }
        [TestMethod]
        public void TestFloat()
        {
            Division calc = new Division();

            Assert.AreEqual(0.5, calc.Calculate(1, 2), 0.001);

        }
    }
}
