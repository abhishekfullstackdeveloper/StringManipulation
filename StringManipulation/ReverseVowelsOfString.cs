using System;
using System.Collections.Generic;

public class ReverseVowelsOfString
{
    //public static string ReverseVowels(string s)
    //{
    //    if (string.IsNullOrEmpty(s))
    //    {
    //        return s;
    //    }

    //    // Convert the string to a character array to allow swapping
    //    char[] characters = s.ToCharArray();
    //    int left = 0;
    //    int right = characters.Length - 1;

    //    // Define a set of vowels for quick lookup
    //    HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    //    // Left-right pointer strategy
    //    while (left < right)
    //    {
    //        // Move the left pointer to the next vowel
    //        while (left < right && !vowels.Contains(characters[left]))
    //        {
    //            left++;
    //        }

    //        // Move the right pointer to the previous vowel
    //        while (left < right && !vowels.Contains(characters[right]))
    //        {
    //            right--;
    //        }

    //        // Swap the vowels
    //        if (left < right)
    //        {
    //            char temp = characters[left];
    //            characters[left] = characters[right];
    //            characters[right] = temp;

    //            // Move the pointers towards the center
    //            left++;
    //            right--;
    //        }
    //    }

    //    // Convert the character array back to a string and return
    //    return new string(characters);
    //}

    //public static void Main(string[] args)
    //{
    //    string input = "hello";
    //    string reversed = ReverseVowels(input);
    //    Console.WriteLine($"Original string: {input}");
    //    Console.WriteLine($"Reversed vowels string: {reversed}");

    //    // Additional test cases
    //    string input2 = "leetcode";
    //    string reversed2 = ReverseVowels(input2);
    //    Console.WriteLine($"Original string: {input2}");
    //    Console.WriteLine($"Reversed vowels string: {reversed2}");
    //}
}
