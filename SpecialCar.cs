using System;

namespace CarApp
{
    public class SpecialCar : Car
    {
        private int buildYear;

        public SpecialCar(string brand, int power, int seats, int year, int buildYear) : base(brand, power, seats, year)
        {
            this.buildYear = buildYear;
        }

        public double GetQualityP()
        {
            int currentYear = DateTime.Now.Year;
            return GetQuality() - 1.5 * (currentYear - buildYear);
        }

        public override string ToString()
        {
            return base.ToString() + $"\nQualityP: {GetQualityP()}";
        }
    }
}