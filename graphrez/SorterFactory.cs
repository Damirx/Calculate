using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public static class SorterFactory
    {
        public static Sorter CreateSort(string sortname)
        {
            switch (sortname)
            {
                case "Sort1":
                    return new Sort1();
                case "Sort2":
                    return new Sort2();
                case "Sort3":
                    return new Sort3();
                default:
                    throw new Exception("Unknown operration");
            }
        }
    }
}
