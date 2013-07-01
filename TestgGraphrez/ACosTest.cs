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
            Arccos Calc = new Arccos();
            Assert.AreEqual(-2.402, Calc.Calculate(2.0), 0.001);
            Assert.AreEqual(-1.529, Calc.Calculate(4.0), 0.001);
        }
    }
}
