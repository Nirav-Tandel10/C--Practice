using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*namespace datatypes
{
    internal class Program
    {
        static void Main()
        {
            int i = 0;

            Console.WriteLine("Min = {0}", int.MaxValue);
        }
    }
}*/


//------string type-------//


namespace datatypes
{
    internal class program
    {
        static void Main()
        {
            // we can not take null value into value type 
            // we can take it in reference type

            //if you want to input null value into value type then
            //we have to add ? symbol after data type
            
            //int i = null;
            int? j = null;

            //bool myBoolNum = null;

            bool? myBool = null;



            //-----EXAMPLE-1------//

            bool? areyou18yearold = true;

            if (areyou18yearold == true)
            {
                Console.WriteLine("entered");

            } else if(areyou18yearold == false) 
            {
                Console.WriteLine("not entered");
            } else
            {
                Console.WriteLine("not answered");
            }

            //------EXAMPLE-2-----//

            int? ticketOnSale = 100;

            int availableTicket;

            if (ticketOnSale == null)
            {
                availableTicket = 0;
            }
            else
            {
                //availableTicket = (int)ticketOnSale;
                availableTicket = ticketOnSale.Value;
            }

            Console.WriteLine("available ticket = {0}", availableTicket);



            //int a = 10;

            //float x = 28.23273F;

            //float n = (float) a;

            //Console.WriteLine(a);
            //Console.WriteLine(n);




            
        }
    }
} 


