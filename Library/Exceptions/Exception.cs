using System;
using System.Collections.Generic;
using System.Text;

namespace InsperityLibrary
{
    /// <summary>
    /// Exception class representing an invalid input argument
    /// </summary>
    public class InvalidArgumentException : Exception
    {
        /// <summary>
        /// Constructor with custom message
        /// </summary>
        /// <param name="message">String representing the error</param>
        public InvalidArgumentException(string message):base(message)
        {

        }

        /// <summary>
        /// Generate a string of the error
        /// </summary>
        /// <returns>string representing the error</returns>
        public override string ToString()
        {
            return "Error: " + this.Message;
        }
    }
}
