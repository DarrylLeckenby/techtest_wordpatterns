using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

    /*
    Given a pattern and a string str, find if str follows the same pattern.
    Here follow means a full match, such that there is a match between a letter in pattern and a non-empty word in str.

    Examples:
    pattern = "abba", str = "dog cat cat dog" should return true.
    pattern = "abba", str = "dog cat cat fish" should return false.
    pattern = "aaaa", str = "dog cat cat dog" should return false.
    pattern = "abba", str = "dog dog dog dog" should return false.
    Notes:
    You may assume pattern contains only lowercase letters, and str contains lowercase letters separated by a single space.
    */

namespace WordPattern
{
    class Program
    {

        static void Main(string[] args)
        {

            //Print the results for the four case study patterns
            Console.Write (EvaluatePatternForMatch("abba", "dog cat cat dog") + "\r\n");
            Console.Write(EvaluatePatternForMatch("abba", "dog cat cat fish") + "\r\n");
            Console.Write(EvaluatePatternForMatch("aaaa", "dog cat cat dog") + "\r\n");
            Console.Write(EvaluatePatternForMatch("abba", "dog dog dog dog") + "\r\n");

            Console.WriteLine("\r\nThis program has ended. Press a key to close.");
            Console.ReadKey();

        }

        public static bool EvaluatePatternForMatch(string pattern, string input) {

            //Makes a decision on whether the pattern of one string array matches the other

            string[] patternarray = pattern.Select(x => x.ToString()).ToArray();
            string[] inputarray = input.Split(' ');

            if (GetPatternFromArray(patternarray) == GetPatternFromArray(inputarray))
                return true;

            return false;

        }

        public static string GetPatternFromArray(string[] inputArray) {

            //Purpose: Turns array into a string numbers based on the unique items dictionary index


            //Create dictionary index of unique array item

            Dictionary<string, int> dictionaryIndex = new Dictionary<string, int>();

            foreach (string s in inputArray) {
                if (!dictionaryIndex.ContainsKey(s))
                    dictionaryIndex.Add(s, dictionaryIndex.Count);
            }

            // Return string of arrays item indexes

            string patternstring = "";

            foreach (string s in inputArray) {
                patternstring += dictionaryIndex[s].ToString();
            }

            return patternstring;

        }

    }

}