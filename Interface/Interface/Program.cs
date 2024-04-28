using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    interface ICustomer
    {
        void print1();           // jab class me kuch implementation karna ho to interface ke sare members ka implementation hona jaruri hai 
    }

    interface ICustomer2 : ICustomer
    {
        void print2();
    }

    public class Customer : ICustomer2    // class ko ek se jyaada interface se inherit kar sakte hai
                                          // class ek se jyaada class se inherit nai kar sakte at one time
    {

        public void print1()        //must declare a body
        {
            Console.WriteLine("Interface print method");
        }

        public void print2()
        {
            Console.WriteLine("I2 ka Method");
        }


        public class Program
        {
            static void Main(string[] args)
            {
                Customer C1 = new Customer();             //Interface ka instance nahi bana sakte
                C1.print1();

                Customer C2 = new Customer();
                C2.print2();

                ICustomer C3 = new Customer();  
                C3.print1();
            }
        }
    }
}