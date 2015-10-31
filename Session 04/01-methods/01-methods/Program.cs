using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string choice = DisplayMenu();
                Process(choice);

                Console.ReadKey(true);
            }
        }

        static string DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. List Items");
            Console.WriteLine("3. Exit");
            return Console.ReadLine();
        }

        static void Process(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Adding a new item ...");
                    break;
                case "2":
                    Console.WriteLine("Listing all items ...");
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
