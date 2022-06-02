using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class FirstClass : PostalService
    {
        public FirstClass(int distance, double weight) : base(distance, weight)
        {
           
        }
       

        public override double CalculateRate(int distance, double weight)
        {
            double rate = 0;
            if(weight <= 0.125)
            {
                rate = 0.035 * distance;
            }
            else if (weight <= 0.4375)
            {
                rate = 0.040 * distance;
            }
            else if (weight <= 0.9375)
            {
                rate = 0.047 * distance;
            }
            else if (weight <= 3.0)
            {
                rate = 0.195 * distance;
            }
            else if ( weight <= 8.0)
            {
                rate = 0.450 * distance;
            }
            else
            {
                rate = 0.500 * distance;
            }
            return rate;
        }
        public override string ToString()
        {
            return "First Class";
        }
    }
}

        /*public FirstClass(int distance, double weight)
            {
            this.Distance = distance;
            this.Weight = weight;
            }
        public int Distance { get; }*/