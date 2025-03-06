using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> groceryList = new List<string>();
        int choice;

        do
        {
            Console.WriteLine("GROCERY LIST");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. View Items");
            Console.WriteLine("3. Remove Item");
            Console.WriteLine("4. Clear List");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter item to add:");
                    string item = Console.ReadLine();
                    groceryList.Add(item);
                    Console.WriteLine(item + " has been added.");
                    break;

                case 2:
                    Console.WriteLine("Your Grocery List:");
                    if (groceryList.Count == 0)
                    {
                        Console.WriteLine("The list is empty.");
                    }
                    else
                    {
                        for (int i = 0; i < groceryList.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + groceryList[i]);
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter item number to remove:");
                    for (int i = 0; i < groceryList.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + groceryList[i]);
                    }

                    int removeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (removeIndex >= 0 && removeIndex < groceryList.Count)
                    {
                        Console.WriteLine(groceryList[removeIndex] + " removed.");
                        groceryList.RemoveAt(removeIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    break;

                case 4:
                    groceryList.Clear();
                    Console.WriteLine("Grocery list cleared.");
                    break;

                case 5:
                    Console.WriteLine("Exiting the program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }

            Console.WriteLine(); // Blank line for readability
        }
        while (choice != 5);
    }
}