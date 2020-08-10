using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CSharpBasics
{
    public class IEnumerableDemo
    {
        public static int Main()
        {
            return 1;
        }
    }

    public class Employee : IEnumerable
    {
        public int Age { get; set; }
        public String Name { get; set; }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
