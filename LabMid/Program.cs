
using LabMid;
using System;

delegate void BookOperation(Book book);

class Program
{
    static void DisplayBook(Book book)
    {
        Console.WriteLine("================================");
        Console.WriteLine("Title: " + book.title);
        Console.WriteLine("Author: " + book.author);
        Console.WriteLine("Price: " + book.price);
        Console.WriteLine("Copies: " + book.copies);
        Console.WriteLine();
        Console.WriteLine("================================");
    }

    static void DisplayExpensiveBook(Book book)
    {
        if (book.price > 1000)
        {
            Console.WriteLine("Expensive Book.. " + book.title);
        }
    }

    static void Main(string[] args)
    {
        Library library = new Library();

        try
        {
            string mode = "add";

            if (args.Length > 0)
            {
               mode = args[0];
             }

            if (mode == "add")
            {
                library.AddBooks();
            }

            else
            {
                throw new IndexOutOfRangeException
                    (".............Invalid mode.......!");
            }



            BookOperation bookOperation = DisplayBook;
            bookOperation += DisplayExpensiveBook;

            Book mostExpensiveBook = library[0];

            Console.WriteLine("\n--- All Books ---");

            for (int i = 0; i < 5; i++)
            {
                bookOperation(library[i]);

                if (library[i].price > mostExpensiveBook.price)
                {
                    mostExpensiveBook = library[i];
              }
            }


            Console.WriteLine("\n--- Most Expensive Book ---");
            DisplayBook(mostExpensiveBook);
        }
        catch (IndexOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
