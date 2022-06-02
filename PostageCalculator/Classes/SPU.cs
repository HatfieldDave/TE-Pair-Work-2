using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public abstract class SPU : IDeliveryDriver
    {
        public SPU(int distance, double weight)
        {
            this.Distance = distance;
            this.Weight = weight;
        }
        public int Distance { get; }
        public double Weight { get; }
        public abstract double CalculateRate(int distance, double weight);
    }
}
