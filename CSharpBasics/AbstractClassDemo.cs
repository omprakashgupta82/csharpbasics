using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    public class AA
    {
        public void DoWork()
        {
            Console.WriteLine("DoWork() method of AA class");
        }
    }

    abstract class AbstractClassDemo : AA
    {
        public AbstractClassDemo()
        {   
            Console.WriteLine("constructor of abstract class");
        }

        public abstract void Display();

        public void ShowMessage()
        {
            Console.WriteLine("concrete method ShowMessage() of abstract class");
        }
    }

    class AbstractMain : AbstractClassDemo
    {
        public override void Display()
        {
            Console.WriteLine("abstract method Display() of abstract class");
        }
        public static void Main()
        {
            AbstractMain objMain = new AbstractMain();
            objMain.ShowMessage();
            objMain.Display();
            objMain.DoWork();
            Console.ReadLine();
        }
    }
}
