using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    class Product : IProduct
    {
        private string name;
        private int aprice;
        private int amount;

        public Product(string name, int aprice, int amount)
        {
            this.name = name;
            this.aprice = aprice;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"{name} "+
                $"{aprice}€ "+
                $"{amount}kpl";
        }

        public string GetProduct(string name)
        {
            if(this.name == name)
            {
                Console.WriteLine("Tuote löytyi!");
                return name;
            }
            else
            {
                Console.WriteLine("Tuotetta ei löydy!");
                return null;
            }
        }

        public int CountValue(int value)
        {
            value = aprice * amount;
            return value;
        }
    }
}
