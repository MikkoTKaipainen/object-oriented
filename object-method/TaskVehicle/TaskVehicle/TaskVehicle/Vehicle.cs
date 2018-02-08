﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
    class Vehicle
    {
        protected string _type;
        protected string _model;
        protected int _year;
        protected double _price;

        public Vehicle(string type, string model, int year, double price)
        {
            _type = type;
            _model = model;
            _year = year;
            _price = price;
        }

        public Vehicle()
        {
            _type = "unknown";
            _model = "unknown";
            _year = 0000;
            _price = 00000;
        }

        public virtual string PrintVehicleInfo()
        {
            return ($"Type:{_type}\n" +
                $"Model:{_model}\n" +
                $"Year:{_year}\n" +
                $"Price:{_price}\n");
        }
    }
}