using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class InvoiceFactory
    {
        public static BaseInvoiceFactory CreateFactory(int invoiceType)
        {
            BaseInvoiceFactory factory = null;

            if (invoiceType == 1)
                factory = new DhlInvoiceFactory();
            else if (invoiceType == 2)
                factory = new UpsInvoiceFactory();

            return factory;
        }
    }
}
