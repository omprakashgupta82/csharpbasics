using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    class SingltionClassDemo
    {
        private static SingltionClassDemo _singltonClassInstance = null;

        private SingltionClassDemo() { } // private constructor

        public static SingltionClassDemo Instance
        {
            get
            {
                if (_singltonClassInstance == null)
                    _singltonClassInstance = new SingltionClassDemo();

                return _singltonClassInstance;
            }
        }
    }

    class SingltionClassDemoMain 
    {
        static void Main()
        {
            SingltionClassDemo scd = SingltionClassDemo.Instance;

        }
    }
}
