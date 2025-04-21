namespace SkalProj_Datastrukturer_Minne
{
    class IterationTask
    {
        public static void IterationTaskMethod()
        {
            Console.WriteLine("This is a test for the iteration task");
            while (true)
            {
                Console.WriteLine("Type a number");
                Console.WriteLine("Type 0 to exit to main menu.");
                string input = Console.ReadLine() ?? string.Empty;

                if (input == "0")
                {
                    return; // Exit to main menu
                }
                else if (int.TryParse(input, out int number))
                {
                    Console.WriteLine($"Result of IterativeOdd: {IterativeOdd(number)}");
                    Console.WriteLine($"Result of IterativeEven: {IterativeEven(number)}");
                    Console.WriteLine($"Result of IterativeFibonacci: {IterativeFibonacci(number)}");

                }

                // else if (int.TryParse(input, out int oddNumber) && oddNumber % 2 != 0) // Check if the number is odd
                // {
                //     Console.WriteLine($"Result of IterativeOdd: {IterativeOdd(oddNumber)}");
                //     Console.WriteLine($"Result of IterativeFibonacci: {IterativeFibonacci(oddNumber)}");
                // }
                // else if (int.TryParse(input, out int evenNumber) && evenNumber % 2 == 0) // Check if the number is even
                // {
                //     Console.WriteLine($"Result of IterativeEven: {IterativeEven(evenNumber)}");
                //     Console.WriteLine($"Result of IterativeFibonacci: {IterativeFibonacci(evenNumber)}");
                // }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            static int IterativeOdd(int n)
            {
                int result = 1;
                for (int i = 0; i < n - 1; i++)
                {
                    result += 2;
                }
                return result;
            }

            static int IterativeEven(int n)
            {
                int result = 2;
                for (int i = 0; i < n - 1; i++)
                {
                    result += 2;
                }
                return result;
            }


            static int IterativeFibonacci(int n)
            {
                if (n <= 1)
                {
                    return n;
                }

                int prev1 = 0;
                int prev2 = 1;
                int result = 0;

                for (int i = 2; i <= n; i++)
                {
                    result = prev1 + prev2;
                    prev1 = prev2;
                    prev2 = result;
                }
                return result;
            }

        }
    }
}