using System;

class LibraryManager
{
    static string[] books = new string[5];
    static bool[] isCheckedOut = new bool[5];
    static int borrowedCount = 0;

    static void Main()
    {
        // Initialize the array with empty strings
        for (int i = 0; i < books.Length; i++)
        {
            books[i] = "";
            isCheckedOut[i] = false;
        }

        while (true)
        {
            Console.WriteLine("Would you like to add, remove, search, checkout, checkin a book, or exit?");
            Console.WriteLine("(add/remove/search/checkout/checkin/exit)");
            string action = Console.ReadLine()?.Trim().ToLower();

            if (action == "add")
            {
                AddBook();
            }
            else if (action == "remove")
            {
                RemoveBook();
            }
            else if (action == "search")
            {
                SearchBook();
            }
            else if (action == "checkout")
            {
                CheckoutBook();
            }
            else if (action == "checkin")
            {
                CheckinBook();
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type one of the valid commands.");
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
                isCheckedOut[i] = false;
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
        string removeBook = Console.ReadLine()?.Trim() ?? "";

        bool found = false;
        for (int i = 0; i < books.Length; i++)
        {
            if (string.Equals(books[i], removeBook, StringComparison.OrdinalIgnoreCase))
            {
                // Note: If the removed book was checked out, decrement borrowedCount (defensive programming)
                if (isCheckedOut[i])
                {
                    borrowedCount--;
                }
                books[i] = "";
                isCheckedOut[i] = false;
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Book not found.");
        }
    }

    static void SearchBook()
    {
        Console.WriteLine("Enter the title of the book to search for:");
        string searchTitle = Console.ReadLine()?.Trim() ?? "";

        bool found = false;
        for (int i = 0; i < books.Length; i++)
        {
            if (string.Equals(books[i], searchTitle, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                if (isCheckedOut[i])
                {
                    Console.WriteLine($"The book '{books[i]}' is in the collection, but it is currently checked out.");
                }
                else
                {
                    Console.WriteLine($"The book '{books[i]}' is available in the library.");
                }
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("The book is not in the collection.");
        }
    }

    static void CheckoutBook()
    {
        if (borrowedCount >= 3)
        {
            Console.WriteLine("You have reached your borrowing limit of 3 books. Please check in a book first.");
            return;
        }

        Console.WriteLine("Enter the title of the book to check out:");
        string checkoutTitle = Console.ReadLine()?.Trim() ?? "";

        bool found = false;
        for (int i = 0; i < books.Length; i++)
        {
            if (string.Equals(books[i], checkoutTitle, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                if (!isCheckedOut[i])
                {
                    isCheckedOut[i] = true;
                    borrowedCount++;
                    Console.WriteLine($"You have successfully checked out '{books[i]}'. You have borrowed {borrowedCount}/3 books.");
                }
                else
                {
                    Console.WriteLine("This book is already checked out.");
                }
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Book not found.");
        }
    }

    static void CheckinBook()
    {
        Console.WriteLine("Enter the title of the book to check in:");
        string checkinTitle = Console.ReadLine()?.Trim() ?? "";

        bool found = false;
        for (int i = 0; i < books.Length; i++)
        {
            if (string.Equals(books[i], checkinTitle, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                if (isCheckedOut[i])
                {
                    isCheckedOut[i] = false;
                    borrowedCount--;
                    Console.WriteLine($"You have successfully checked in '{books[i]}'.");
                }
                else
                {
                    Console.WriteLine("This book is already checked in.");
                }
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
        Console.WriteLine("Available and Checked Out books:");
        foreach (var i in System.Linq.Enumerable.Range(0, books.Length))
        {
            if (!string.IsNullOrEmpty(books[i]))
            {
                string status = isCheckedOut[i] ? "Checked Out" : "Available";
                Console.WriteLine($"- {books[i]} [{status}]");
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
