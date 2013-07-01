using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using graphrez;


namespace TestgGraphrez
{
    [TestClass]
    public class ExpTest
    {
        [TestMethod]
    
        public void Testdooble()
        {
            Exp calc = new Exp();

            Assert.AreEqual(2.718, calc.Calculate(1), 0.001);
            
        }
    }
}
