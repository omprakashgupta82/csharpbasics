using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    public class Book
    {
        private string _bookName;
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            set { _bookName = value; }
            private get { return _bookName; }
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class PropertiesDemo
    {
        public static void Main()
        {
            Book myBook = new Book();
            myBook.Name = "C#.Net";

            Console.WriteLine("Book Name is = " + myBook.ToString());
            Console.ReadLine();

        }
    }
}
