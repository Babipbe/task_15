using System;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", 100, 5, 2010);
            Console.WriteLine(car);

            Console.WriteLine();

            SpecialCar specialCar = new SpecialCar("Ferrari", 500, 2, 2020, 2021);
            Console.WriteLine(specialCar);
        }
    }
}