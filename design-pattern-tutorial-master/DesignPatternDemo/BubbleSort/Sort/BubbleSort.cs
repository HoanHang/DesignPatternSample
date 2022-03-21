using Algorithm.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sort
{
    class BubbleSort : ISort
    {
        //                                         i[1]
        //                                              j[3]  
        //List<int> listInt = new List<int> {  6,   3, 1, 5, 4 };
        //                                  {  3,   6, 1, 5, 4 };

        public List<int> Sort(List<int> items)
        {
            int listLength = items.Count();

            int temp = 0;

            for (int i = 0; i < listLength; i++)
            {
                for (int j = 0; j < listLength - 1; j++)
                {
                    if (items[j] > items[i])
                    {
                        temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                    
                }
                Console.WriteLine("i{0} list [{1}]", i, string.Join(", ", items));
            }
            return items;
        }
    }
}
