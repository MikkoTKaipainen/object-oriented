using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    class Product : IProduct
    {
        private string _name;
        private int _aprice;
        private int _amount;

        public Product(string name, int aprice, int amount)
        {
            _name = name;
            _aprice = aprice;
            _amount = amount;
        }

        public override string ToString()
        {
            return $"{_name} "+
                $"{_aprice}€ "+
                $"{_amount}kpl";
        }

        public string GetProduct(string name)
        {
            if(_name == name)
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
