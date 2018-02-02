using System;

namespace TaskBookAuthor
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("How to cook without supplies?","Hun Gry","WSOY", 41.99);
            Book.ThemeName = "Help for dummies";
            Console.WriteLine(book.BookInfo());

            Book book2 = new Book("How to burn houses?", "Py Roman", "Otava", 13.99);
            Book.ThemeName = "Manual";
            Console.WriteLine(book2.BookInfo());

            Console.WriteLine(book2.GetBook("General Brauschitz's diary"));
            Book.ChangeTheme(book);
            Console.WriteLine(book.BookInfo());

            Author author = new Author("Tohtori X", "17.09.1992", book);
            author.PrintInfo();



            Console.ReadKey();
        }
    }
}
