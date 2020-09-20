using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    /*
    1. Public
    Public members can be accessed anywhere within or outside of class or assembly by creating an object of that class.

    2. Private
    Private members are restricted to the class and cannot be accessed outside that class even by creating its object.

    3. Protected
    Protected members can be accessed within that class or in the class that is deriving it.But protected members can never be accessed by creating an object of the class. Protected members can be accessed only through inheritance.

   4. Internal
   Internal members of a class can be accessed anywhere within the assembly in which the class resides. We can think of internal as a subset of public, i.e., internal members act as public but only in that assembly.They are not accessible outside of that assembly.

   5. Protected Internal
   This compound access modifier is a combination of both Protected and Internal. Class members with this access modifier can be accessed in a derived class through inheritance or by creating an object or base class. But in a different assembly, this can be accessed only through inheritance and not by creating an object.

   6. Private Protected
   This compound access modifier is introduced to overcome the limitation of Protected Internal. In a private protected access modifier, the derived class from the different assembly cannot access the members which are Private Protected.
  */

    /// <summary>
    /// 
    /// </summary>
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

        /// <summary>
        /// PAccessible only through inheritance in same assembly.
        /// </summary>
        private protected int iPrivateProtected = 0;

        public string DisplayAge()
        {
            iProtectedAccess += 1;
            iPrivateProtected += 1;

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
            cm.iPrivateProtected = 10;

            CSharpAccessModifiers cam = new CSharpAccessModifiers();
            //cam.iProtectedAccess = 0; // Can't accessible
            cam.iProtectedInternalAccess = 0;
            //cam.iPrivateProtected = 5; // no accessible
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
