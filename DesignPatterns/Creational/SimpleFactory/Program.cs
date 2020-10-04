using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the invoice type. 1-> DHL, 2-> UPS : ");
            string invoiceType = Console.ReadLine();
            IInvoice invoice = Factory.GetInvoice(Convert.ToInt16(invoiceType));

            if (invoice != null)
                invoice.PrintInvoice();
            else
                Console.WriteLine("Please enter the correct invoice type!");

            Console.ReadLine();
        }
    }
}
