using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CSharpBasics
{
    class ConstructorDemo
    {
        public static void Main(string[] args)
        {
            ConA objA = new ConA();
            ConB objB = new ConB();
            ConA a = new ConB();
            //ConB objB1 = new ConB(5, 8);
            objA.Display();
            objB.Display();
            a.Display();

            //ConBB.Display();
            Console.ReadLine();
        }
    }

    class ConA
    {
        public ConA() : this(2,3)
        {
            Console.WriteLine("Class ConA default constructor.");

        }

        public ConA(int j, int k)
        {
            Console.WriteLine("Class ConA parameterized constructor. j ={0}, j={1}", j, k);
        }

        public virtual void Display()
        {
            Console.WriteLine("Display method of Class ConA.");
        }
    }

    class ConB : ConA
    {
        public ConB()
            : base()
        {
            Console.WriteLine("Class ConB default constructor.");
        }

        public ConB(int j, int k)
            : base(j, k)
        {
            ConB objB = new ConB();
            Console.WriteLine("Class ConB parameterized constructor. j ={0}, j={1}", j, k);
        }

        public override  void Display()
        {
            //base.Display(); //Call the ConA class method.
            Console.WriteLine("Display method of Class ConB.");
        }

        public void Display(string a)
        {
            //base.Display(); //Call the ConA class method.
            Console.WriteLine("Display method of Class ConB.");
            
        }
    }

   
    class ConBB
    {
        private int i;
        public int Count;
        ConBB()
        {
        }

        public static ConBB CreateInstance()
        {
            return new ConBB();
        }

        public static void Display()
        {
            Console.WriteLine("ConBB display function");
            CreateInstance().Show();
        }

        public void Show()
        {
            Console.WriteLine("ConBB show function");
        }
    }
}
