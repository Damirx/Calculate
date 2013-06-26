using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public static class CalculatorsFactory
    {
        public static Operation Create(string name)
        {
            switch (name)
            {
                case "+" :
                    return new Addition();
                case "-":
                    return  new Substraction();
                case "*":
                    return new Multiplication(); 
                default :
                               throw new Exception("Unknown operration");

            }
        }
    }
}
