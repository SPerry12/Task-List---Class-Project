using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Threading.Tasks;

namespace Tracking_App_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            DefaultMenu();

            string exit = Console.ReadLine();

            do
            {
                switch (exit)
                {
                    case "1":
                        ActionItem();
                        break;
                    case "2":
                        CrossOut();
                        break;
                    case "3":
                        Skip();
                        break;
                    case "4":
                        NewTask();
                        break;
                    default:
                        {
                           Console.WriteLine("Please enter 1-4 to complete an action or press 0 to exit.");
                            break;
                        }
                }
            }while (VariantType )

            Console.Clear();
            DefaultMenu();
            exit = Console.ReadLine();

        }

        static void DefaultMenu()
        {
            Console.WriteLine("1. Work on a task");
            Console.WriteLine("2. Complete a task");
            Console.WriteLine("3. Skip task");
            Console.WriteLine("4. New task");
            Console.WriteLine("");
            Console.Write("Enter your selection:");
        }

        private static void NewTask()
        {
            Console.WriteLine("Test");
        }

        private static void Skip()
        {
            Console.WriteLine("Test");
        }

        private static void CrossOut()
        {
            Console.WriteLine("Test");
        }

        static void ActionItem()
        {
            Console.Clear();

            Console.WriteLine("1. Complete task");
            Console.WriteLine("2. Incomplete");
            Console.WriteLine("3. Enter a new task");
            Console.WriteLine("4. Main Menu");
            Console.WriteLine("");

            Console.Write("Select the action you would like to complete:");

            string choice = Console.ReadLine();
            do
            {

                var quit = false;

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("1. Complete");
                        break;
                    case "2":
                        Console.WriteLine("2. Incomplete");
                        break;
                    case "3":
                        Console.WriteLine("3. Enter a new task");
                        
                       
                        break;
                    case "4":
                        Console.WriteLine("4. Main Menu");
                        //Console.Clear();
                        DefaultMenu();
                        break;

                    default:
                        {
                            Console.WriteLine("Please enter a number 1-3");
                            Console.Clear();
                            ActionItem();
                            break;
                        }

                }

            } while (choice != "0");

        }

        private static void AddTasks(List<string> tasks)
        {
            Console.Write("Add task: ");
            var input = Console.ReadLine();
            tasks.Add(input);
        }

        public void Run()
        {
            List<string> tasks = ReadListFromFile();
            PrintTasks(tasks);

            do
            {

                PrintTasks(tasks);
                AddTasks(tasks);

            } while (true);
        }

        private void PrintTasks(List<string> tasks)
        {
            foreach (var t in tasks)
            {
                Console.WriteLine(tasks);
            }
        }

        private List<string> ReadListFromFile()
        {
            var tasks = new List<string>();

            using (StreamReader sr = new StreamReader(@"C: \Users\perry\OneDrive\Desktop\Task Project\TaskList.txt"))
            {
                var input = sr.ReadLine();
                tasks.Add(input);
            }

            return tasks;
        }
    }
}
