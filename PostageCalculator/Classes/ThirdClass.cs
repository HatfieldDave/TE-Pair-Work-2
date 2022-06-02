using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class ThirdClass : PostalService
    {
        public ThirdClass(int distance, double weight) : base(distance, weight)
        {

        }


        public override double CalculateRate(int distance, double weight)
        {
            double rate = 0;
            if (weight <= 0.125)
            {
                rate = 0.0020 * distance;
            }
            else if (weight <= 0.4375)
            {
                rate = 0.0022 * distance;
            }
            else if (weight <= 0.9375)
            {
                rate = 0.0024 * distance;
            }
            else if (weight <= 3.0)
            {
                rate = 0.0150 * distance;
            }
            else if (weight <= 8.0)
            {
                rate = 0.0160 * distance;
            }
            else
            {
                rate = 0.0170 * distance;
            }
            return rate;
        }
        public override string ToString()
        {
            return "Third Class";
        }
    }
}
