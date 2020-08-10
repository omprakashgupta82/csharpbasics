using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
// The following list summarizes the main features of a static class:
//• It contains only static members.
//• It can't be instantiated.
//• It's sealed.
//• It can't contain Instance Constructors.
//• It can't be used in a local, instance, or static variable declaration, as a generic type argument, or as the element type of an array.

    class StaticMembers
    {
        static void Main(string[] args)
        {
            A.displayMsg();
            B obj1 = new B();
            obj1.displayMsg();
            B obj2 = new B();
            obj2.displayMsg();
            B obj3 = new B();
            obj3.displayMsg();
            B obj4 = new B();
            obj4.displayMsg();

            Console.ReadLine();
        }
    }

    static class A
    {
        static int counter=5;
        static A()
        {
            counter += 1;
        }

        public static void displayMsg()
        {
            Console.WriteLine("No. of instances of class A are :" + counter.ToString());
        }
    }

    class B  // Use of static variable to count the no of objects created of class B
    {
        static int counter=10;
        public B()
        {
            counter += 1;
        }

        static B()
        {
            Console.WriteLine("a");
        }

        public void displayMsg()
        {
            Console.WriteLine("No. of instances of class B are :" + counter.ToString());
        }

        public void WriteMsg()
        {
            Console.WriteLine("No. of instances of class B are :" + counter.ToString());
        }

        public void PrintMsg()
        {
            Console.WriteLine("No. of instances of class B are :" + counter.ToString());
        }
    }
}
