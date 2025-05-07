using System;
using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem
{
    // Book class implementing IComparable
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public int Pages { get; set; }

        public Book(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            YearPublished = year;
            Pages = pages;
        }

        // Natural ordering: Title ascending
        public int CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            return $"{Title,-30} by {Author,-20} | {YearPublished} | {Pages} pages";
        }
    }

    // Custom comparers
    public class YearComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.YearPublished.CompareTo(y.YearPublished);
        }
    }

    public class PagesComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return y.Pages.CompareTo(x.Pages); // Descending
        }
    }

    public class AuthorComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Author.CompareTo(y.Author);
        }
    }

    // Main application
    class Program
    {
        static List<Book> books = new List<Book>();

        static void Main(string[] args)
        {
            InitializeLibrary();

            bool running = true;
            while (running)
            {
                Console.Clear();
                PrintMenu();
                Console.Write("\nChoose an option: ");
                string choice = Console.ReadLine()?.ToLower();

                switch (choice)
                {
                    case "1":
                        ShowBooks(books);
                        Pause();
                        break;
                    case "2":
                        SortBooksByTitle();
                        break;
                    case "3":
                        SortBooksByYear();
                        break;
                    case "4":
                        SortBooksByPages();
                        break;
                    case "5":
                        SortBooksByAuthor();
                        break;
                    case "6":
                        SearchBooks();
                        break;
                    case "7":
                        AddBook();
                        break;
                    case "8":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        Pause();
                        break;
                }
            }

            Console.WriteLine("Goodbye!");
        }

        static void PrintMenu()
        {
            Console.WriteLine("=== Library System ===");
            Console.WriteLine("1. Show all books");
            Console.WriteLine("2. Sort by Title (default)");
            Console.WriteLine("3. Sort by Year");
            Console.WriteLine("4. Sort by Pages (descending)");
            Console.WriteLine("5. Sort by Author");
            Console.WriteLine("6. Search books by keyword");
            Console.WriteLine("7. Add a new book");
            Console.WriteLine("8. Exit");
        }

        static void InitializeLibrary()
        {
            books.Add(new Book("The Hobbit", "J.R.R. Tolkien", 1937, 310));
            books.Add(new Book("1984", "George Orwell", 1949, 328));
            books.Add(new Book("To Kill a Mockingbird", "Harper Lee", 1960, 281));
            books.Add(new Book("Pride and Prejudice", "Jane Austen", 1813, 432));
            books.Add(new Book("Moby Dick", "Herman Melville", 1851, 635));
            books.Add(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, 218));
            books.Add(new Book("War and Peace", "Leo Tolstoy", 1869, 1225));
            books.Add(new Book("Ulysses", "James Joyce", 1922, 730));
            books.Add(new Book("Don Quixote", "Miguel de Cervantes", 1605, 863));
            books.Add(new Book("The Catcher in the Rye", "J.D. Salinger", 1951, 277));
        }

        static void ShowBooks(List<Book> list)
        {
            Console.WriteLine("\n--- Book List ---\n");
            foreach (var book in list)
            {
                Console.WriteLine(book);
            }
        }

        static void SortBooksByTitle()
        {
            books.Sort(); // Uses IComparable
            Console.WriteLine("\nSorted by title.");
            ShowBooks(books);
            Pause();
        }

        static void SortBooksByYear()
        {
            books.Sort(new YearComparer());
            Console.WriteLine("\nSorted by year.");
            ShowBooks(books);
            Pause();
        }

        static void SortBooksByPages()
        {
            books.Sort(new PagesComparer());
            Console.WriteLine("\nSorted by page count (descending).");
            ShowBooks(books);
            Pause();
        }

        static void SortBooksByAuthor()
        {
            books.Sort(new AuthorComparer());
            Console.WriteLine("\nSorted by author.");
            ShowBooks(books);
            Pause();
        }

        static void SearchBooks()
        {
            Console.Write("\nEnter keyword to search by title or author: ");
            string keyword = Console.ReadLine()?.ToLower();

            var results = books
                .Where(b => b.Title.ToLower().Contains(keyword) || b.Author.ToLower().Contains(keyword))
                .ToList();

            if (results.Count == 0)
            {
                Console.WriteLine("No books found.");
            }
            else
            {
                Console.WriteLine("\nSearch results:");
                ShowBooks(results);
            }
            Pause();
        }

        static void AddBook()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            int year = ReadInt("Year Published: ");
            int pages = ReadInt("Pages: ");

            books.Add(new Book(title, author, year, pages));
            Console.WriteLine("Book added successfully.");
            Pause();
        }

        static int ReadInt(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Invalid number.");
            }
        }

        static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}