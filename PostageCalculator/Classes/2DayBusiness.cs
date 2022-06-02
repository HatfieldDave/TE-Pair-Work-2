using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class _2DayBusiness : SPU
    {
        public _2DayBusiness(int distance, double weight) : base(distance, weight)
        {

        }
        public override double CalculateRate(int distance, double weight)
        {
            double rate = (weight * 0.050) * distance;
            return rate;
        }
        public override string ToString()
        {
            return "2 Day Business";
        }
    }
}
