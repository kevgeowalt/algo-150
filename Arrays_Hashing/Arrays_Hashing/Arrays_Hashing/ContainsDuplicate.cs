using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Hashing
{
    /// <summary>
    /// Given an integer array nums, return true if any value appears at least twice in the array, 
    /// and return false if every element is distinct.
    /// </summary>
    public class ContainsDuplicateClass
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> temp = new HashSet<int>();

            foreach(int num in nums)
            {
                if (temp.Contains(num))
                    return true;
                temp.Add(num);
            }
            return false;
        }
    }
}
