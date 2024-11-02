using CSharpDataStruct.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Sort
{
    internal class SortExercise : IExercise
    {
        private ISort sortImp;
        private SortType sortType;

        public SortExercise()
        {
            sortType = SortType.SelectionSort;
            sortImp = this.Create(sortType);
        }

        public void Do()
        {
            int[] array = new int[]
            {
                5,4,7,1,8,9,3,2,7,0,1
            };            
            sortImp.Sort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item + ",");
            }
        }


        protected ISort Create(SortType sortType)
        {
            switch (sortType)
            {
                case SortType.SelectionSort:
                    sortImp = new SelectionSort();
                    break;
            }
            return sortImp;
        }
    }
}
