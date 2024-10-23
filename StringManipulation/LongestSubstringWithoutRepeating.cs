using System;
using System.Collections.Generic;

public class LongestSubstringWithoutRepeating
{
    //public static int LengthOfLongestSubstring(string s)
    //{
    //    if (string.IsNullOrEmpty(s))
    //    {
    //        return 0;
    //    }

    //    // Initialize the HashSet to track characters in the current window
    //    HashSet<char> charSet = new HashSet<char>();

    //    int left = 0;
    //    int right = 0;
    //    int maxLength = 0;

    //    // Iterate over the string with the right pointer
    //    while (right < s.Length)
    //    {
    //        // If the character is not in the set, add it and update the maxLength
    //        if (!charSet.Contains(s[right]))
    //        {
    //            charSet.Add(s[right]);
    //            maxLength = Math.Max(maxLength, right - left + 1);
    //            right++;
    //        }
    //        else
    //        {
    //            // If the character is already in the set, remove the character at the left pointer
    //            // and move the left pointer to the right
    //            charSet.Remove(s[left]);
    //            left++;
    //        }
    //    }

    //    return maxLength;
    //}

    //public static void Main(string[] args)
    //{
    //    string input = "abcabcbb";
    //    Console.WriteLine("The length of the longest substring without repeating characters is: " + LengthOfLongestSubstring(input));
    //}
}
