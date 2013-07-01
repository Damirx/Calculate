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
                case "(sin)":
                    return new Sinus();
                case "(cos)":
                    return new Cosinus();
                case "(tg)":
                    return new Tangens();
                case "(perevod_vRad)":
                    return new ConvertToRad();
                case "(perevod_vGrad)":
                    return new ConvertToGrad();
                case "arcsinus":
                    return new Arcsinus();
                case "Arccos":
                    return new Arccos();
                case "Arctang":
                    return new Arctang();
                case "Exp":
                    return new Exp();
                case "Sqr":
                    return new Sqr();
                case "Sqrt":
                    return new Sqrt();
                case "!":
                    return new Factorial();
                case "ln":
                    return new NaturalLogarifm();
                case "log10":
                    return new Logarifm10();
                case "log2":
                    return new Logarifm2();
                default:
                    throw new Exception("Unknown operration");

            }
        }
    }
    }