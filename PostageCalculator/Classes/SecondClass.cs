using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SecondClass : PostalService
    {
        public SecondClass(int distance, double weight) : base(distance, weight)
        {

        }
        public override double CalculateRate(int distance, double weight)
        {
            double rate = 0;
            if (weight <= 0.125)
            {
                rate = 0.0035 * distance;
            }
            else if (weight <= 0.4375)
            {
                rate = 0.0040 * distance;
            }
            else if (weight <= 0.9375)
            {
                rate = 0.0047 * distance;
            }
            else if (weight <= 3.0)
            {
                rate = 0.0195 * distance;
            }
            else if (weight <= 8.0)
            {
                rate = 0.0450 * distance;
            }
            else
            {
                rate = 0.0500 * distance;
            }
            return rate;
        }
        public override string ToString()
        {
            return "Second Class";
        }
    }
}
