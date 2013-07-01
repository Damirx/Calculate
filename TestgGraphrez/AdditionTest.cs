using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void TestInt()
        {
            Addition calc = new Addition();

            Assert.AreEqual(3, calc.Calculate(1, 2), 0.001);
            
        }

        [TestMethod]
        public void TestDooble()
            {
            Addition calc = new Addition();
            Assert.AreEqual(6.0, calc.Calculate(3.0, 3.0), 0.001);
        }


    }
}