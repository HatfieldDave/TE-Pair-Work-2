using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Tank : IVehicle
    {
        public Tank()
        { 
        }
        public double CalculateToll(int distance)
        {
            return 0;
                
        }

        public override string ToString()
        {
            return "Tank";
        }
    }
}
