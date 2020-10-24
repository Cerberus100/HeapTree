using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Heap_Tree
{
    public class MinHeap<T> where T : IComparable<T>
    {
        public List<T> list = new List<T>();

        //returns the index for the leftChild for a given index
        public int findLeftChild (int i) 
        {
            return (i * 2) + 1;
        }

        public int findRightChild (int i) //returns the index for the rightChild for an index
        {
            return (i * 2) + 2; 
        }

        public int findParent (int i) //returns the index for the parent of an index
        {
            return (i - 1) / 2; 
        }


        private void swap (int a, int b)
        { 
            T x = list[a];
            T y = list[b];

            list[b] = x;
            list[a] = y;
        }
        public void Insert(T value)
        {
            list.Add(value);
            heapifyUp(list.Count - 1);
        }

        public void heapifyUp(int index)
        {
            if (index <= 0)
            {
                return;
            }

            int pIndex = findParent(index);

            if (list[index].CompareTo(list[pIndex]) < 0) //if it is root or if the current value is more than its parent valu 
            {
                swap(index, pIndex);
                heapifyUp(pIndex);
            }
        }

        public T Pop ()
        {
            if (list.Count <= 0)
            {
                throw new Exception("Heap empty.");
            }

            T value = list[0]; //original root value

            list[0] = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);

            heapifyDown(0);

            return value; //returns the original root 
        }

        public void heapifyDown (int index)
        {
            if (index >= list.Count)
            {
                return;
            }

            int lIndex = findLeftChild(index);
            if (lIndex >= list.Count)
            {
                return;
            }

            int potSwapIndex = lIndex;

            int rIndex = findRightChild(index);

            if (rIndex < list.Count && list[rIndex].CompareTo(list[lIndex]) < 0)
            {
                potSwapIndex = rIndex;
            }

            if (list[index].CompareTo(list[potSwapIndex]) > 0)
            {
                swap(index, potSwapIndex);
                heapifyDown(potSwapIndex);
            }
            //else if (list[index].CompareTo (list[rIndex]) > 0)
            //{
            //    swap(index, rIndex);
            //    heapifyDown(rIndex);
            //}SSS
            //else
            //{
            //    return; 
            //}
        }
    }
}
