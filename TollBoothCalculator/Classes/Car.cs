using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {
        //constructor
        public Car(bool trailer)
        {
            
            this.HasTrailer = trailer;
        }
        
        //property
        public bool HasTrailer { get; }

        //method
        public double CalculateToll(int distance)
        {
            double toll = distance * 0.020;
            if(HasTrailer)
            {
                toll = toll + 1.00;
            }
            return toll;
        }

        public override string ToString()
        {
            return "Car";
        }
    }
}
