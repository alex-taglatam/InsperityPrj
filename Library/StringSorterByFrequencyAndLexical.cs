using System;
using System.Collections.Generic;
using System.Linq;

namespace InsperityLibrary
{
    public class StringSorterByFrequencyAndLexical : ISorter
    {
        public string sort(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                throw new InvalidArgumentException("Invalid input string, string is empty");
            }

            Dictionary<char, int> charDictionary = new Dictionary<char, int>();

            foreach (char character in input)
            {
                if (charDictionary.ContainsKey(character))
                {
                    charDictionary[character] += 1;
                }
                else
                {
                    charDictionary[character] = 1;
                }
            }

            var sortedDict = charDictionary
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(x => new string(x.Key, x.Value));

            string result = "";

            foreach (var item in sortedDict)
            {
                result += item;
            }

            return result;
        }
    }
}
