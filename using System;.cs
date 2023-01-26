using System;
using System.Collections.Generic;

class ToDoList
{
    static void Main(string[] args)
    {
        List<string> toDoList = new List<string>();

        while (true)
        {
            Console.WriteLine("1. Add item to list");
            Console.WriteLine("2. View list");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter item to add: ");
                string item = Console.ReadLine();
                toDoList.Add(item);
                Console.WriteLine("Item added to list");
            }
            else if (choice == 2)
            {
                Console.WriteLine("To-do list:");
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + toDoList[i]);
                }
            }
            else if (choice == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again");
            }
            Console.WriteLine();
        }
    }
}
