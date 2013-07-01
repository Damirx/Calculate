using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class CosTest
    {
        [TestMethod]
        public void DoubleTest()
        {
            Cosinus Calc = new Cosinus();
            Assert.AreEqual(0.540, Calc.Calculate(1.0), 0.001);
            Assert.AreEqual(-0.416, Calc.Calculate(2.0), 0.001);
            Assert.AreEqual(-0.653, Calc.Calculate(4.0), 0.001);
            Assert.AreEqual(0.960, Calc.Calculate(6.0), 0.001);
            Assert.AreEqual(-0.145, Calc.Calculate(8.0), 0.001);
            Assert.AreEqual(-0.839, Calc.Calculate(10.0), 0.001);
        }
    }
}
