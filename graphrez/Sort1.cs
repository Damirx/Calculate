using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphrez
{
    public class Sort1: Sorter
    {
        public override List<int> sort(List<int> intArray)
        {
             int min, temp;
            for (int i = 0; i < (intArray.Count) - 1; i++)
            {
                min = i;
 
                for (int j = i + 1; j <  (intArray.Count); j++)
                {
                    if (intArray[j] < intArray[min])
                    {
                        min = j;
                    }
                }
 
                temp = intArray[i];
                intArray[i] = intArray[min];
                intArray[min] = temp;
            }
            return intArray; 
            
        }
             
    }
}
