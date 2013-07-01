using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;
namespace TestgGraphrez
{
    [TestClass]
    public class FactorialTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            Factorial calc = new Factorial();
            Assert.AreEqual(6, Calculate(3), 0.001);

        }
    }
}
