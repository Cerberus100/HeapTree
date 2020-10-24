using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heap_Tree
{
    public static class Extensions
    {
        public static bool IsSortedAscending<T>(this IEnumerable<T> items) where T:IComparable<T>
        {
            var arr = items.ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    return false;
                }

            }

            return true;
        }


        public static string Reverse(this string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }

    }
}
