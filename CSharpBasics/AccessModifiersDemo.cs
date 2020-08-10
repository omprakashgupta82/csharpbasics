using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    public class AccessModifiersDemo
    {
        public static void Main()
        {
            CSharpAccessModifiers cam = new CSharpAccessModifiers();


        }
    }

    public class CSharpAccessModifiers
    {
        int iPrivateAccess = 0;
        //public int iPublicAccess = 0;
        protected int iProtectedAccess = 0;
        protected internal int iProtectedInternalAccess;
        //internal int iInternalAccess = 0;
        //private protected int iPrivateProtected = 0;

        public string DisplayAge()
        {
            return iProtectedInternalAccess.ToString();

        }
    }

    public class ChildModifiers : CSharpAccessModifiers
    {
        public void ChildDisplay()
        {

            ChildModifiers cm = new ChildModifiers();
            cm.iProtectedInternalAccess = 90;
            cm.iProtectedAccess = 0;

            CSharpAccessModifiers cam = new CSharpAccessModifiers();
            //cam.iProtectedAccess = 0; // Can't accessible
            cam.iProtectedInternalAccess = 0;

        }

        public class ClsA 
        {
            void ABC()
            {
                CSharpAccessModifiers cam = new CSharpAccessModifiers();
                

            }
        }
    }
}
