using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Hashing
{
    /// <summary>
    /// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    /// 
    /// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
    /// typically using all the original letters exactly once.
    /// </summary>
    public class ValidAnagramClass
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> sCount = new Dictionary<char, int>();
            Dictionary<char, int> tCount = new Dictionary<char, int>();

            if (s.Length != t.Length)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (!sCount.ContainsKey(s[i]))
                    sCount.Add(s[i], 1);
                else
                    sCount[s[i]] = sCount[s[i]] + 1;

                if (!tCount.ContainsKey(t[i]))
                    tCount.Add(t[i], 1);
                else
                    tCount[t[i]] = tCount[t[i]] + 1;
            }

            foreach (char x in sCount.Keys)
            {
                if (!tCount.ContainsKey(x))
                    return false;

                if (sCount[x] != tCount[x])
                    return false;
            }

            return true;
        }
    }
}
