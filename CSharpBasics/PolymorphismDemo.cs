using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    class PolymorphismDemo
    {
        public static void Main(string[] args)
        {
            //POLYMORPHISM USAGE
            bool bExit = true;
            RectangleShape rect = new RectangleShape();
            RhombusShape romb = new RhombusShape();
            SquareShape sqr = new SquareShape();
            while (bExit)
            {
                CBaseShape bs = new CBaseShape();

                Console.WriteLine(@"Type your choice or type 'exit' to stop");
                Console.WriteLine(@"Reminding you can see behavior of following figures: rhombus, square, rectangle");
                string line = Console.ReadLine();
                if (line == "exit") // Check string
                {
                    break;
                }
                //here we assume that classes as Rhombus, Rectangle and Square come to us from some
                //third party DLLs that we load while runtime
                switch (line)
                {
                    case "rh":
                        bs = romb;
                        break;
                    case "sq":
                        bs = sqr;
                        break;
                    case "re":
                        bs = rect;
                        break;
                    default:
                        break;//doing nothing here
                }
                bs.PaintMyself();
                rect.PaintMyself();

                bs.DrawMyself();
                rect.DrawMyself();
            }
        }
    }

    internal class CBaseShape
    {
        public virtual void PaintMyself()
        {
            Console.WriteLine("I'm default implementation and don't paint anything");
        }

        public virtual void DrawMyself()
        {
            Console.WriteLine("I'm default implementation and don't draw anything");
        }

    }
    internal class RhombusShape : CBaseShape
    {
        public override void PaintMyself()
        {
            Console.WriteLine("   *");
            Console.WriteLine("  ***");
            Console.WriteLine(" *****");
            Console.WriteLine("  ***");
            Console.WriteLine("   *");
        }
    }
    internal class SquareShape : CBaseShape
    {
        public override void PaintMyself()
        {
            Console.WriteLine("  ****");
            Console.WriteLine("  ****");
            Console.WriteLine("  ****");
            Console.WriteLine("  ****");
        }
    }
    internal class RectangleShape : CBaseShape
    {
        public new void PaintMyself()
        {
            Console.WriteLine("  ********");
            Console.WriteLine("  ********");
            Console.WriteLine("  ********");
        }

        public override void DrawMyself()
        {
            Console.WriteLine("Rectangle draws");
        }

        private void DisplayOverload(int a) { }

        private void DisplayOverload(out int a)
        {
            a = 100;
        }

        //private void DisplayOverload(int a, params string[][] parameterArray) { }

        //private void DisplayOverload(int a, params string[,] parameterArray) { }
        //private void DisplayOverload(ref int a) { }
    }
}
