using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    interface IProduct
    {
        public string GetProduct(string name)
        {
        
        }
        
        public int CountValue(int áprice, int amount)
        {
            áprice = 20;
            amount = 10;
            return áprice * amount;
        }
    }
}
