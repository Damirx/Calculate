using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using graphrez;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestgGraphrez
{
    [TestClass]
    public class ToYTest
    {
        [TestMethod]
        public void TestTo()
        {
            ToY calc = new ToY();
            Assert.AreEqual(0.14, calc.Calculate(1, 3), 0.01);
        }
    }
}
