using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
    class Car : Vehicle
    {
        protected string _engineSize;
        protected string _carModel;
        protected int _doorNumber;

        public Car(string type, string model, int year, double price, string engineSize, string carModel, int doorNumber)
        {
            _type = type;
            _model = model;
            _year = year;
            _price = price;
            _engineSize = engineSize;
            _carModel = carModel;
            _doorNumber = doorNumber;
        }

        public Car()
        {
            _engineSize = "Large";
            _carModel = "Sedan";
            _doorNumber = 3;
        }

        public override string PrintVehicleInfo()
        {
            return $"{base.PrintVehicleInfo()}Engine size:{_engineSize}\n" +
                $"Car model:{_carModel}\n" +
                $"Door number:{_doorNumber}\n";
        }
    }
}
