using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;
namespace TestgGraphrez
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void TestInt()
        {
            Factorial calc = new Factorial();

            Assert.AreEqual(1307674368000, calc.Calculate(15));
        

        }
     }
}
