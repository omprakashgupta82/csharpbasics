using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    public interface IMath
    {
        int Add(int a, int b);
        int Multiply(int a, int b);
    }

    public interface IMathEx
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
    }

    class InterfaceDemo : IMath, IMathEx
    {
        private int total = 0;

        public InterfaceDemo()
        {

        }

        public void DisplayTotal(int total)
        {
            Console.WriteLine("Total = " + total.ToString());
        }

        

        public static void Main()
        {
            InterfaceDemo idObj = new InterfaceDemo();

            IMathEx ObjMathEx = idObj;
            idObj.DisplayTotal(ObjMathEx.Add(5, 6));

            IMath ObjMath = idObj;
            idObj.DisplayTotal(ObjMath.Add(10, 15));
            idObj.DisplayTotal(idObj.Multiply(10, 15));

            Console.ReadLine();
        }

        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int a, int b)
        {
            throw new NotImplementedException();
        }
    }

    class InterfaceMain
    {

    }
}
