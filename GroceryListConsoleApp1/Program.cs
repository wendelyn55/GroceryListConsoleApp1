using System;
using System.Collections.Generic;
using GroceryList.BusinessDataLogic;

public class GroceryListApp
{

    static List<string>
        groceryList = new List<string>
            ();

    static void Main()

    {
        int choice;
        do
        {
            ShowMenu();
            choice = GetNumber();
            HandleChoice(choice);
        } while (choice != 5);
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nGROCERY LIST:");
        Console.WriteLine("1. Add Item\n2. View Items\n3. Remove Item\n4. Clear List\n5. Exit");
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
                ShowList();
                break;
            case 3:
                RemoveItem();
                break;
            case 4:
                ClearList();
                break;
            case 5:
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
        string item = Console.ReadLine().Trim();
        if (!BusinessDataLogic.AddItem(item))
        {
            groceryList.Add(item);
            Console.WriteLine($"'{item}' added.");
        }
        else Console.WriteLine("Item cannot be empty.");
    }

    static void ShowList()
    {
        Console.WriteLine("\nYour Grocery List:");
        var items = BusinessDataLogic.GetItems();
        if (items.Count == 0)
        {
            Console.WriteLine("(Empty)");
        }
        else
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]}");
            }
        }
    }
    

    static void RemoveItem()
    {
        Console.Write("Enter item to remove: ");
        string itemToRemove = Console.ReadLine();

        if (BusinessDataLogic.RemoveItem(itemToRemove)) 
        {
            Console.WriteLine($"'{itemToRemove}' removed.");
        }
        else
        {
            Console.WriteLine($"'{itemToRemove}' is not in the list.");
        }
    }
}

    static void ClearList()
    {
        BusinessDataLogic.ClearList();
        Console.WriteLine("List cleared.");
    }
}