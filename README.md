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

## Part 3: Improve Code Quality and Efficiency
- Refactored the core variables into a clean `string[5]` array.
- Split the monolithic `Main` execution block into separate functions (`AddBook`, `RemoveBook`, `DisplayBooks`) to improve readability.
- Re-implemented the case-insensitivity on books by using `StringComparison.OrdinalIgnoreCase` properly without changing user-provided casing formats.

## Part 4: Grading Criteria Features
- **Search System**: Introduced `search` action for the user to query books.
- **Checked Out State**: Added boolean tracking mechanism to flag books as `[Checked Out]` vs `[Available]`.
- **Borrowing Limit**: Allowed `checkout` up to 3 books total across the application safely. Users must `checkin` a book to be able to borrow a 4th.
