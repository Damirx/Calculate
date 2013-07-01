using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using graphrez;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestgGraphrez
{
    [TestClass]
    public class ConvertToRadTest
    {
        [TestMethod]
        public void TestRad()
        {
            ConvertToRad calc = new ConvertToRad();
            Assert.AreEqual(45.00, calc.Calculate(2579.58), 0.01);
        }
    }
}
