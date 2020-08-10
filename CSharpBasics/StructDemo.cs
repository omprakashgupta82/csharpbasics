using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{

    //    Structs share most of the same syntax as classes, although structs are more limited than classes: 

    //• Within a struct declaration, fields cannot be initialized unless they are declared as const or static.
    //• A struct may not declare a default constructor (a constructor without parameters) or a destructor.
    //• Structs are copied on assignment. When a struct is assigned to a new variable, all the data is copied, and any modification to the new copy does not change the data for the original copy. 
    //  This is important to remember when working with collections of value types such as Dictionary<string, myStruct>.
    //• Structs are value types and classes are reference types. 
    //• Unlike classes, structs can be instantiated without using a new operator.
    //• Structs can declare constructors that have parameters.
    //• A struct cannot inherit from another struct or class, and it cannot be the base of a class. All structs inherit directly from System.ValueType, which inherits from System.Object.
    //• A struct can implement interfaces.
    //• A struct can be used as a nullable type and can be assigned a null value.
    //• Initialize struct variables before using if object didn't create using new keyword.


    public struct CoOrds
    {
        //public int MyProperty { get; set; }
        public int x, y;
        public static int z;
        public const int w = 10;

        //public CoOrds() //A struct may not declare a default constructor(a constructor without parameters) or a destructor.
        //{
        //    x = 0;
        //    y = 0;
        //}
        public CoOrds(int p1, int p2)
        {
            x = p1;
            y = p2;
            z = 10;

        }

        public void UseVariables()
        {
            x = 10;
            y = 20;
            z = 30;
        }

        public override string ToString()
        {
            return string.Format("x = {0}, y = {1}, z = {2}, w = {3}", x, y, z, w);
        }

        public class ABC
        {
            int x, y;
            public ABC()
            {
                x = 10;
                y = 90;
            }

            internal class XYZ
            {
                public XYZ()
                {

                }
            }
        }
    }


    public class StructMain
    {
        public static void Main()
        {
            // Initialize:   
            //CoOrds coords1 = new CoOrds();          
            //CoOrds coords2 = new CoOrds(10, 10);

            // Display results:
            //Console.WriteLine("CoOrds 1: ");

            CoOrds coords3 = new CoOrds();
            
            //coords3.x = 0;
            //coords3.y = 0;
            Console.WriteLine("x = {0}, y = {1}", coords3.x, coords3.y); // Initialize struct variables before using if not created object using new keyword
            

            //coords1.UseVariables();
            //Console.WriteLine("x = {0}, y = {1}", coords1.x, coords1.y);
            //Console.WriteLine(coords1.ToString());
            //Console.Write("CoOrds 2: ");
            //Console.WriteLine("x = {0}, y = {1}", coords2.x, coords2.y);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
