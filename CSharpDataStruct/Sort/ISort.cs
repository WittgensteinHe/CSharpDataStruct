using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStruct.Sort
{
    public interface ISort
    {
        void Sort(int[] array);
    }

    public enum SortType
    {
        SelectionSort = 0,
    }
}
