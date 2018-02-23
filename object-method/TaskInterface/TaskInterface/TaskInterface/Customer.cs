using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    class Customer : ICustomer
    {
        private string _customerName;
        private double _purchases;

        public Customer(string customerName, double purchases)
        {
            _customerName = customerName;
            _purchases = purchases;
        }

        public override string ToString()
        {
            return $"{_customerName} " +
                $"{_purchases}€ ";
        }

        public string GetCustomer(string name)
        {
            if (_customerName == name)
            {
                Console.WriteLine("Asiakas löytyi!");
                return name;
            }
            else
            {
                Console.WriteLine("Asiakasta ei löydy!");
                return null;
            }
        }
        public double CountBonus(double value, double bonus)
        {
            if(_purchases <= 1000)
            {
                bonus = -_purchases * 1.02;
                return bonus;
            }
            else if(_purchases > 1000 && _purchases < 2000)
            {
                bonus = _purchases * 1.03;
                return bonus;
            }
            else 
            {
                bonus = _purchases * 1.05;
                return bonus;
            }
            
        }
    }
}
