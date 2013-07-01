using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class AtgTest
    {
        [TestMethod]
        public void DoubleTest()
        {
            Arctang Calc = new Arctang();
            Assert.AreEqual(0.642, Calc.Calculate(1.0), 0.001);
            Assert.AreEqual(-0.457, Calc.Calculate(2.0), 0.001);
            Assert.AreEqual(0.863, Calc.Calculate(4.0), 0.001);
            Assert.AreEqual(-3.436, Calc.Calculate(6.0), 0.001);
            Assert.AreEqual(-0.147, Calc.Calculate(8.0), 0.001);
            Assert.AreEqual(1.542, Calc.Calculate(10.0), 0.001);
        }
    }
}
