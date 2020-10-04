using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class InvoiceFactory
    {
        public static IInvoice GetInvoice(int invoiceType)
        {
            IInvoice invoice = null;

            if (invoiceType == 1)
                invoice = new DhlInvoice();
            else if (invoiceType == 2)
                invoice = new UpsInvoice();

            return invoice;
        }
    }
}
