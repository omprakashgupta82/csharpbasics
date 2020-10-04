﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class DhlInvoice : IInvoice
    {
        public void PrintInvoice()
        {
            Console.WriteLine("Printing DHL Invoice");
        }
    }
}
