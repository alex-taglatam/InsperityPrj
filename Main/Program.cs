using InsperityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Insperity
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            try
            {
                result = sortStringFreqAndLexi("alejandro");
                Console.WriteLine(result);
            }
            catch (InvalidArgumentException ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }

            Console.ReadLine();
        }

        static string sortStringFreqAndLexi(string str)
        {
            ISorter sorter = new StringSorterByFrequencyAndLexical();

            return sorter.sort(str);
        }
    }
}
