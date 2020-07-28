using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Tracking_App_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Work on a task");
            Console.WriteLine("2. Complete a task");
            Console.WriteLine("3. Skip task");
            Console.WriteLine("4. New task");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");
            Console.Write("Select 1-5:");

            string choice = Console.ReadLine();
            List<string> tasks = new List<string>();
            tasks.ForEach(Console.WriteLine);


            switch (choice)
            {
                case "1":
                    Console.WriteLine("Test");
                    break;
                case "2":
                    Console.WriteLine("Test");
                    break;
                case "3":
                    Console.WriteLine("Test");
                    break;
                case "4":
                    var input = Console.ReadLine();
                    tasks.Add(input);
                    break;


            }


        }

      
    }
}
