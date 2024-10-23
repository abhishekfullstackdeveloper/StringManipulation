using System;
using System.Collections.Generic;

public class HighestFrequencyCharacter
{
    //public static char GetHighestFrequencyCharacter(string s)
    //{
    //    if (string.IsNullOrEmpty(s))
    //    {
    //        throw new ArgumentException("Input string cannot be null or empty.");
    //    }

    //    // Step 1: Initialize a dictionary to count frequencies
    //    Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

    //    // Step 2: Count the frequency of each character in the string
    //    foreach (char c in s)
    //    {
    //        if (frequencyMap.ContainsKey(c))
    //        {
    //            frequencyMap[c]++;
    //        }
    //        else
    //        {
    //            frequencyMap[c] = 1;
    //        }
    //    }

    //    // Step 3: Find the character with the highest frequency
    //    char highestFrequencyChar = '\0';
    //    int maxFrequency = 0;

    //    foreach (var kvp in frequencyMap)
    //    {
    //        if (kvp.Value > maxFrequency)
    //        {
    //            maxFrequency = kvp.Value;
    //            highestFrequencyChar = kvp.Key;
    //        }
    //    }

    //    return highestFrequencyChar;
    //}

    //public static void Main(string[] args)
    //{
    //    string input = "sample text with highest frequency character";

    //    try
    //    {
    //        char result = GetHighestFrequencyCharacter(input);
    //        Console.WriteLine($"The character with the highest frequency is: '{result}'");
    //    }
    //    catch (ArgumentException ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }

    //    // Additional test cases
    //    string input2 = "aabbcc";
    //    char result2 = GetHighestFrequencyCharacter(input2);
    //    Console.WriteLine($"The character with the highest frequency is: '{result2}'");

    //    string input3 = "zzzzzxy";
    //    char result3 = GetHighestFrequencyCharacter(input3);
    //    Console.WriteLine($"The character with the highest frequency is: '{result3}'");
    //}
}
