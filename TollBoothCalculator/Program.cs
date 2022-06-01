using System;
using System.Collections.Generic;


namespace TollBoothCalculator.Classes
{
    public class Program 
    {
       

        static void Main(string[] args)
        {
           
            List<IVehicle> vehicles = new List<IVehicle>();

            Truck truck1 = new Truck(4);
            Truck truck2 = new Truck(6);
            Truck truck3 = new Truck(8);
            vehicles.Add(truck1);
            vehicles.Add(truck2);
            vehicles.Add(truck3);
        
            Car car1 = new Car(false);
            Car car2 = new Car(true);
            vehicles.Add(car1);
            vehicles.Add(car2);

            Tank tank = new Tank();
            vehicles.Add(tank);

            double totalRev = 0;
            double totalDistance = 0;
            foreach (IVehicle vehicle in vehicles)
            {
                Random randomNum = new Random();
                int distance = randomNum.Next(10, 241);
                totalRev += vehicle.CalculateToll(distance);
                totalDistance += distance;
                Console.WriteLine(vehicle + " " + distance + " " + vehicle.CalculateToll(distance));
                Console.WriteLine($"Total Miles Traveled {totalDistance} Total TollBooth Revenue {totalRev}");

                // totalDistance + " " + totalRev
            }











        }
    }
}
