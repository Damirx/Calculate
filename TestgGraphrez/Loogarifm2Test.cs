using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class Loogarifm2Test
    {
        [TestMethod]
        public void TestInt()
        {
            Logarifm2 calc = new Logarifm2();
            Assert.AreEqual(1, calc.Calculate(2), 0.001);
        }

    }
}