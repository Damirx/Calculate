using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class AsinTest
    {
        [TestMethod]
        public void DoubleTest()
        {
            Arcsinus Calc = new Arcsinus();
            Assert.AreEqual(1.188, Calc.Calculate(1.0), 0.001);
            Assert.AreEqual(1.099, Calc.Calculate(2.0), 0.001);
            Assert.AreEqual(-1.321, Calc.Calculate(4.0), 0.001);
            Assert.AreEqual(-3.578, Calc.Calculate(6.0), 0.001);
            Assert.AreEqual(1.010, Calc.Calculate(8.0), 0.001);
            Assert.AreEqual(-1.838, Calc.Calculate(10.0), 0.001);
        }
    }
}
