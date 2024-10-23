using System;
using System.Collections.Generic;

public class KAnagramsChecker
{
    //public static bool AreKAnagrams(string str1, string str2, int k)
    //{
    //    // Step 1: Check if both strings have the same length
    //    if (str1.Length != str2.Length)
    //    {
    //        return false;
    //    }

    //    // Step 2: Count the frequency of each character in both strings
    //    Dictionary<char, int> charCount1 = new Dictionary<char, int>();
    //    Dictionary<char, int> charCount2 = new Dictionary<char, int>();

    //    foreach (char c in str1)
    //    {
    //        if (charCount1.ContainsKey(c))
    //        {
    //            charCount1[c]++;
    //        }
    //        else
    //        {
    //            charCount1[c] = 1;
    //        }
    //    }

    //    foreach (char c in str2)
    //    {
    //        if (charCount2.ContainsKey(c))
    //        {
    //            charCount2[c]++;
    //        }
    //        else
    //        {
    //            charCount2[c] = 1;
    //        }
    //    }

    //    // Step 3: Calculate the differences in frequencies
    //    int differenceCount = 0;
    //    foreach (var kvp in charCount1)
    //    {
    //        char character = kvp.Key;
    //        int countInStr1 = kvp.Value;
    //        int countInStr2 = charCount2.ContainsKey(character) ? charCount2[character] : 0;

    //        if (countInStr1 > countInStr2)
    //        {
    //            differenceCount += countInStr1 - countInStr2;
    //        }
    //    }

    //    // Step 4: Check if the total differences are within the allowed k changes
    //    return differenceCount <= k;
    //}

    //public static void Main(string[] args)
    //{
    //    string str1 = "anagram";
    //    string str2 = "mangaar";
    //    int k = 1;

    //    bool result = AreKAnagrams(str1, str2, k);
    //    Console.WriteLine($"Are \"{str1}\" and \"{str2}\" {k}-anagrams? {result}");
    //}
}
