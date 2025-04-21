namespace SkalProj_Datastrukturer_Minne
{

    /// <summary>
    /// Examines the datastructure Stack
    /// Why a Stack is not a good choice for this task: a stack serves the last person who joined first, which is the opposite of how a queue works in real life (FIFO: First In, First Out).
    /// </summary>
    class ExamineStack()
    {
        public static void ExamineStackMethod()
        {
            Stack<string> stack = new Stack<string>();
            Console.WriteLine("Welcome to ICA!");
            Console.WriteLine("If you want to stay in the queue, type +Your Name. If you want to leave the queue, type -. And type 0 to exit to main menu.");

            while (true)
            {
                Console.WriteLine("\nCurrent Stack: " + string.Join(", ", stack));
                Console.Write("Enter command: ");
                string input = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                char command = input[0];
                string value = input.Length > 1 ? input.Substring(1).Trim() : string.Empty;

                switch (command)
                {
                    case '+': // Adds a name to the stack
                        if (!string.IsNullOrEmpty(value))
                        {
                            stack.Push(value);
                            Console.WriteLine($"{value} has joined the queue.");
                        }
                        else
                        {
                            Console.WriteLine("Please provide a name.");
                        }
                        break;

                    case '-': // Deletes a name from the stack
                        if (stack.Count > 0)
                        {
                            string remove = stack.Pop();
                            Console.WriteLine($"{remove} has been served and left the queue.");
                        }
                        else
                        {
                            Console.WriteLine("The queue is empty. No one to remove.");
                        }
                        break;

                    case '0': // Exit to main menu
                        return;

                    default:
                        Console.WriteLine("Invalid command. Use +Name to join, - to remove, or 0 to exit.");
                        break;
                }
            }
        }

        public static void ReverseText() // This method reverses a string using a stack. It takes a string input from the user, pushes each character onto a stack, and then pops them off to create the reversed string.
        {
            while (true)
            {
                Console.WriteLine("Enter a string to reverse:");
                Console.WriteLine("Type 0 to exit to main menu.");
                string input = Console.ReadLine() ?? string.Empty;
                if (input == "0")
                {
                    return; // Exit to main menu
                }
                else
                {
                    Stack<char> stack = new Stack<char>();

                    // Push each character of the string onto the stack
                    foreach (char c in input)
                    {
                        stack.Push(c);
                    }

                    // Pop characters from the stack to reverse the string
                    string reversed = string.Empty;
                    while (stack.Count > 0)
                    {
                        reversed += stack.Pop();
                    }

                    Console.WriteLine($"Reversed string: {reversed}");
                }
            }
        }
    }
}