using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    public class Shape
    {
        // A few example members 
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // Virtual method 
        public virtual void Draw()
        {
            Console.WriteLine("Base class -- Shape");
            //Console.WriteLine(string.Format("x = {0} , y = {1}", X, Y));
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a circle");
            //base.Draw();
        }
    }

    class Rectangle : Shape
    {
        public new void Draw()
        {
            // Code to draw a rectangle...
            Console.WriteLine("Drawing a rectangle");
            //base.Draw();
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            // Code to draw a triangle...
            Console.WriteLine("Drawing a triangle");
            //base.Draw();
        }
    }

    class Polygon
    {
        void Draw()
        {
            Console.WriteLine("Drawing a ploygon");
        }
    }
    
    public class BaseClass
    {
        public int WorkField = 1;
        public virtual void DoWork()
        {
            Console.WriteLine("Base Class : " + (++WorkField).ToString());
        }

        public virtual void NoWork()
        {
            Console.WriteLine("Base Class No work: " + (++WorkField).ToString());
        }
        
        public int WorkProperty
        {
            get { return 0; }
        }
    }

    public class DerivedClass : BaseClass
    {
        override public void DoWork()
        {
            Console.WriteLine("Derived Class : " + (++WorkField).ToString());
            //base.DoWork();
        }

        public new void NoWork()
        {
            Console.WriteLine("Derived Class No Work: " + (++WorkField).ToString());
        }
        public new int WorkField = 1;
        public new int WorkProperty
        {
            get { return 0; }
        }
    }

    public class DerivedClass11 : DerivedClass
    {
        override public void DoWork()
        {
            Console.WriteLine("Derived Class11 : " + (++WorkField).ToString());
        }

        public new void NoWork()
        {
            Console.WriteLine("Derived Class11: " + (++WorkField).ToString());
        }
    }

    public abstract class DerivedClass1
    {
        public abstract void abc();
    }

    public abstract class DerivedClass2 : DerivedClass1
    {
        public override void abc()
        {
            Console.WriteLine("Abstract");
        }

        public abstract void bcd();

        public void display()
        {
            Console.WriteLine("Display");
        }
    }

    public class Concrete : DerivedClass2
    {
        public override void bcd()
        {
            Console.WriteLine("concrete bcd method");
        }

        public override void abc()
        {
            Console.WriteLine("concrete abc method");
        }
    }

    public class InheritanceDemo
    {
        static void Main(string[] args)
        {
            // Polymorphism at work #1: a Rectangle, Triangle and Circle 
            // can all be used wherever a Shape is expected. No cast is 
            // required because an implicit conversion exists from a derived  
            // class to its base class.


            System.Collections.Generic.List<Shape> shapes = new System.Collections.Generic.List<Shape>();
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());
            shapes.Add(new Circle());


            // Polymorphism at work #2: the virtual method Draw is 
            // invoked on each of the derived classes, not the base class. 
            foreach (Shape s in shapes)
            {
                s.Draw();
            }



            DerivedClass B = new DerivedClass();
            B.DoWork();  // Calls the derived class method.
            B.NoWork();  // Calls the derived class method.

            BaseClass A = (BaseClass)B;
            A.DoWork();  // If this method is override in derived class then Calls the derived class DoWork override method 
            //  And if it is declared as new method in derived class then call the base class method
            //   In this case it will call the derived class DoWork override method 

            A.NoWork();  // If this method is override in derived class then Calls the derived class DoWork override method 
            //  And if it is declared as new method in derived class then call the base class method
            // In this case it will call the base class NoWork method

            //DerivedClass2 d2 = new DerivedClass2(); // Can't create the instance of the abstract class
            //d2.DoWork();

            //DerivedClass1 d1 = new DerivedClass1();
            //d1.abc();

            DerivedClass11 d11 = new DerivedClass11();
            d11.DoWork();
            d11.NoWork();

            BaseClass dc = (DerivedClass)d11;
            dc.DoWork();
            dc.NoWork();

            Concrete cr = new Concrete();
            cr.abc();
            cr.bcd();

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}
