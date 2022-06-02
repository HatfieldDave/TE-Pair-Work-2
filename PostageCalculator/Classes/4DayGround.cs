using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class _4DayGround : SPU
    {
        public _4DayGround(int distance, double weight) : base(distance, weight)
        {

        }
        public override double CalculateRate(int distance, double weight)
        {
            double rate = (weight * 0.0050) * distance;
            return rate;
        }
        public override string ToString()
        {
            return "4 Day Ground";
        }
    }
}
