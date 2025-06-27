using System;
using GroceryListBusinessLogic;

namespace GroceryListConsoleApp
{

    public class Program
    {
        public static GroceryListService groceryService = new GroceryListService();

        public static void Main()
        {
            int choice;
            do
            {
                ShowMenu();
                choice = GetNumber();
                HandleChoice(choice);
            } while (choice != 4);
        }

        static void ShowMenu()
        {
            Console.WriteLine("\nGROCERY LIST:");
            Console.WriteLine("1. Add Item\n2. Remove Item\n3. Clear List\n4. Exit");
        }

        static int GetNumber()
        {
            while (true)
            {
                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out int number)) return number;
                Console.WriteLine("Invalid input. Enter a number.");
            }
        }

        static void HandleChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddItem();
                    break;
                case 2:
                    RemoveItem();
                    break;
                case 3:
                    ClearList();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }

        static void AddItem()
        {
            Console.Write("Enter item: ");
            string item = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(item))
            {
                Console.WriteLine("Item cannot be empty.");
                return;
            }

            if (groceryService.AddItem(item))
            {
                Console.WriteLine($"'{item}' added.");
            }
            else
            {
                Console.WriteLine($"'{item}' already exists.");
            }
        }

        static void RemoveItem()
        {
            Console.Write("Enter item to remove: ");
            string itemToRemove = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(itemToRemove))
            {
                Console.WriteLine("Item cannot be empty.");
                return;
            }

            if (groceryService.RemoveItem(itemToRemove))
            {
                Console.WriteLine($"'{itemToRemove}' removed.");
            }
            else
            {
                Console.WriteLine($"'{itemToRemove}' is not in the list.");
            }
        }

        static void ClearList()
        {
            groceryService.ClearList();
            Console.WriteLine("List cleared.");
        }
    }
}