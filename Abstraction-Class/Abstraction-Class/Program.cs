using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Class
{

    public abstract class A
    {

        public abstract void show();
       public void method1()
        {
            Console.WriteLine("method1");
        }
    }

    public class B: A
    {
        public override void show()
        {
            Console.WriteLine("method2");
        }
    }

    public class C:A
    {
        public override void show()
        {
            Console.WriteLine("method3");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            B b = new B();
            //b.method1();
            //b.show();

            C c = new C();
            c.show();

        }
    }
}
