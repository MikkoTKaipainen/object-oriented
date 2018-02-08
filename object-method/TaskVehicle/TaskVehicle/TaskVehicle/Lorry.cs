using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
    class Lorry : Car
    {
        protected int _lorryFreightWeight;
        protected int _consumeForKg;

        public Lorry(int lorryFreightWeight, int consumeForKg)
        {
            _lorryFreightWeight = lorryFreightWeight;
            _consumeForKg = consumeForKg;
        }

        public Lorry()
        {
            _lorryFreightWeight = 6000;
            _consumeForKg = 25;
        }

        public override string PrintVehicleInfo()
        {
            return $"{base.PrintVehicleInfo()}Lorry freight weight:{_lorryFreightWeight * _consumeForKg}\n";
        }
    }
}
