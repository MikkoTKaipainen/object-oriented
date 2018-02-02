using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBookAuthor
{
    class Author
    {
        string _name;
        string _birthday;
        Book _book;

 
        public Author(string name, string birthday, Book book)
        {
            _name = name;
            _birthday = birthday;
            _book = book;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"---------------------\n" +
                $"Nimi: {_name}\n" +
                $"Syntymäpäivä: {_birthday}\n" +
                $"Kirja: {_book.GetBook("How not to eat apples like a pleb")}");
        }
    }
}
