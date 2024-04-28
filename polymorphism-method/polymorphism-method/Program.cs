using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_method
{

    class baseClass
    {
        public virtual void method1()
        {
            Console.WriteLine("base class ka method");
        }
    }

    class derivedClass : baseClass
    {
        public void method2()
        {
            Console.WriteLine("derived class ka method");
        }

        public override void method1()
        {
            Console.WriteLine("base ka method");
        }
    }

    class derivedClass2 : derivedClass
    {
        public new void method1()
        {
            Console.WriteLine("derived ka derived class");
        }
    }

    internal class Program
    {
         public static void Main(string[] args)
        {
            baseClass a = new baseClass();   
            derivedClass b = new derivedClass();
            //a.method1 ();
            //b.method2 ();

            baseClass c;
            //c = b;
            //c.method1();

            derivedClass2 d = new derivedClass2();
            //d.method1();
            c = d;
            c.method1();

            
            
        }
    }
}


/*internal class program
{
    public static void Main(string[] args)
    {
         void display(int x, int y)
        {
            Console.WriteLine(x);
        }
    }
public class partial
    {
        int x = 10;
        int y = 20;

        public partial(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }

}
*/





       

