using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays_Hashing
{
    /// <summary>
    /// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
    /// 
    /// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
    /// typically using all the original letters exactly once.
    /// 
    /// Input: strs = ["eat","tea","tan","ate","nat","bat"]
    /// [["bat"],["nat","tan"],["ate","eat","tea"]]
    /// 
    /// 
    /// </summary>
    public class GroupAnagramsClass
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> groups = new Dictionary<string, IList<string>>();

            foreach (string str in strs)
            {
                var alphabet = Enumerable.Range('a', 26).ToDictionary(x => (char)x, x => 0);

                foreach (char character in str)
                {
                    alphabet[character] = alphabet[character] + 1;
                }

                var pattern = String.Join(",", alphabet.Values.ToList());

                if (groups.ContainsKey(pattern))
                    groups[pattern].Add(str);
                else
                    groups.Add(pattern, new List<string>() { str });
            }

            return groups.Values.ToList();
        }
    }
}
