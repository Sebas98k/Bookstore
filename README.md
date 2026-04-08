# Library Management System
This repository contains the C# console application created during the Library Management System course.

## Part 1: Setup and Basic Features
In this part, we established the basic application structure using five string variables for book titles.
We implemented logic to:
- Add a book to the first empty slot.
- Error check if the library is full.
- Remove a book by matching its title and emptying the slot.
- Error check if the library is empty.
- Provide a constant loop for adding/removing/exiting.
- Print out the non-empty variables to show the available books.

## Part 2: Debugging
- Added `.ToLower()` string manipulation to the action variable to ensure that uppercase commands (like "ADD", "Remove") still function properly.
