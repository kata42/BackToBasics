using FeatureLib;
using System;

namespace OOPS
{
    class Program
    {
        /*
         * Access Specifiers
         * 1) public
         * 2) private
         * 3) internal
         * 4) protected
         * 5) protected internal
         * 6) private Protected
         * */
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car yourCar = new Car("Violet");
            Car theirCar = new Car("Violet","MyModel",1990);

            Console.WriteLine("Hello World!");
            Console.WriteLine($"My Car is {myCar.color} color");
            Console.WriteLine($"Your Car is {yourCar.color} color");

            Console.WriteLine($"Their Car has {theirCar.color} color, {theirCar.model} model and manifactured in {theirCar.year}");

            Console.WriteLine($"Count = {Car.count}");
        }
    }
}
