using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    //If we need the some seprate business logic for the concrete products then we can use the Factory method pattern. 
    // Like DHL invoice will print the Return Label while UPS invoice will print the Shipping label
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the invoice type. 1-> DHL, 2-> UPS : ");
            string invoiceType = Console.ReadLine();
            BaseInvoiceFactory factory = InvoiceFactory.CreateFactory(Convert.ToInt16(invoiceType));
            
            if (factory != null)
                factory.GetInvoice().PrintInvoice();
            else
                Console.WriteLine("Please enter the correct invoice type!");

            Console.ReadLine();
        }
    }
}
