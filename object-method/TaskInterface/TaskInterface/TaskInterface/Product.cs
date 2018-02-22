using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    class Product
    {
        private string name;
        private int áprice;
        private int amount;

        public Product(string name, int áprice, int amount)
        {
            this.name = name;
            this.áprice = áprice;
            this.amount = amount;
        }

        public int Amount { get => amount; set => amount = value; }
        public int Áprice { get => áprice; set => áprice = value; }
        public string Name { get => name; set => name = value; }
    }
}
