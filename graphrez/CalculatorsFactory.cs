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
                case "/":
                    return new division();
                case null:
                    return new NotAct(); 
                case "(sin)":
                    return  new sinus();
                case "(cos)":
                    return new cosinus();
                case "(tg)":
                    return new tangens();
                case "(perevod_vGrad)":
                    return new perevod_vGrad();

                default :
                               throw new Exception("Unknown operration");

            }
        }
    }
}
