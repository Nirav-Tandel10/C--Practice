using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  namespace Methods
{
    internal class Program
    {

        //static method
        static void Main(string[] args)
        {
            //Program p = new Program(50);
            Program.EvenNumbers(50);

            Program p = new Program();
           int sum =  p.Add(10,20);

            Console.WriteLine(sum); 
        }

        public int Add( int FN, int SN)
        {
            return FN + SN;
        }

        //instance method
        public static void EvenNumbers(int Target)
        {
            int Start = 0;

            while(Start <= Target) 
            {
                Console.WriteLine(Start);
                Start += 2;
            }
        }
    }
}

*/


class Program
{
    public static void Main(String[] args)
    {  
        int i = 0;
        SimpleMethod(ref i);
        Console.WriteLine(i);
    }

    public static void SimpleMethod( ref int j)
    {
        j = 101;
    }
}
