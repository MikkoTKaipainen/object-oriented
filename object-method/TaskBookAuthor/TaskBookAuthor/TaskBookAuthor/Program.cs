using System;

namespace TaskBookAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Jaskan päiväkirja","Paavo Perusmies","WSOY", 12.99);
            Console.WriteLine(book.BookInfo());
            book.Name = "xxxx";
            Book.ThemeName = "xx";
            Console.WriteLine(book.BookInfo());

            Book book2 = new Book("Jaskan ilatpäiväkirja", "Paavo Pesusieni", "WSOY", 13.99);
            Console.WriteLine(book2.BookInfo());
            book2.Name = "Hulipatsuijjaa";
            Book.ThemeName = "Horror";
            Console.WriteLine(book2.BookInfo());

            Console.WriteLine(book.BookInfo());
            Console.ReadKey();
        }
    }
}
