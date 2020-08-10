using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace CSharpBasics
{
    class CovarianceAndContravarianceDemo
    {
        public static void Main()
        {
            Vehicle v = new Vehicle();
            TwoWheeler tw = new TwoWheeler();
            TwoWheeler tw1 = tw;
            bool b = tw.Equals(tw1);
            Console.Read();
        }
    }

    class Vehicle
    {
        public static void Display(IEnumerable<Vehicle> vehicles)
        {
            int i = 1;
            vehicles.ForEach(delegate (Vehicle v) { Console.WriteLine("Vehicle" + i.ToString()); i++; });
        }
    }

    class TwoWheeler : Vehicle
    {
        static TwoWheeler()
        {

        }

        public TwoWheeler()
        {

        }
    }

    class FourWheeler : Vehicle
    {

    }

    class Bike : TwoWheeler
    {

    }

    class Car : FourWheeler
    {

    }
}
