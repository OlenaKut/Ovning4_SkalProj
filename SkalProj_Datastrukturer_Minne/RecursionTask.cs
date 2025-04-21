namespace SkalProj_Datastrukturer_Minne
{
    class RecursionTask
    {

        public static void RecursionTaskMethod()
        {
            Console.WriteLine("This is a test for the recursion task");
            while (true)
            {
                Console.WriteLine("Type a number");
                Console.WriteLine("Type 0 to exit to main menu.");
                string input = Console.ReadLine() ?? string.Empty;

                if (input == "0")
                {
                    return; // Exit to main menu
                }
                else if (int.TryParse(input, out int oddNumber) && oddNumber % 2 != 0) // Check if the number is odd
                {
                    Console.WriteLine($"Result of RecursiveOdd: {RecursiveOdd(oddNumber)}");
                    Console.WriteLine($"Result of FibonacciSequence: {FibonacciSequence(oddNumber)}");
                }
                else if (int.TryParse(input, out int evenNumber) && evenNumber % 2 == 0) // Check if the number is even
                {
                    Console.WriteLine($"Result of RecursiveEven: {RecursiveEven(evenNumber)}");
                    Console.WriteLine($"Result of FibonacciSequence: {FibonacciSequence(evenNumber)}");
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            static int RecursiveOdd(int n) //The RecursiveOdd method calculates the nth odd number using recursion.
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return RecursiveOdd(n - 2) + 2;
                }
            }

            static int RecursiveEven(int n) //The RecursiveEven method calculates the nth even number using recursion.
            {
                if (n == 1)
                {
                    return 2;
                }
                else
                {
                    return RecursiveEven(n - 1) + 2;
                }
            }


            static int FibonacciSequence(int n) //The FibonacciSequence method calculates the nth Fibonacci number using recursion.
            {
                if (n <= 1)
                {
                    return n;
                }
                else
                {
                    return FibonacciSequence(n - 1) + FibonacciSequence(n - 2);
                }
            }
        }
    }
}