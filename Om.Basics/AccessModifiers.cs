using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpBasics;

namespace Om.Basics
{
    public class AccessModifiersDemo
    {
        public static void Main()
        {
            
        }
    }

    public class AccessModifiers
    {
        public void Display()
        {
            CSharpAccessModifiers cm = new CSharpAccessModifiers();
            
        }
    }
    public class ChildModifiers : CSharpAccessModifiers
    {
        public void Display()
        {
            ChildModifiers cm = new ChildModifiers();
            cm.iProtectedInternalAccess = 45;
            cm.iProtectedAccess = 00;
            cm.iPublicAccess = 20;
            
        }
    }
}
