using Algorithm.Sort;
using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            List<int> types = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                int type = random.Next(0, 999);
                types.Add(type);
            }

            //List<int> listInt1 = new List<int> { 6, 3, 1, 5, 4 };

            //ISort sortInterface1 = new BubbleSort();

            //foreach (var item in sortInterface1.Sort(listInt1))
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> listInt2 = new List<int> { 6, 3, 1, 5, 4 };

            //ISort sortInterface2 = new InsertionSort();

            //foreach (var item in sortInterface2.Sort(listInt2))
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> listInt3 = new List<int> { 16, 32, 1, 57, 56, 48, 10, 19, 4 };

            ISort sortInterface3 = new QuickSort();

            Console.WriteLine("{0}", string.Join(", ", sortInterface3.Sort(types)));

        }
    }
}
