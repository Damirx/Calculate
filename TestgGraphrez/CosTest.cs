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
            Assert.AreEqual(-0.416, Calc.Calculate(2.0), 0.001);
            Assert.AreEqual(-0.653, Calc.Calculate(4.0), 0.001);
        }
    }
}
