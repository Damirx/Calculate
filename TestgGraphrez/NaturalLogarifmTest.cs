using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;

namespace TestgGraphrez
{
    [TestClass]
    public class NaturalLogarifmTest
    {
        [TestMethod]
        public void TestDouble()
        {
            NaturalLogarifm calc = new NaturalLogarifm();
            Assert.AreEqual(0.693147, calc.Calculate(2), 0.001);
        }

        [TestMethod]
        public void TestInt()
        {
            NaturalLogarifm calc = new NaturalLogarifm();
            Assert.AreEqual(1, calc.Calculate(2.718), 0.001);
        }
    }
}