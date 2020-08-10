using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Web;

namespace CSharpBasics
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            int cHash = c.GetHashCode();

            Class1 c2 = (Class1)c.MemberwiseClone();//new Class1();

            int c2Hash = c2.GetHashCode();

            

            c2Hash = c2.GetHashCode();

            Class1 c3 = new Class1();
            bool e = c2.Equals(c3);

            TestClass tc1 = new TestClass() { Age = 10, Name = "Om" };
            TestClass tc2 = tc1;

            tc2.Age = 20;
            tc2.Name = "Prakash";

            int tc1hash = tc1.GetHashCode();
            int tc2hash = tc2.GetHashCode();

            tc1.Age = 30;
            tc1.Name = "Gupta";

            List<int> lst = new List<int>();
            lst.Add(0);
            lst.Add(20);
            

            tc1.MyList(lst);

            Console.ReadKey();
        }

        private static bool Mod5(int x)
        {
            return (x % 5 != 0);
        }
    }

    public class TestClass
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Sum(int x, int y, ref int z)
        {
            z = x + y;
        }

        public void A(ref int x,  int y, int z)
        {
            y = 90;
        }

        public void A( int x,  int y, ref int z)
        { }

        
        public void MyList (List<int> i)
        {
            List<int> j = i;
            j[0] = 10;
            List<int> k = j;

            k[0] = 100;
        }
    }
}
