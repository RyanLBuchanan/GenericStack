using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    public class Stack<T>
    {
        private int top; // Location of the top element
        private T[] elements; // Array that stores the stack of elements

        // Parameterless constructor creates a stack of the default size
        public Stack() : this(10) // Default stack size
        {
            // Empty constructor; calls constructor at line 18 to perform initialization
        }

        // Constructor creates a stack of the specified number of elements
        public Stack(int stackSize)
        {
            if (stackSize <= 0)
            {
                throw new ArgumentException("Stack size must be positive.");
            }

            elements = new T[stackSize]; // Create stackSIze elements
            top = -1; // Stack initially empty 
        }

        // Push element onto the stack; if unsuccessful, throw FullStackException
        public void Push(T pushValue)
        {
            if (top == elements.Length - 1) // Stack is full
            {
                throw new FullStackException($"Stack is full, cannot push anymore {pushValue}s, CAPTAIN!!!");
            }

            ++top; // Increment top 
            elements[top] = pushValue; // Place pushValue on stack
        }

        // Return the top element if not empty
        // Else throw EmptyStackException
        public T Pop()
        {
            if (top == -1) // Stack is empty
            {
                throw new EmptyStackException("Stack is empty, can't pop a damn thing, bitches!");
            }

            --top;  // Decrement top
            return elements[top + 1];  // top value 
        }
    }
}
