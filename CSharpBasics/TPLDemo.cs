using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{

    public class TPLDemo
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(millionRun);
            Parallel.Invoke(millionRun);
            Console.ReadLine();
        }


        public static void millionRun()
        {
            //for (int i = 0; i < 1000000; i++)
            //{
            //    Console.WriteLine("***********Start MillionRun**********");
            //    Console.WriteLine(i);
            //    Console.WriteLine("***********End MillionRun**********");
            //}

            List<int> lstint = new List<int>();

            List<int> a = lstint.Skip(0).Take(2).ToList();
        }

    }
}
