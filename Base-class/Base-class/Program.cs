using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Base_class
{
    public class Animal
    {
         public string color = "white";
    }

    public class dog : Animal
    {
        string color = "black";

        public void Showcolor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
    }

    public class test
    {
        public static void Main(string[] args)
        {
            dog d = new dog();
            d.Showcolor();
        }
    }
}



