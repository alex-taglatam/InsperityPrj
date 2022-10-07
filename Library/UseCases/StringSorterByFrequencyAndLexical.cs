using System;
using System.Collections.Generic;
using System.Linq;

namespace InsperityLibrary
{
    /// <summary>
    /// Class for handle
    /// Rearrange the alphabets in the string in terms of frequency.
    /// and If two or more alphabets have the same frequency, the alphabet which is lexicographically small comes first.
    /// </summary>
    /// <example>
    /// the alphabet having greater frequency comes first.
    /// </example>
    /// <remarks>
    /// 1. The frequency of an alphabet is the number of times an alphabet appears in a string.
    /// Example: Consider the string aabaac; here, the frequency of a is 3, frequency of b is 1, and frequency of c is 1.
    /// 2. Lexicographic order is the way of ordering words based on the alphabetical order of English letters i.e. "a" is the smallest letter and "z" is the 
    /// largest letter
    /// </remarks>
    public class StringSorterByFrequencyAndLexical : ISorter
    {
        /// <summary>
        /// Input Format
        /// The first line contains N, denoting the number of strings.
        /// Next N lines contain strings on which sorting operation has to be performed.
        /// </summary>
        /// <param name="input">string to be processed</param>
        /// <returns>string ordered first by frequency and then by Lexicographic order</returns>
        public string sort(string input)
        {
            //validate the input string
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                throw new InvalidArgumentException("Invalid input string, string is empty");
            }

            //dictionary for chars holding
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();

            foreach (char character in input)
            {
                //char already present
                if (charDictionary.ContainsKey(character))
                {
                    //increment ocurrence
                    charDictionary[character] += 1;
                }
                else
                {
                    //initialize char
                    charDictionary[character] = 1;
                }
            }

            var sortedDict = charDictionary
                //order chars by ocurrence
                .OrderByDescending(x => x.Value)
                //all with same ocurrence value will be ordered based on the alphabetical order
                .ThenBy(x => x.Key)
                //output string with chars repeated by ocurrence
                .Select(x => new string(x.Key, x.Value));

            //resulting string
            string result = "";

            foreach (var item in sortedDict)
            {
                //append dictionary processed chars with it corresponding repetition
                result += item;
            }

            return result;
        }
    }
}
