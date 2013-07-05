using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class Sort3 : Sorter
    {
        public override List<int> sort(List<int> intArray)
        {
            int helper;
            for (int j = 0; j < intArray.Count; j++)
            {
                for (int i = 0; i < intArray.Count; i++)
                {
                    if (i == ((intArray.Count) - 1)) break;
                    if (intArray[i] > intArray[i + 1])
                    {
                        helper = intArray[i];
                        intArray[i] = intArray[i + 1];
                        intArray[i + 1] = helper;
                    }

                }
            }
            return intArray;
        }

    }
}