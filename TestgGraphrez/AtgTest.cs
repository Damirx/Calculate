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
            Assert.AreEqual(-0.457, Calc.Calculate(2), 0.001);
            Assert.AreEqual(0.863, Calc.Calculate(4), 0.001);
        }
    }
}
