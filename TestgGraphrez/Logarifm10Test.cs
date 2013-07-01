using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class Logarifm10Test
    {
        [TestMethod]
        public void TestInt()
        {
            Logarifm10 calc = new Logarifm10();
            Assert.AreEqual(1,calc.Calculate(10), 0.001);
            
        }

    }
}