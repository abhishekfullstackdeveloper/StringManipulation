using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class StringWithASCIIDifference
    {
        public static void Main()
        {
            string input = "abc";
            string result = StringWithASCIIDifference1(input);
            Console.WriteLine(result); // Output: a1b1c
        }

        public static string StringWithASCIIDifference1(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length - 1; i++)
            {
                char currentChar = input[i];
                char nextChar = input[i + 1];
                int diff = nextChar - currentChar;

                result.Append(currentChar);
                result.Append(diff);
            }

            // Append the last character
            result.Append(input[input.Length - 1]);

            return result.ToString();
        }
    }
}
