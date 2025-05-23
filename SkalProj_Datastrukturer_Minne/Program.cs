﻿using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 6, 7, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. Examine a Stack (Reverse text)"
                    + "\n5. CheckParenthesis"
                    + "\n6. Recursion Task"
                    + "\n7. Iteration Task"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList.ExamineListMethod();
                        break;
                    case '2':
                        ExamineQueue.ExamineQueueMethod();
                        break;
                    case '3':
                        ExamineStack.ExamineStackMethod();
                        break;
                    case '4':
                        ExamineStack.ReverseText();
                        break;
                    case '5':
                        CheckParanthesis.CheckParanthesisMethod();
                        break;
                    case '6':
                        RecursionTask.RecursionTaskMethod();
                        break;
                    case '7':
                        IterationTask.IterationTaskMethod();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6, 7)");
                        break;
                }
            }
        }


    }
}

