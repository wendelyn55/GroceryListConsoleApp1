using System;
using System.Collections.Generic;

class GroceryListApp
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
            case 1: AddItem(); break;
            case 2: ShowList(); break;
            case 3: RemoveItem(); break;
            case 4: ClearList(); break;
            case 5: Console.WriteLine("Goodbye!"); break;
            default: Console.WriteLine("Invalid choice. Try again."); break;
        }
    }

    static void AddItem()
    {
        Console.Write("Enter item: ");
        string item = Console.ReadLine().Trim();
        if (!string.IsNullOrEmpty(item))
        {
            groceryList.Add(item);
            Console.WriteLine($"'{item}' added.");
        }
        else Console.WriteLine("Item cannot be empty.");
    }

    static void ShowList()
    {
        Console.WriteLine("\nYour Grocery List:");
        if (groceryList.Count == 0) Console.WriteLine("(Empty)");
        else for (int i = 0; i < groceryList.Count; i++) Console.WriteLine($"{i + 1}. {groceryList[i]}");
    }

    static void RemoveItem()
    {
        if (groceryList.Count == 0) { Console.WriteLine("List is empty."); return; }
        ShowList();
        int index = GetNumber() - 1;
        if (index >= 0 && index < groceryList.Count)
        {
            Console.WriteLine($"'{groceryList[index]}' removed.");
            groceryList.RemoveAt(index);
        }
        else Console.WriteLine("Invalid number.");
    }

    static void ClearList()
    {
        groceryList.Clear();
        Console.WriteLine("List cleared.");
    }
}