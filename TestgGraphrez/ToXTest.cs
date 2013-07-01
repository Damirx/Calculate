using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using graphrez;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestgGraphrez
{
    [TestClass]
    public class ToXTest
    {
        [TestMethod]
        public void TestToY()
        {
            ToX calc = new ToX();
            Assert.AreEqual(-3.64, calc.Calculate(4, 9), 0.01);
        }
    }
}
