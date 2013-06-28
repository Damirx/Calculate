using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public static class BinaryCalculatorsFactory
    {
        public static BinaryOperation Create(string name)
        {
            switch (name)
            {
                case "+" :
                    return new Addition();
                case "-":
                    return  new Substraction();
                case "*":
                    return new Multiplication();
                case "/":
                    return new Division();
                case null:
                    return new NotAct(); 
                case "ToX":
                    return new ToX();
                case "ToY":
                    return new ToY();
                case "Pow":
                    return new Pow();
                case "Izvlech_iz_korn":
                    return new IzvlechIzKorn();
                case "log":
                    return new Logy();
                default :
                               throw new Exception("Unknown operration");

            }
        }
    }
}
