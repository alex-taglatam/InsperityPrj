using System;
using System.Collections.Generic;
using System.Text;

namespace InsperityLibrary
{
    /// <summary>
    /// Interface for sorting implementations
    /// </summary>
    public interface ISorter
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="input">String to be processed</param>
        /// <returns>String with string processed</returns>
        string sort(string input);
    }
}
