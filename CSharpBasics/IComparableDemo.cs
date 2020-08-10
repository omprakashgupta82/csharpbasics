using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    class IComparableDemo
    {
        public static void Main()
        {
            List<Person> personLst = new List<Person>() 
            {
                new Person(){Name="Kds",Age=34},
                new Person(){Name="Mad",Age=14},
                new Person(){Name="Abhi",Age=54},
                new Person(){Name="Kab",Age=22},
                new Person(){Name="Nam",Age=32},
                new Person(){Name="Bam",Age=22},
            };
            personLst.Sort();

            foreach (var item in personLst)
            {
                Console.WriteLine(item.Name + "\t" + item.Age.ToString());
            }
            Console.ReadLine();
        }

    }

    public class Person //: IComparable<Person>
    {
        public int Age { get; set; }
        public string Name { get; set; }


        //public int CompareTo(Person other)
        //{
        //    if (this.Age == other.Age)
        //    {
        //        return this.Name.CompareTo(other.Name);
        //    }
        //    return this.Age.CompareTo(other.Age);
        //}

        public override string ToString()
        {
            return this.Name + "\t" + this.Age.ToString();
        }
    }
}
