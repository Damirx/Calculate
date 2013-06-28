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
                    return new Perevod_vRad();
                case "arcsinus":
                    return new Arcsinus();
                // case
                default:
                    throw new Exception("Unknown operration");

            }
        }
    }
    }