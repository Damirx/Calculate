using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;
namespace TestgGraphrez
{
    [TestClass]
    public class SubstractionTest
    {
        [TestMethod]
        public void TestInt()
        {
            Substraction calc = new Substraction();
            Assert.AreEqual(999999, calc.Calculate(1000000, 1));
        }

        [TestMethod]
        public void TestDouble()
        {
            Substraction calc = new Substraction();
            Assert.AreEqual(999999,9, calc.Calculate(1000000.0, 1));
        }


    }
}
