namespace SkalProj_Datastrukturer_Minne
{
    class ExamineQueue
    {
        /// <summary>
        /// Examines the datastructure Queue
        /// This method examines the Queue data structure.
        /// It allows the user to enqueue and dequeue items interactively.
        /// </summary>
        public static void ExamineQueueMethod() // ExamineQueueMethod() provides an interactive menu where the user can add or remove elements from a queue.
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<string> queue = new Queue<string>();
            Console.WriteLine("Welcome to ICA!");
            Console.WriteLine("If you want to stay in the queue, type +Your Name. If you want to leave the queue, type -. And type 0 to exit to main menu.");

            while (true)
            {
                Console.WriteLine("\nCurrent Queue: " + string.Join(", ", queue));
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
                    case '+': // Adds a name to the queue
                        if (!string.IsNullOrEmpty(value))
                        {
                            queue.Enqueue(value);
                            Console.WriteLine($"{value} has joined the queue.");
                        }
                        else
                        {
                            Console.WriteLine("Please provide a name to enqueue.");
                        }
                        break;

                    case '-': // Deletes a name from the queue
                        if (queue.Count > 0)
                        {
                            string dequeued = queue.Dequeue();
                            Console.WriteLine($"{dequeued} has been served and left the queue.");
                        }
                        else
                        {
                            Console.WriteLine("The queue is empty. No one to dequeue.");
                        }
                        break;

                    case '0': // Exit to main menu
                        return;

                    default:
                        Console.WriteLine("Invalid command. Use +Name to enqueue, - to dequeue, or 0 to exit.");
                        break;
                }
            }
        }
    }
}