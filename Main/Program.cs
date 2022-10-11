using InsperityLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace Insperity
{
    class Program
    {

        /// <summary>
        /// main app's entry point
        /// </summary>
        /// <param name="args"></param>
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
                //display error in console
                Console.WriteLine(ex.ToString());
                return;
            }

            //just for freeze the console in order to see the output
            Console.ReadLine();
        }

        static string sortStringFreqAndLexi(string str)
        {
            //logic instance
            ISorter sorter = new StringSorterByFrequencyAndLexical();

            //execute the sorting
            return sorter.sort(str);
        }
    }
}
