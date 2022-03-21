using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sort
{
    internal class QuickSort : ISort
    {   //                             pivot = 6
        //List<int> listInt2 = new List<int> {   , 3, 1, 5, 4, 9, 7, 8, 2 };
        public List<int> Sort(List<int> items)
        {
            for (int i = 0; i < items.Count(); i++)
            {
                split(items, items[i], items[items.Count()]);
            }
            return items;
        }

        private List<int> split(List<int> items, int left, int right)
        {
            int pivot = items[left];
            for (int i = items[right] ; i < items.Count(); i--)
            {
                while(i >= 0 && items[i] < pivot)
                {
                    items[left] = items[i];
                    split(items, left + 1, right);
                }
                i++;
            }
            return items;
        }
    }
}
