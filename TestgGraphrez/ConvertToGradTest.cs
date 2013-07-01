using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using graphrez;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestgGraphrez
{
    [TestClass]
    public class ConvertToGradTest
    {
        [TestMethod]
        public void TestGrad()
        {
            ConvertToGrad calc = new ConvertToGrad();
            Assert.AreEqual(7.01, calc.Calculate(0.1223), 0.01);
        }
    }
}
