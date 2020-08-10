using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    public class IComparerDemo
    {
        public static void Main()
        {
            List<Person> xPerson = new List<Person>()
            {
                new Person(){Name="Kds",Age=34},
                new Person(){Name="Mad",Age=14},
                new Person(){Name="Abhi",Age=54},
                new Person(){Name="Kab",Age=22},
                new Person(){Name="Nam",Age=32},
                new Person(){Name="Bam",Age=22},
            };

            PersonComparer pc = new PersonComparer();
            xPerson.Sort(pc);

            foreach (Person item in xPerson)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }

    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Age > y.Age)
                return 1;
            else if (x.Age < y.Age)
                return -1;
            else
                return 0;
        }
    }
}
