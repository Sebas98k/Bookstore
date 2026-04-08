using System;

class LibraryManager
{
    static string[] books = new string[5];

    static void Main()
    {
        // Initialize the array with empty strings
        for (int i = 0; i < books.Length; i++)
        {
            books[i] = "";
        }

        while (true)
        {
            Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine()?.Trim().ToLower();

            if (action == "add")
            {
                AddBook();
            }
            else if (action == "remove")
            {
                RemoveBook();
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
            }

            DisplayBooks();
        }
    }

    static void AddBook()
    {
        if (IsLibraryFull())
        {
            Console.WriteLine("The library is full. No more books can be added.");
            return;
        }

        Console.WriteLine("Enter the title of the book to add:");
        string newBook = Console.ReadLine()?.Trim() ?? "";

        for (int i = 0; i < books.Length; i++)
        {
            if (string.IsNullOrEmpty(books[i]))
            {
                books[i] = newBook;
                break;
            }
        }
    }

    static void RemoveBook()
    {
        if (IsLibraryEmpty())
        {
            Console.WriteLine("The library is empty. No books to remove.");
            return;
        }

        Console.WriteLine("Enter the title of the book to remove:");
        // Comparing with OrdinalIgnoreCase guarantees books are found properly
        string removeBook = Console.ReadLine()?.Trim() ?? "";

        bool found = false;
        for (int i = 0; i < books.Length; i++)
        {
            if (string.Equals(books[i], removeBook, StringComparison.OrdinalIgnoreCase))
            {
                books[i] = "";
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Book not found.");
        }
    }

    static void DisplayBooks()
    {
        Console.WriteLine("Available books:");
        foreach (string book in books)
        {
            if (!string.IsNullOrEmpty(book))
            {
                Console.WriteLine(book);
            }
        }
        Console.WriteLine();
    }

    static bool IsLibraryFull()
    {
        foreach (string book in books)
        {
            if (string.IsNullOrEmpty(book)) return false;
        }
        return true;
    }

    static bool IsLibraryEmpty()
    {
        foreach (string book in books)
        {
            if (!string.IsNullOrEmpty(book)) return false;
        }
        return true;
    }
}
