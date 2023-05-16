using System;

namespace CarApp
{
    public class Car
    {
        private string brand;
        private int power;
        private int seats;
        private int year;

        public Car(string brand, int power, int seats, int year)
        {
            this.brand = brand;
            this.power = power;
            this.seats = seats;
            this.year = year;
        }

        public double GetQuality()
        {
            return 1.0 * power / seats;
        }

        public override string ToString()
        {
            return $"Brand: {brand}\nPower: {power}\nSeats: {seats}\nYear: {year}\nQuality: {GetQuality()}";
        }
    }
}