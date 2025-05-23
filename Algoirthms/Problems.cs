using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Algoirthms
{
    public static class Problems
    {
        
        // Find if the sum of two numbers exist in the array and return the indices
        public static int[] TwoSum(int[] numbers, int sum )
        {
            Dictionary<int, int> twoSum = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int compliment = sum - numbers[i];

                if (twoSum.TryGetValue(compliment, out var value))
                {
                    return new[]{ value, i};
                }
                twoSum.Add(numbers[i], i);
            }

            return new int[] {};
        }


        public static int[] TwoSum1(int[] numbers, int sum)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int compliment = sum - numbers[i];
                if (map.TryGetValue(compliment, out int value))
                {
                    return new [] {value, i};
                }
                else
                {
                    map.Add(numbers[i], i);
                }
            }
            return new int[] { };
        }

        public static int[] TwoSum2(int[] numbers, int sum)
        {
            //dict
            //loop
            //compliment
            //check dict for compliment
            //if not there add current item
            //if present return value and current item
            Dictionary<int, int> twoSum = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int compliment = sum - numbers[i];
                if (twoSum.ContainsKey(compliment))
                {
                    return new int[] {twoSum.GetValueOrDefault(compliment), i};
                }
                else
                {
                    twoSum.Add(numbers[i],i);
                }

            }

            return new int[] { };
        }

        public static List<int> BubbleSortList(List<int> unsortedList)
        {
            // 5 3 2 1 4
            for (int i = 0; i < unsortedList.Count; i++)
            {
                int current = i;

                while (current > 0 && unsortedList[current] < unsortedList[current - 1])
                {
                    int temp = unsortedList[current];
                    unsortedList[current] = unsortedList[current - 1];
                    unsortedList[current - 1] = temp;
                    current--;
                }
            }
            return unsortedList;
        }

        public static int BinarySearch(List<int> arr, int target)
        {
            int left = 0;
            int right = arr.Count - 1;
            while (left <= right) // <= here because left and right could point to the same element, < would miss it
            {
                int mid = left + (right - left) / 2; // use `(right - left) / 2` to prevent `left + right` potential overflow
                // found target, return its index
                if (arr[mid] == target) return mid;
                if (arr[mid] < target)
                {
                    // middle less than target, discard left half by making left search boundary `mid + 1`
                    left = mid + 1;
                }
                else
                {
                    // middle greater than target, discard right half by making right search boundary `mid - 1`
                    right = mid - 1;
                }
            }
            return -1; // if we get here we didn't hit above return so we didn't find target
        }

        public static int FindBoundary(List<bool> arr)
        {
            int left = 0;
            int right = arr.Count - 1;
            int boundaryIndex = -1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid])
                {
                    boundaryIndex = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return boundaryIndex;
        }
    }
}
