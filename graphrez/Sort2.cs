using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class Sort2 : Sorter
    {
        public override List<int> sort(List<int> intArray)
        {
            for (int j = 1; j < intArray.Count; j++)
            {
                for (int i = 1; i < intArray.Count; i++)
                {
                    if (intArray[i - 1] <= intArray[i]) continue;
                    else
                    {
                        int tempVal = intArray[i];
                        intArray[i] = intArray[i - 1];
                        intArray[i - 1] = tempVal;
                        if (i == 0) i = 1;
                    }

                }
            }
            return intArray;
        }

    }
}