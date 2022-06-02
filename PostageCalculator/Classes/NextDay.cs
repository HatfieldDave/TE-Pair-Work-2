using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class NextDay : SPU
    {
        public NextDay(int distance, double weight) : base(distance, weight)
        {

        }
        public override double CalculateRate(int distance, double weight)
        {
            double rate = (weight * 0.075) * distance;
            return rate;
        }
        public override string ToString()
        {
            return "Next Day";
        }
    }
}
