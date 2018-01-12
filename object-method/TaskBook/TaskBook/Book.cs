using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBook
    //Tehty yhteistyönä Timon kanssa
{
    class Book
    {
        //Fields
        //Kirjalle määritetään kirjailia, nimi, id-numero sekä kappalehinta nimiset muuttujat
        public string Title;
        public string Author;
        public int Id;
        public double Price;

        //Constructor
        //Määritellään muuttujille arvot
        public Book()
        {
            Title = "Koodivelhon päiväkirjat";
            Author = "Johnson MacDickfield";
            Id = 170992;
            Price = 29.99;
        }

        public Book(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;
        }

        //Methods
        //Tulostaa kirjan tiedot näytölle
        public void PrintBookInfo()
        {
            Console.WriteLine($"Title: {Title} \nAuthor: {Author} \nId: {Id} \nPrice: {Price}");
        }

        public string CompareBook(Book book)
        {
            if (this.Price > book.Price)
                return $"{this.Title} on kalliimpi kuin {book.Title}";
            else if (this.Price < book.Price)
                return $"{this.Title} on halvempi kuin {book.Title}";
            else
                return $"{this.Title} on saman hintainen kuin {book.Title}";
        }

    }
}
