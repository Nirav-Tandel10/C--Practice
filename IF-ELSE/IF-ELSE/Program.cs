using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a number:");

            //to read from console
            // here, the readable form of readline is in string format but we have to input 
            // int type. so we have to convert int to string. so we used parse() method.

            int UserNumber =  int.Parse(Console.ReadLine());

            if (UserNumber == 1 || UserNumber == 2)
            {
                Console.WriteLine("Your Number is One or might be Two");
            }
            else
            {
                Console.WriteLine("your number is greater than One");
            }


            //Difference
            //1. between || and | 
            // ||-- if first condition is true then it wont check another condition.
            // | -- it checks all the condition weather first will false.

            //2. between && ans &
            // && -- if first condition is true then it wont check another condition. it will execute if first condition will be true.
            // & -- it checks all the condition if first will false. then execute....

        }
    }
}
