using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStruct.Sort
{
    public class SelectionSort: ISort
    {
        public SelectionSort()
        {
        }

        public void Sort(int[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                int lowNumberIndex = i;
                for (int j = i+1; j < array.Length; j++) 
                {
                    if (array[j] < array[lowNumberIndex])
                    {
                        lowNumberIndex = j;
                    }
                }

                if(lowNumberIndex!=i)
                {
                    var temp = array[i];
                    array[i] = array[lowNumberIndex];
                    array[lowNumberIndex] = temp;
                }                
            }
        }
    }
}
