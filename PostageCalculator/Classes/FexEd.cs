using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class FexEd : IDeliveryDriver
    {
        public FexEd(int distance, double weight)
        {
            
        }

        public double CalculateRate(int distance, double weight)
        {
            double rate = 20.0;
            if(distance > 500)
            {
                if(weight > 3.0)
                {
                    return rate += 3.00;
                }
                return rate += 5.00;
            }
            return rate;
        }
        public override string ToString()
        {
            return "FexEd";
        }
    }
}
