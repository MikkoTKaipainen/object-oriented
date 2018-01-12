using System;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.PrintBookInfo();

            Book newBook = new Book("Koodivelhon salainen päiväuni", "Johnston MccMacemoor", 100791, 39.99);
            newBook.PrintBookInfo();
            Console.ReadKey();
        }
    }
}
