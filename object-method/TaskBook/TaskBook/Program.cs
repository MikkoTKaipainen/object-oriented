using System;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.PrintBookInfo();

            Book newBook = new Book("Koodivelhon salainen päiväuni", "Johnston MccMacemoor", 100791, 19.99);
            newBook.PrintBookInfo();
            Console.WriteLine(newBook.CompareBook(book));


            Console.ReadKey();
        }
    }
}
