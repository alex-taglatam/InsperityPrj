using System;
using System.Collections.Generic;
using System.Text;

namespace InsperityLibrary
{
    public class InvalidArgumentException : Exception
    {
        public InvalidArgumentException(string message):base(message)
        {

        }

        public override string ToString()
        {
            return "Error: " + this.Message;
        }
    }
}
