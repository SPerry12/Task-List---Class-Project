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

            WriteListToFile(tasks);
        }



        private void PrintTasks(List<string> tasks)
        {
            foreach (var t in tasks)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine();
        }

        st List<string> ReadListFromFile()
        {
            var tasks = new List<string>();

            using (StreamReader sr = new StreamReader(@"C: \Users\perry\OneDrive\Desktop\Task Project\TaskList.txt"))
            {
                var input = sr.ReadLine();
                tasks.Add(input);
            }

            return tasks;
        }

        static void WriteListToFile(List<string> tasks)
        {
            using (StreamWriter sw = new StreamWriter(@"C: \Users\perry\OneDrive\Desktop\Task Project\TaskList.txt"))
            {
                foreach (var t in tasks)
                {
                    sw.WriteLine(t);
                }
            }

        }
    }

}

