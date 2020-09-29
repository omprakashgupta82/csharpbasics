using DesignPatterns.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Economy Car with basic accessory package
            ICar car = new EconomyCar();
            CarAccessoriesDecorator carAccessories = new BasicAccessories(car);
            Console.WriteLine(carAccessories.GetDescription() + " , Total Price : Rs. " + carAccessories.GetCost().ToString());

            // Economy car with sports accessory package
            carAccessories = new SportsAccessories(car);
            Console.WriteLine(carAccessories.GetDescription() + " , Total Price : Rs. " + carAccessories.GetCost().ToString());

            // Luxury car with sports accessory package
            car = new LuxuryCar();
            carAccessories = new BasicAccessories(car);
            Console.WriteLine(carAccessories.GetDescription() + " , Total Price : Rs. " + carAccessories.GetCost().ToString());

            Console.ReadLine();
        }
    }
}
