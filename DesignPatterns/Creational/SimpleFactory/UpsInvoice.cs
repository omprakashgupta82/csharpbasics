using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class UpsInvoice : IInvoice
    {
        public void PrintInvoice()
        {
            Console.WriteLine("Printing UPS Invoice");
        }
    }
}
