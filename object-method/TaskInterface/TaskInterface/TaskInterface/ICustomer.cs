using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    interface ICustomer
    {
        string GetCustomer(string name);
        double CountBonus(double value, double bonus);
    }
}
