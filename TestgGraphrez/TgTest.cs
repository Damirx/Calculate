using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class TgTest
    {
        [TestMethod]
        public void DoubleTest()
        {
            Tangens calc = new Tangens();
            Assert.AreEqual(1.557, calc.Calculate(1.0), 0.001);
            Assert.AreEqual(-2.185, calc.Calculate(2.0), 0.001);
            Assert.AreEqual(1.157, calc.Calculate(4.0), 0.001);
            Assert.AreEqual(-0.291, calc.Calculate(6.0), 0.001);
            Assert.AreEqual(-6.799, calc.Calculate(8.0), 0.001);
            Assert.AreEqual(0.648, calc.Calculate(10.0), 0.001);
        }
    }
}
