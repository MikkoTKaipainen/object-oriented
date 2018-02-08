using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBookAuthor
{
    namespace Literature
    {
        class Book
        {
            //variables
            string _name;
            readonly string _author;
            string _publisher;
            double _price;
            static string _themeName;

            //properties
            public string Name { get => _name; set => _name = value; }
            public static string ThemeName { get => _themeName; set => _themeName = value; }
            public double Price
            {
                get => _price;
                set
                {
                    _price = value;
                    if (value >= 30)
                        _price *= 0.90;
                }
            }

            //constructor
            public Book(string name, string author, string publisher, double price)
            {
                Name = name;
                _author = author;
                _publisher = publisher;
                Price = price;
                _themeName = ThemeName;
            }

            //methods
            public string BookInfo()
            {
                return $"---------------------\n" +
                    $"Kirja: {Name}\n" +
                    $"Kirjailija: {_author}\n" +
                    $"Julkaisija: {_publisher}\n" +
                    $"Hinta: {Price}\n" +
                    $"Teema: {ThemeName}";
            }

            public string GetBook(string GBook)
            {
                if (GBook == Name)
                    return $"{GBook} löytyy valikoimasta";
                else
                    return $"{GBook} ei löydy";
            }

            public static string ChangeTheme(Book book)
            {
                ThemeName = "Fantasy";
                return ThemeName;
            }

        }
    }
   
}
