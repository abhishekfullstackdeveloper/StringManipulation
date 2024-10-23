using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class UniqueCharacters
    {
        static int CountUniqueCharacters(string input)
        {
            HashSet<char> uniqueChars = new HashSet<char>();

            foreach (char c in input)
            {
                if (!uniqueChars.Contains(c))
                {
                    uniqueChars.Add(c);
                }
            }

            return uniqueChars.Count;
        }

        //static void Main(string[] args)
        //{
        //    string input = "example string";
        //    int uniqueCount = CountUniqueCharacters(input);
        //    Console.WriteLine("Number of unique characters: " + uniqueCount);
        //}
    }
}
