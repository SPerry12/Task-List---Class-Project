using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Threading.Tasks;

namespace Tracking_App_2._0
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            List<string> taskList = ReadListFromFile();
            PrintTaskList(taskList);

            var quit = false;

            do
            {
                PrintTaskList(taskList);
                InputTaskToList(taskList);
            } while (!quit);
        }

        private static void InputTaskToList(List<string> taskList)
        {
            Console.WriteLine("Add a new task: ");

            var input = Console.ReadLine();
            taskList.Add(input);
        }

        private static void PrintTaskList(List<string> taskList)
        {
            foreach (var t in taskList)
            {
                Console.WriteLine(t);
            }
        }

        private static List<string> ReadListFromFile()
        {
            var taskList = new List<string>();


            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\perry\OneDrive\Desktop\Task Project\Task Project.txt"))
                {
                    var input = sr.ReadLine();
                    taskList.Add(input);
                }

               
            }
            catch (FileNotFoundException)
            { ; }

            return taskList;

        }
    }

}

