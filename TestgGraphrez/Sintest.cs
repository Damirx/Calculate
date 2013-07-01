using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class SinTest
    {
         [TestMethod]
        public void DoubleTestTest()
        {
            Sinus calc = new Sinus();
            Assert.AreEqual(0.841, calc.Calculate(1.0), 0.001);
            Assert.AreEqual(0.909, calc.Calculate(2.0), 0.001);
            Assert.AreEqual(-0.756, calc.Calculate(4.0), 0.001);
            Assert.AreEqual(-0.279, calc.Calculate(6.0), 0.001);
            Assert.AreEqual(0.989, calc.Calculate(8.0), 0.001);
            Assert.AreEqual(-0.544, calc.Calculate(10.0), 0.001);
        }
    }
}
