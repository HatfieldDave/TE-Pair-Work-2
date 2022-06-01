using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
    //constructor
    public Truck(int numberOfAxles)
        {
            this.NumberOfAxles = numberOfAxles;
        }
        public int NumberOfAxles { get; }

        public double CalculateToll(int distance)
        {
            if(NumberOfAxles == 4)
            {
                double toll = 0.040 * distance;
                return toll;
            }
            else if(NumberOfAxles == 6)
            {
                double toll = 0.045 * distance;
                return toll;
            }
            else if (NumberOfAxles >= 8)
            {
                double toll = 0.048 * distance;
                return toll;
            }
            return distance;
        }

        public override string ToString()
        {
            return "Truck";
        }
    }
}
