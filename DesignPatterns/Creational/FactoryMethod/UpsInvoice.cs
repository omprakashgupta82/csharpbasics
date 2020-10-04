using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class UpsInvoice : IInvoice
    {
        public string GetTermsConditions()
        {
            return "UPS shipping terms & conditions";
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Printing UPS Invoice");
        }

        public void PrintShippingLabel()
        {
            Console.WriteLine("Printing UPS Shipping Label");
        }
    }
}
