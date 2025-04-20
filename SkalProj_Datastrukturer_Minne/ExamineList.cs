
namespace SkalProj_Datastrukturer_Minne
{
    class ExamineList
    {
        /// <summary>
        /// 1. The class ExamineList contains methods to add, remove, and display elements in a list, as well as to show the list's count and capacity.
        /// 2. The list's capacity increases when the number of elements exceeds the current capacity.
        /// 3. The capacity typically doubles each time it increases: 4 - 8 - 16...
        /// 4. The list's capacity increases only when the number of elements exceeds the current capacity.
        /// 5. No, the capacity of a list does not decrease when elements are removed.
        /// 6. It is better to use an array instead of a list when the number of elements is known and fixed and you want to save memory.
        /// </summary>

        public static void ExamineListMethod() //ExamineListMethod() provides an interactive menu where the user can add or remove elements from a list.
        {

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            Console.WriteLine("Welcome to the List examination program!");
            List<string> theList = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a command (+ to add, - to remove) followed by a value (e.g., +Olena or -Olena).");
                Console.WriteLine("Type 0 to exit to the main menu.");
                string input = Console.ReadLine() ?? string.Empty;
                char nav = input[0];
                string value = input.Length > 1 ? input.Substring(1).Trim() : string.Empty;

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                switch (nav)
                {
                    case '+':
                        AddInputsToList(theList, value);
                        break;
                    case '-':
                        RemoveInputsFromList(theList, value);
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter a valid input (+ or -)");
                        break;
                }
            }

            static void AddInputsToList(List<string> list, string value) //This method adds a value to the list if it is not null or empty.
            {
                if (!string.IsNullOrEmpty(value))
                {
                    list.Add(value);
                }
                else
                {
                    Console.WriteLine("Please enter a valid value to add.");
                }
                PrintList(list);
                PrintCountAndCapacity(list);
            }


            static void RemoveInputsFromList(List<string> list, string value) //This method removes a value from the list if it exists.
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter a valid value to remove.");
                    return;
                }
                {
                    if (list.Contains(value))
                    {
                        list.Remove(value);
                    }
                    else
                    {
                        Console.WriteLine("Value not found in the list.");
                    }
                    PrintList(list);
                    PrintCountAndCapacity(list);
                }
            }

            static void PrintList(List<string> list) //Prints the current elements in the list.
            {
                Console.WriteLine("Current List: ");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            static void PrintCountAndCapacity(List<string> list) //Displays the current count and capacity of the list.
            {
                Console.WriteLine($"Count: {list.Count}");
                Console.WriteLine($"Capacity: {list.Capacity}");
            }


        }
    }
}