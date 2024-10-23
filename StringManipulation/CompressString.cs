using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class CompressString
    {
        //public static void Main(string[] args)
        //{

        //    string input = "aabbbcccc";
        //    string compressed = CompressToUniqueChars1(input);
        //    Console.WriteLine(compressed); // Output: "a2b3c4"
        //}

        //public static string CompressToUniqueChars(string input)
        //{
        //    if (string.IsNullOrEmpty(input)) return input;

        //    StringBuilder result = new StringBuilder();
        //    char previousChar = '\0'; // Initialize to a character that won't appear in the input

        //    foreach (char currentChar in input)
        //    {
        //        if (currentChar != previousChar)
        //        {
        //            result.Append(currentChar);
        //            previousChar = currentChar;
        //        }
        //    }

        //    return result.ToString();
        //}


        //public static string CompressToUniqueChars1(string input)
        //{
        //    if (string.IsNullOrEmpty(input)) return input;

        //    char[] chars = input.ToCharArray();
        //    int index = 0; // index to place the next character in the compressed array
        //    int i = 0; // index to iterate through the input array

        //    while (i < chars.Length)
        //    {
        //        char currentChar = chars[i];
        //        int count = 0;

        //        // Count the number of occurrences of the current character
        //        while (i < chars.Length && chars[i] == currentChar)
        //        {
        //            i++;
        //            count++;
        //        }

        //        // Place the character in the compressed array
        //        chars[index++] = currentChar;

        //        // If the character repeats, add the count to the array
        //        if (count > 1)
        //        {
        //            foreach (char c in count.ToString())
        //            {
        //                chars[index++] = c;
        //            }
        //        }
        //    }

        //    return new string(chars, 0, index); // Convert the compressed array back to a string
        //}
    }

    }
