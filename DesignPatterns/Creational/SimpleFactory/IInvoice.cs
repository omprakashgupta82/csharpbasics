using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SimpleFactory
{
    public interface IInvoice
    {
        void PrintInvoice();

        string GetTermsConditions();
    }
}
