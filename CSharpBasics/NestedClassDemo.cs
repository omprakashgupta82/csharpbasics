using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    public class NestedClassDemo
    {
        static void Main(string[] args)
        {
            Container objContainer = new Container();
            Container.Nested objNested = new Container.Nested();
        }
    }

    public class Container
    {
        private int privateContainer = 0;
        protected int protectedContainer = 0;
        internal int internalContainer = 0;
        protected internal int protectedInternalContainer = 0;
        public int publicContainer = 0;

        public class Nested
        {
            private Container parent;

            public Nested()
            {
            }
            public Nested(Container parent)
            {
                this.parent = parent;
                
            }

            public void Display()
            {
                
            }
        }
    }
}
