using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_n_2_Algorithm
{/// <summary>
/// Bublle sort O(n^2)
///  для сортировки n элементов 
///  нужны (n-1)+(n-2)+.....+2+1 щагов 
///  = n(n-1)/2
///  = n^2/2 - n/2
/// то есть О(n^2)
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var unsortedList = new List<int>() {1,4,8,6,7,6};
            var sortedList = SortLits(unsortedList);
            Console.WriteLine("we want to sort that's list 1,4,8,6,7,6 \n tap Enter ");
            Console.WriteLine($"Sorted list is : {sortedList}");

        }

        static List<int> SortLits(List<int> unsortedList)
        {
            var sortedList = unsortedList;
            var temp = 0;
            for (int i = 0; i < sortedList.Count; i++) 
            {
                for (int j = i + 1; j < sortedList.Count; j++) 
                {
                    temp = sortedList[i];
                    sortedList[i] = sortedList[j];
                    sortedList[j] = temp;
                }
            }
            return sortedList;
        }

        /* 
         * 
         * 
         * 
         * 
         */
    }
}
