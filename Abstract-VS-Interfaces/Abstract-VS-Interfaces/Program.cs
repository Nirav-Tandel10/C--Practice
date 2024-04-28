using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_VS_Interfaces
{                                                       // An interface can inherit from another interface only and 
                                                        // cannot inherit from an abstract class
                                                        // whereas an abstract class can inherit from another class or another interface
    public abstract class Customer
    {                                                   // A class "can inherit from multiple interfaces" at the same time,
        int ID;                                         // whereas a class "cannot inherit from multiple classes" at the same time
        public void Print()
        {                                               // interface cannot have fields ( int ID; )
                                                        // abstract class can have its fields.
            Console.WriteLine("print");
        }
    }

    public interface ICustomer                          // interface can not have implementation for any its members
    {
        
    }
    internal class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}







//---------- Implementation of MULTIPLE CLASS INHERITANCE USING INTERFACES----------

/*
namespace Abstract_VS_Interfaces
{

    interface IA
    {

    }

    class A : IA
    {
        public void Amethod()
        {
            Console.WriteLine("A method");
        }
    }


    interface IB
    {

    }
    class B : IB
    {
        public void Bmethod()
        {
            Console.WriteLine("B method");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void Amethod()
        {
           a.Amethod();
        }
        public void Bmethod()
        {
            b.Bmethod();
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            AB ab = new AB();
            ab.Amethod();
            ab.Bmethod();
        }
    }
}

*/
