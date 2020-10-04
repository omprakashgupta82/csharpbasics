using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class UpsInvoiceFactory : BaseInvoiceFactory
    {
        public override IInvoice GetInvoice()
        {
            UpsInvoice ups = new UpsInvoice();
            ups.PrintShippingLabel();
            return ups;
        }
    }
}
