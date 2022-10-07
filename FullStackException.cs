using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    internal class FullStackException : Exception
    {
        public FullStackException() : base("Stack is full!")
        {
            // Empty constructor
        }

        public FullStackException(string exception) : base(exception)
        {
            // Empty constructor
        }

        public FullStackException(string exception, Exception inner) : base(exception, inner)
        {
            // Empty constructor
        }
    }
}
