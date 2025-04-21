namespace SkalProj_Datastrukturer_Minne
{
    class CheckParanthesis
    {
        public static void CheckParanthesisMethod()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            //To check if a string is well-formed with balanced parentheses, brackets, and braces, we use a stack. 
            //A stack is ideal because it follows the LIFO (Last In, First Out) principle, allowing us to match closing symbols with the most recent opening symbol.

            while (true)
            {
                Console.WriteLine("Enter a string with the parentheses:");
                Console.WriteLine("Type 0 to exit to main menu.");
                string input = Console.ReadLine() ?? string.Empty;
                if (input == "0")
                {
                    return; // Exit to main menu
                }

                if (IsWellFormed(input))
                {
                    Console.WriteLine("The parentheses are well-formed.");
                }
                else
                {
                    Console.WriteLine("The parentheses are not well-formed.");
                }

            }
        }

        private static bool IsWellFormed(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                // Push opening brackets onto the stack
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                // Check closing brackets
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false; // No matching opening bracket
                    }

                    char last = stack.Pop();
                    if ((c == ')' && last != '(') ||
                        (c == '}' && last != '{') ||
                        (c == ']' && last != '['))
                    {
                        return false; // Mismatched brackets
                    }
                }
            }

            // If the stack is empty, all brackets were matched
            return stack.Count == 0;
        }
    }
}

