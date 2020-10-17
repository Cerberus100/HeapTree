using System;

namespace Heap_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new MinHeap<int>();
            var rand = new Random(42);
            for (int a = 0; a < 10; a++)
            {
                heap.Insert(rand.Next(100));
                ;
            }

            //TODO: test if everything works

            ;

            var popped = heap.Pop(); 
        }
    }
}
