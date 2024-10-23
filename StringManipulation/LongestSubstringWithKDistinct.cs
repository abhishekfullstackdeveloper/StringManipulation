using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    //public class LongestSubstringWithKDistinct
    //{
    //    static void Main(string[] args)
    //    {
    //        string str = "aabbccdd";
    //        int k = 2;
    //        int length = LongestSubstringLength(str, k);
    //        Console.WriteLine("Length of the longest substring with " + k + " distinct characters: " + length);
    //    }
    //    public static int LongestSubstringLength(string s, int k)
    //    {
    //        if (s == null || s.Length == 0 || k <= 0)
    //            return 0;

    //        Dictionary<char, int> charCount = new Dictionary<char, int>();
    //        int left = 0, maxSubstringLength = 0;

    //        for (int right = 0; right < s.Length; right++)
    //        {
    //            // Add current character to dictionary or update count
    //            if (charCount.ContainsKey(s[right]))
    //                charCount[s[right]]++;
    //            else
    //                charCount.Add(s[right], 1);

    //            // Shrink the window until we have k distinct characters
    //            while (charCount.Count > k)
    //            {
    //                char leftChar = s[left];
    //                charCount[leftChar]--;
    //                if (charCount[leftChar] == 0)
    //                    charCount.Remove(leftChar);
    //                left++;
    //            }

    //            // Update the maximum length if needed
    //            maxSubstringLength = Math.Max(maxSubstringLength, right - left + 1);
    //        }

    //        return maxSubstringLength;
    //    }
    //}
}
