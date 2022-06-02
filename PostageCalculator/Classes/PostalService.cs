using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public abstract class PostalService : IDeliveryDriver
    {
        public PostalService(int distance, double weight)
        {
            this.Distance = distance;
            this.Weight = weight;
        }

        public int Distance { get; }
        public double Weight { get; }
        public abstract double CalculateRate(int distance, double weight);
        
          
        
    }
}
