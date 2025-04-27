using System;

class Book
{
    private string title;
    private string author;

    // Default constructor
    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }

    // Parameterized constructor (for title only)
    public Book(string title)
    {
        this.title = title;
        author = "Unknown Author";
    }

    // Overloaded constructor (for title and author)
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    // Getters and Setters
    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

class Program
{
    static void Main()
    {
        // Problem 1: Create a Book object with the default constructor
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  

        // Change the title using SetTitle()
        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());  

        // Problem 2: Create a Book object with the parameterized constructor
        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.GetTitle());  

        // Problem 3: Create a Book object with the overloaded constructor
        Book book3 = new Book("Losing", "Jacob Leonardo");
        Console.WriteLine("Title: " + book3.GetTitle());  
        Console.WriteLine("Author: " + book3.GetAuthor());  

        // Problem 4: Create a Book object and update title and author
        Book book4 = new Book("Learning C#");
        book4.SetTitle("Winning");
        book4.SetAuthor("Isaias Leonardo");

        // Print updated title and author
        Console.WriteLine("Title: " + book4.GetTitle());  
        Console.WriteLine("Author: " + book4.GetAuthor());  
    }
}
