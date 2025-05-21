using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    return new[] { value, i };
                }
                else
                {
                    twoSum.Add(numbers[i], i);
                }
            }

            return  new int[] {};
        }
    }
}
