using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class DhlInvoiceFactory : BaseInvoiceFactory
    {
        public override IInvoice GetInvoice()
        {
            DhlInvoice dhl = new DhlInvoice();
            dhl.PrintReturnLabel();
            return dhl;
        }
    }
}
