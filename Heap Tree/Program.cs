using System;
using System.Collections.Generic;

namespace Heap_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new MinHeap<int>();
            var rand = new Random(42);
            int n = 100;
            for (int a = 0; a < n; a++)
            {
                heap.Insert(rand.Next(100));
            }

            List<int> popped = new List<int>();


            for (int a = 0; a < n; a++)
            {
                popped.Add(heap.Pop ());
            }

            Console.WriteLine(popped.IsSortedAscending());

            Console.WriteLine("billy".Reverse());
        }
    }
}
