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
            Tangens Calc = new Tangens();
            Assert.AreEqual(-2.185,Calc.Calculate(2),0.001);
            Assert.AreEqual(1.157, Calc.Calculate(4), 0.001);
        }
    }
}
