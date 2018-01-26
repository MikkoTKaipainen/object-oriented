using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBookAuthor
{
    class Book
    {
        string _name;
        string _author;
        string _publisher;
        double _price;
        static string _themeName;

        public string Name { get => _name; set => _name = value; }
        public static string ThemeName { get => _themeName; set => _themeName = value; }

        public Book(string name, string author, string publisher, double price)
        {
            Name = name;
            _author = author;
            _publisher = publisher;
            _price = price;
            _themeName = "Ei tietoa";
        }

        public string BookInfo()
        {
            return $"---------------------\n" +
                $"Kirja: {Name}\n" +
                $"Kirjailija: {_author}\n" +
                $"Julkaisija: {_publisher}\n" +
                $"Hinta: {_price}\n" +
                $"Teema: {ThemeName}";
        }
    }
}
