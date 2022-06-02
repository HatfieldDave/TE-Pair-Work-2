using System;
using System.Collections.Generic;

namespace PostageCalculator.Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the weight of the package? ");
            string packageWeight = Console.ReadLine();
            double packageWeightDouble = double.Parse(packageWeight);

            Console.Write("(P)ounds or (O)unces? ");
            string weightType = Console.ReadLine();
            weightType = weightType.ToUpper();

            double packageWeightPound = packageWeightDouble;
            if (weightType == "O")
            {
                packageWeightPound = packageWeightDouble / 16;
                
            }

            Console.Write("What distance will it be traveling ");
            string distance = Console.ReadLine();
            int distanceInt = int.Parse(distance);

            

            FirstClass firstClass = new FirstClass(distanceInt, packageWeightPound);
            Console.WriteLine(firstClass + " " + firstClass.CalculateRate(distanceInt, packageWeightPound).ToString("c"));

            SecondClass secondClass = new SecondClass(distanceInt, packageWeightPound);
            Console.WriteLine(secondClass + " " + secondClass.CalculateRate(distanceInt, packageWeightPound).ToString("c"));

            ThirdClass thirdClass = new ThirdClass(distanceInt, packageWeightPound);
            Console.WriteLine(thirdClass + " " + thirdClass.CalculateRate(distanceInt, packageWeightPound).ToString("c"));

            FexEd fexEd = new FexEd(distanceInt, packageWeightPound);
            Console.WriteLine(fexEd + " " + fexEd.CalculateRate(distanceInt, packageWeightPound).ToString("c"));

            _4DayGround day4Ground = new _4DayGround(distanceInt, packageWeightPound);
            Console.WriteLine(day4Ground + " " + day4Ground.CalculateRate(distanceInt, packageWeightPound).ToString("c"));

            _2DayBusiness day2Business = new _2DayBusiness(distanceInt, packageWeightPound);
            Console.WriteLine(day2Business + " " + day2Business.CalculateRate(distanceInt, packageWeightPound).ToString("c"));

            NextDay nextDay = new NextDay(distanceInt, packageWeightPound);
            Console.WriteLine(nextDay + " " + nextDay.CalculateRate(distanceInt, packageWeightPound).ToString("c"));

        }
    }
}
