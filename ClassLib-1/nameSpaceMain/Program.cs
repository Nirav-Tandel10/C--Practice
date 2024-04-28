using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using NameSpace;
using NameSpace2;

namespace NameSpace
{

    public class first
    {
        public void PublicMethod()
        {
            Console.WriteLine("this is public method");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("this is private method");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("this is private method");
        }
        internal void internalMethod()
        {
            Console.WriteLine("this is private method");
        }


        public class AnotherClass
        {

            public void method()
            {
                Console.WriteLine("method inside the same name space");
            }
        }
    }
}

namespace NameSpace2
{

    class second
    {
        public void Second()
        {
            Console.WriteLine("bye world");
        }
    }

}

internal class Program
{

    static void Main(string[] args)
    {
        NameSpace.first first = new NameSpace.first();
        first.PublicMethod();
        first.internalMethod();

    }
}





