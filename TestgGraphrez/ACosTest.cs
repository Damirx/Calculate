using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class ACosTest
    {
        [TestMethod]
        public void DoubleTest()
        {
            Arccos calc = new Arccos();
            Assert.AreEqual(1.850, calc.Calculate(1.0), 0.001);
            Assert.AreEqual(-2.402, calc.Calculate(2.0), 0.001);
            Assert.AreEqual(-1.529, calc.Calculate(4.0), 0.001);
            Assert.AreEqual(1.041, calc.Calculate(6.0), 0.001);
            Assert.AreEqual(-6.872, calc.Calculate(8.0), 0.001);
            Assert.AreEqual(-1.191, calc.Calculate(10.0), 0.001);
        }
    }
}
