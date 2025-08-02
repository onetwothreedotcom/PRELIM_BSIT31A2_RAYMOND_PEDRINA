using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;
using System.Collections.Generic;
using WebApp.Models;

public class LibraryController : Controller
{
    private static List<Book> books = new List<Book>
    {
        new Book
        {
            Id = 1,
        Title = "The Hobbit",
        ISBN = "978-0261103344",
        Author = new Author { Id = 1, Name = "J.R.R. Tolkien" },
        Genre = new Genre { Id = 1, Name = "Fantasy" },
        IsAvailable = true,
        DatePublished = new DateTime(1937, 9, 21)  // NEW
    },
    new Book
    {
        Id = 2,
        Title = "1984",
        ISBN = "978-0451524935",
        Author = new Author { Id = 2, Name = "George Orwell" },
        Genre = new Genre { Id = 2, Name = "Dystopian" },
        IsAvailable = false,
        DatePublished = new DateTime(1949, 6, 8)  // NEW
    },
    // ... add DatePublished for all other books as well:
    new Book
    {
        Id = 3,
        Title = "To Kill a Mockingbird",
        ISBN = "978-0061120084",
        Author = new Author { Id = 3, Name = "Harper Lee" },
        Genre = new Genre { Id = 3, Name = "Classic" },
        IsAvailable = true,
        DatePublished = new DateTime(1960, 7, 11)
    },
    new Book
    {
        Id = 4,
        Title = "The Great Gatsby",
        ISBN = "978-0743273565",
        Author = new Author { Id = 4, Name = "F. Scott Fitzgerald" },
        Genre = new Genre { Id = 3, Name = "Classic" },
        IsAvailable = true,
        DatePublished = new DateTime(1925, 4, 10)
    },
    new Book
    {
        Id = 5,
        Title = "Brave New World",
        ISBN = "978-0060850524",
        Author = new Author { Id = 5, Name = "Aldous Huxley" },
        Genre = new Genre { Id = 2, Name = "Dystopian" },
        IsAvailable = false,
        DatePublished = new DateTime(1932, 1, 1)
    },
    new Book
    {
        Id = 6,
        Title = "Moby Dick",
        ISBN = "978-1503280786",
        Author = new Author { Id = 6, Name = "Herman Melville" },
        Genre = new Genre { Id = 4, Name = "Adventure" },
        IsAvailable = true,
        DatePublished = new DateTime(1851, 11, 14)
    },
    new Book
    {
        Id = 7,
        Title = "Pride and Prejudice",
        ISBN = "978-1503290563",
        Author = new Author { Id = 7, Name = "Jane Austen" },
        Genre = new Genre { Id = 5, Name = "Romance" },
        IsAvailable = true,
        DatePublished = new DateTime(1813, 1, 28)
    },
    new Book
    {
        Id = 8,
        Title = "The Catcher in the Rye",
        ISBN = "978-0316769488",
        Author = new Author { Id = 8, Name = "J.D. Salinger" },
        Genre = new Genre { Id = 3, Name = "Classic" },
        IsAvailable = false,
        DatePublished = new DateTime(1951, 7, 16)
    },
    new Book
    {
        Id = 9,
        Title = "Fahrenheit 451",
        ISBN = "978-1451673319",
        Author = new Author { Id = 9, Name = "Ray Bradbury" },
        Genre = new Genre { Id = 2, Name = "Dystopian" },
        IsAvailable = true,
        DatePublished = new DateTime(1953, 10, 19)
    },
    new Book
    {
        Id = 10,
        Title = "Jane Eyre",
        ISBN = "978-1503278196",
        Author = new Author { Id = 10, Name = "Charlotte Brontë" },
        Genre = new Genre { Id = 5, Name = "Romance" },
        IsAvailable = true,
        DatePublished = new DateTime(1847, 10, 16)
    }
    };


    private static List<User> users = new List<User>
{
    new User
    {
        Id = 1,
        Username = "user1",
        BorrowedBooks = new List<Borrow>
        {
            new Borrow
            {
                Book = books[0],
                DateBorrowed = new DateTime(2025, 2, 20),
                DateReturned = null
            },
            new Borrow
            {
                Book = books[1],
                DateBorrowed = new DateTime(2025, 2, 20),
                DateReturned = null
            }
        }
    },
    new User
    {
        Id = 2,
        Username = "user2",
        BorrowedBooks = new List<Borrow>
        {
            new Borrow
            {
                Book = books[2],
                DateBorrowed = new DateTime(2025, 2, 20),
                DateReturned = null
            },
            new Borrow
            {
                Book = books[3],
                DateBorrowed = new DateTime(2025, 2, 20),
                DateReturned = null
            },
            new Borrow
            {
                Book = books[4], // Brave New World
                DateBorrowed = new DateTime(2025, 2, 20),
                DateReturned = null
            }
        }
    }
};  // <-- add this semicolon here!


    public IActionResult Index()
    {
        return View(books);
    }

    public IActionResult UserBorrowedBooks()
    {
        return View(users); 
    }
}