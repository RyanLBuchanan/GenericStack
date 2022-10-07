namespace GenericStack
{

    class StackTest
    {
        // Create arrays of doubles and ints
        private static double[] doubleElements = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
        private static int[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        private static Stack<double> doubleStack;
        private static Stack<int> intStack;

        private static void Main(string[] args)
        {
            doubleStack = new Stack<double>(5);
            intStack = new Stack<int>(10);

            TestPushDouble();
            TestPopDouble();
            TestPushInt();
            TestPopInt();
        }

        // Test Push method with doubleStack
        private static void TestPushDouble()
        {
            try
            {
                Console.WriteLine("\nPushing elements onto doubleStack");

                // Push elements onto stack
                foreach (var element in doubleElements)
                {
                    Console.Write($"{element:F1} ");
                    doubleStack.Push(element);
                }
            }
            catch (FullStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.WriteLine();
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        // Test Pop method with doubleStack
        private static void TestPopDouble()
        {
            try
            {
                Console.WriteLine("\nPopping elements from doubleStack");

                double popValue; // Store element removed from stack

                // Remove all elements from stack
                while (true)
                {
                    popValue = doubleStack.Pop();
                    Console.Write($"{popValue:F1} ");
                }
            }
            catch (EmptyStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.WriteLine();
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        private static void TestPushInt()
        {
            try
            {
                Console.WriteLine("\nPushing elements onto intStack");

                // Push elements onto stack
                foreach (var element in intElements)
                {
                    Console.Write($"{element:F1} ");
                    intStack.Push(element);
                }
            }
            catch (FullStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.WriteLine();
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        // Test Pop method with doubleStack
        private static void TestPopInt()
        {
            try
            {
                Console.WriteLine("\nPopping elements from intStack");

                int popValue; // Store element removed from stack

                // Remove all elements from stack
                while (true)
                {
                    popValue = intStack.Pop();
                    Console.Write($"{popValue:F1} ");
                }
            }
            catch (EmptyStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.WriteLine();
                Console.Error.WriteLine(exception.StackTrace);
            }
        }
    }
}