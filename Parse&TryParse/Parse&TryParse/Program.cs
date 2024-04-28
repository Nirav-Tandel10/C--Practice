using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If the number is in a string format you have 2 option
            //1--parse()
            //2--Tryparse()

            //parse() method throws an exception if it cannot parse 
            //the value, whereas Tryparse() returns a bool indicating 
            //weather it succeeded or failed

            //use parse() if you are sure the value will be valid
            //otherwise use tryParse()

            //in TryParse()--- success=1; and failure= 0;

            string strNumber = "1000";

            int result;

            bool isConversionSuccessful = int.TryParse(strNumber, out result);

            if(isConversionSuccessful )
            {
                Console.WriteLine(result);

            } else
            {
                Console.Write("Enter Valid Number");
            }

            //Console.WriteLine(result);
        }
    }
}
