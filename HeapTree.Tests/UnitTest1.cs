using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

using Heap_Tree;

using Xunit;

namespace HeapTree.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(50)]
        [InlineData(20000)]
        public void insertWorksWithLargeAmounts(int n)
        {
            Random gen = new Random();
            var heap = new MinHeap<int>(); 

            for (int a = 0; a < n; a++)
            {
                heap.Insert(gen.Next(1, 100));
            }

            Assert.True(correctHeap(heap));
        }

        [Theory]
        [InlineData (100)]
        [InlineData (1000)]
        [InlineData (10000)]
        [InlineData (25000)]
        public void popWorksWthLargeAmounts (int n)
        {
            Random gen = new Random(n);
            var heap = new MinHeap<int>();

            for (int a = 0; a < n; a++)
            {
                heap.Insert(gen.Next(1, 500));
            }

            for (int a = 0; a < n/2; a++)
            {
                var temp = heap.Pop();
            }

            Assert.True(correctHeap(heap));
        }

        public bool correctHeap(MinHeap<int> heap)
        {
            for (int a = 0; a < heap.list.Count; a++)
            {
                //if the node has a left child and the child is greater than the parent
                if (heap.findLeftChild(a) < heap.list.Count && heap.list[heap.findLeftChild(a)] < heap.list[a])
                {
                    return false;
                }

                //if the node has a right child and the child is greater than the parent
                if (heap.findRightChild(a) < heap.list.Count && heap.list[heap.findRightChild(a)] < heap.list[a])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
