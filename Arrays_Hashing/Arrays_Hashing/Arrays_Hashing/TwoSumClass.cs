using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Hashing
{
    /// <summary>
    /// Given an array of integers nums and an integer target, 
    /// return indices of the two numbers such that they add up to target
    /// 
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// 
    /// You can return the answer in any order.
    /// 
    /// Input: nums = [2,7,11,15], target = 9
    /// Output: [0,1]
    /// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    /// </summary>
    public class TwoSumClass
    {
        /*
            Brute Force O(n)2 - Nested loops
         */
        public int[] TwoSumNested(int[] nums, int target)
        {
            int[] result = new int[0];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        result = new int[] { i, j };
                }
            }

            return result;
        }

        /*
            Uses Dictionary to remove the need to iterate the array muliptle times - O(n)
         */
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i])) return new int[] { dict[target - nums[i]], i };

                dict[nums[i]] = i;
            }

            return new int[0];
        }
    }
}
