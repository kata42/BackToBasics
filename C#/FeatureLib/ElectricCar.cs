
using System;

namespace FeatureLib
{
    public class ElectricCar: Car
    {
        public string Fly()
        {
            return "Car isi flying";
        }

        public override void Undefined()
        {
            Console.WriteLine("From ElectricCar");
        }

        public override void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}
