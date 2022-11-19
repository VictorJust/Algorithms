using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class BinarySearch
    {
        public static int Search(int[] arr, int value)
        {
            var leftIndex = 0;
            var rightIndex = arr.Length - 1;

            while (leftIndex <= rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (value.CompareTo(arr[middleIndex]) > 0)
                {
                    leftIndex = middleIndex + 1;
                    continue;
                }

                if (value.CompareTo(arr[middleIndex]) < 0)
                {
                    rightIndex = middleIndex - 1;
                    continue;
                }

                return middleIndex;
            }

            return -1;
        }
    }
}
