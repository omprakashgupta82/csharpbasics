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
        /// <summary>
        /// Accessible within the class
        /// </summary>
        private int iPrivateAccess = 0;

        /// <summary>
        /// Accessible everywhere
        /// </summary>
        public int iPublicAccess = 0;

        /// <summary>
        /// Accessible within the class as well as in inherited classes in same assembly or other assembly
        /// </summary>
        protected int iProtectedAccess = 0;

        /// <summary>
        /// Accessible within the same assembly as well as in inherited classes
        /// </summary>
        protected internal int iProtectedInternalAccess;

        /// <summary>
        /// Accessible only within the assembly
        /// </summary>
        internal int iInternalAccess = 0;

        //private protected int iPrivateProtected = 0;

        public string DisplayAge()
        {
            iProtectedAccess += 1; 
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
