using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    //A private constructor is a special instance constructor.
    //It is generally used in classes that contain static members only.
    //If a class has one or more private constructors and no public constructors,
    //other classes (except nested classes) cannot create instances of this class.

    class PrivateConstructorDemoMain
    {
        private static int Main(string[] arg)
        {
            PrivateConstructorDemo cd = new PrivateConstructorDemo(1);
            Console.ReadKey();
            return 0;

        }
        // If uncommented it gives error because no other class can make the instance of the private constructor's class
    }

    /// <summary>
    /// Demonstration of the private constructor
    /// </summary>
    class PrivateConstructorDemo
    {
        public bool isInitialized;
        public int x = 2;
        private PrivateConstructorDemo() //The declaration of the empty constructor prevents the automatic generation of a default constructor
        {
        }

        //private PrivateConstructorDemo()
        //{
        //    isInitialized = true;
        //}

        private PrivateConstructorDemo(string x)
        {
            isInitialized = true;
        }

        public PrivateConstructorDemo(int i)
        {
            x = i;
        }

        public void Dispaly()
        {
            Console.WriteLine("Display");
        }

        class NestedConstructorDemo
        {
            public static void Main()
            {
                //PrivateConstructorDemo pcd = new PrivateConstructorDemo();
                // Nested classes can make the instance 
                // of the class which have the private constructor  

                //Console.WriteLine(pcd.x);
                //pcd.Dispaly();
                PrivateConstructorDemo cd = new PrivateConstructorDemo();
                Console.WriteLine(cd.isInitialized);
                Console.ReadKey();
            }
        }
    }
}
