# Grading Criteria 
There are a total of 15 points for this project. 

(5pts) Did you add a search feature to the library management system application? For full credit, make sure to:

Prompt the user to input a book title to search for.

If the book is found, display a message indicating it is available.

If the book is not found, display a message that it’s not in the collection.

(5pts) Did you add a borrowing limit feature to the library management system application? For full credit, make sure to:

Add a feature that tracks how many books a user has borrowed.

Limit the number of books to 3 at a time.

(5pts) Did you add a feature that flags a book as checked out? For full credit, make sure to:

Add a feature that flags a book as checked out

If the book is checked out, remove the checked-out flag to check the book in

# Part 1: Write C# code using microsoft copilot
Objective:

You will create a simple library management system that stores up to five book titles using string variables. The system will allow users to add new books, remove a book, and display the list of available books.

Problem Statement:

Imagine you're a librarian managing a small collection of five books. You need a program that allows you to:

Add books to the collection.

Remove a book by its title.

Display the current list of books available in the library.

With the help of Microsoft Copilot, you will build this program using string variables, conditional statements, and loops.

Steps

Create a C# console application that manages a small library of books. The program should:

1. Create Variables for Books:

   Set up five string variables to store the book titles.

2. Add a Book:

   Prompt the user to input a book title.

   Check which book variable is empty and store the new book in that variable.

   If all book slots are full, inform the user that no more books can be added.

3. Remove a Book:

   Ask the user to input the title of the book they want to remove.

   Check if the title exists in the collection and, if found, clear the corresponding variable.

4. Display the List of Books:

   Print out the list of books currently in the library, showing only the non-empty book slots.

5. Loop Indefinitely:

   Continuously prompt the user to choose whether they want to add or remove a book, or exit the program.

   If the user chooses to exit, break the loop and end the program.

6. Handle Invalid Inputs:

   If the user enters an invalid action (neither "add" nor "remove"), inform them and prompt again.

7. Conditional Actions:

   Only allow adding books if there are empty slots.

   Only allow removing books if there are books in the library.

When completed, save your code. You will use this code to complete the final project in this course. 

# Part 2: Debug c# code using microsoft copilot
Problem Statement

The Library Management System you created earlier works well, but the following version of the code has some errors that need to be fixed. These errors prevent the program from correctly adding, removing, and displaying books. Use Microsoft Copilot to help debug the program.

class LibraryManager
{
    static void Main()
    {
        string book1 = "";
        string book2 = "";
        string book3 = "";
        string book4 = "";
        string book5 = "";

        while (true)
        {
            Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine();

            if (action == "add")
            {
                Console.WriteLine("Enter the title of the book to add:");
                string newBook = Console.ReadLine();

                if (string.IsNullOrEmpty(book1))
                {
                    book1 = newBook;
                }
                else if (string.IsNullOrEmpty(book2))
                {
                    book2 = newBook;
                }
                else if (string.IsNullOrEmpty(book3))
                {
                    book3 = newBook;
                }
                else if (string.IsNullOrEmpty(book4))
                {
                    book4 = newBook;
                }
                else if (string.IsNullOrEmpty(book5))
                {
                    book5 = newBook;
                }
                else
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                }
            }
            else if (action == "remove")
            {
                Console.WriteLine("Enter the title of the book to remove:");
                string removeBook = Console.ReadLine();

                if (removeBook == book1)
                {
                    book1 = "";
                }
                else if (removeBook == book2)
                {
                    book2 = "";
                }
                else if (removeBook == book3)
                {
                    book3 = "";
                }
                else if (removeBook == book4)
                {
                    book4 = "";
                }
                else if (removeBook == book5)
                {
                    book5 = "";
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
            }

            // Display the list of books
            Console.WriteLine("Available books:");
            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
            Console.WriteLine(book4);
            Console.WriteLine(book5);
        }
    }
}

Steps to Complete the Task
Identify the ErrorsUse the Visual Studio Code console application you created at the start of the course. Remove any existing code in the Program.cs file of your console application and create all the code in each step in that file. Run the Starting Code with Errors code and observe the issues:

Adding books without checking if the library is full first. This can lead to books being added even when the library is full, causing confusion.

Not checking for null or empty strings when displaying books: This can result in empty lines being printed, which can be confusing for the user.

The action variable comparison will only work if the user types a string with all lowercase letters. For example, if the user types “Add” the program will interpret this as an invalid command.

Use Copilot to Debug

Use Microsoft Copilot to identify and suggest fixes for the errors.

Apply the necessary corrections to ensure the program works as intended.

Test the Debugged Program

After making the necessary corrections, test the program by adding, removing, and displaying books.

# Part 3: Improve code quality and efficiency using microsoft copilot
Problem Statement

The Library Management System works, but it could be optimized. Use Microsoft Copilot to enhance the code's readability, reduce repetition, and make it more efficient. You will:

Remove code duplication

Improve input validation

Address case sensitivity issues for entering and removing books

class LibraryManager
{
    static void Main()
    {
        string book1 = "";
        string book2 = "";
        string book3 = "";
        string book4 = "";
        string book5 = "";
        while (true)
        {
            Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine().ToLower();
            if (action == "add")
            {
                if (!string.IsNullOrEmpty(book1) && !string.IsNullOrEmpty(book2) && !string.IsNullOrEmpty(book3) && !string.IsNullOrEmpty(book4) && !string.IsNullOrEmpty(book5))
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to add:");
                    string newBook = Console.ReadLine();
                    if (string.IsNullOrEmpty(book1))
                    {
                        book1 = newBook;
                    }
                    else if (string.IsNullOrEmpty(book2))
                    {
                        book2 = newBook;
                    }
                    else if (string.IsNullOrEmpty(book3))
                    {
                        book3 = newBook;
                    }
                    else if (string.IsNullOrEmpty(book4))
                    {
                        book4 = newBook;
                    }
                    else if (string.IsNullOrEmpty(book5))
                    {
                        book5 = newBook;
                    }
                }
            }
            else if (action == "remove")
            {
                if (string.IsNullOrEmpty(book1) && string.IsNullOrEmpty(book2) && string.IsNullOrEmpty(book3) && string.IsNullOrEmpty(book4) && string.IsNullOrEmpty(book5))
                {
                    Console.WriteLine("The library is empty. No books to remove.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to remove:");
                    string removeBook = Console.ReadLine();
                    if (removeBook == book1)
                    {
                        book1 = "";
                    }
                    else if (removeBook == book2)
                    {
                        book2 = "";
                    }
                    else if (removeBook == book3)
                    {
                        book3 = "";
                    }
                    else if (removeBook == book4)
                    {
                        book4 = "";
                    }
                    else if (removeBook == book5)
                    {
                        book5 = "";
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
            }
            // Display the list of books
            Console.WriteLine("Available books:");
            if (!string.IsNullOrEmpty(book1)) Console.WriteLine(book1);
            if (!string.IsNullOrEmpty(book2)) Console.WriteLine(book2);
            if (!string.IsNullOrEmpty(book3)) Console.WriteLine(book3);
            if (!string.IsNullOrEmpty(book4)) Console.WriteLine(book4);
            if (!string.IsNullOrEmpty(book5)) Console.WriteLine(book5);

Steps to Improve Code Quality
Run the Program to Test Functionality

Use the Visual Studio Code console application you created at the start of the course. Remove any existing code in the Program.cs file of your console application and run the code Starting Code to Input into Copilot in that file.

Verify the functionality of the application.

Use Copilot to Suggest Improvements

Use Microsoft Copilot to suggest ways to reduce code repetition and improve readability.

For example, Copilot might suggest using a method to handle repetitive tasks like adding or removing books.

Simplify the Code

Simplify the program using the suggestions provided by Copilot. This could include creating helper methods, improving variable names, and adding comments to clarify the code’s functionality.

Test the Simplified Program

Use the Visual Studio Code console application you created at the start of the course. Remove any existing code in the Program.cs file of your console application and add all the updated code in that file. 

Run the program after refactoring to ensure that it functions the same way, but with cleaner and more efficient code.

# Part 4: Practice solving coding challenges using microsoft copilot
Objective:

You will use Microsoft Copilot to extend the Library Management System by solving new challenges, such as searching for a book or limiting the number of books that can be borrowed. You should use the code you’ve already optimized in the previous “You Try It!” activity to complete this activity. At the end of this course, you’ll submit this code as your final project. 

Problem Statement:

The Library Management System works well, but it can be extended to solve new problems. You need to add the following features:

Search for a book by its title.

Limit the number of books a user can borrow at once.

With Microsoft Copilot, you will solve these new challenges and extend the functionality of the system.

Steps

Add a Search Feature

Prompt the user to input a book title to search for.

If the book is found, display a message indicating it is available.

If the book is not found, display a message that it’s not in the collection.

Limit Borrowing

Add a feature that tracks how many books a user has borrowed.

Limit the number of books to 3 at a time.

Check-in a borrowed book

Add a feature that enables the user to check in a book that’s been checked out.

Check If the book is checked out. If it is remove the checked-out flag to check the book in. If it isn’t, inform the user.

Test the New Features 

Run the program and test the search and borrowing limit functionalities with different inputs.