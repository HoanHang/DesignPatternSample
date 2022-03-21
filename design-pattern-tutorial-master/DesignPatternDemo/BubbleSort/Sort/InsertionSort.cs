using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sort
{
    class InsertionSort : ISort
    {
        //                                          i[2]
        //List<int> listInt2 = new List<int> { 6, 3, 1, 5, 4 };

        public List<int> Sort(List<int> items)
        {
            for (int i = 1; i < items.Count; i++)
            {
                int curr = items[i];
                int j = i - 1;
                while (j >= 0 && items[j] > curr)
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j + 1] = curr;
            }
            return items;
        }
    }
}
