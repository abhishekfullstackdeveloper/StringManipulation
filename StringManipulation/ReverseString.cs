using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class ReverseStringCode
    {
        //static void Main()
        //{
        //    string input = "Hello, World!";
        //    string reversedString = ReverseString(input);

        //    Console.WriteLine(reversedString); // Output will be: "!dlroW ,olleH"
        //}


        //Reverse keyword
        static string ReverseString(string input)
        {
            char[] stringArray = input.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            return reversedStr;
        }


        //Reverse a method using a StringBuilder
        static string ReverseString1(string input)
        {
            StringBuilder reversed = new StringBuilder();

            // Iterate through the string in reverse order and append each character to the StringBuilder
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            return reversed.ToString();
        }
    }
}
