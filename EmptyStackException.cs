using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    internal class EmptyStackException : Exception
    {
        public EmptyStackException() : base("Stack is empty and dry as a bone, mutherfisha!")
        {
            // Empty constructor
        }

        public EmptyStackException(string exception) : base(exception)
        {
            // Empty constructor
        }

        public EmptyStackException(string exception, Exception inner) : base(exception, inner)
        {
            // Empty constructor
        }
    }
}
