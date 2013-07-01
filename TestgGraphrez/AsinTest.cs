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
        public void doubleTest()
        {
            Arcsinus Calc = new Arcsinus();
            Assert.AreEqual(1.099, Calc.Calculate(2.0), 0.001);
            Assert.AreEqual(-1.321, Calc.Calculate(4.0), 0.001);
        }
    }
}
