using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserChoice = string.Empty;

            do
            {
                Console.WriteLine("enter yout target: ");

                int Usertarget = int.Parse(Console.ReadLine());

                int start = 0;

                //----While loop----//
                while (start <= Usertarget)
                {
                    Console.WriteLine(start);
                    start += 2;
                }

                do
                {
                    Console.WriteLine("Do You Want to continue - Yes or No");

                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice! please say Yes or No");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");

            //for loop
            //The for loop executes a statement or a block of statements
            //repeatedly until a specified expression evaluates to false.


            //for each loop
            //The foreach statement repeats a group of embedded statements
            //for each element in an array or an object collection.
            //You do not need to specify the loop bounds minimum or maximum

            //----EXAMPLE--FOR EACH----//

            int[] numbers = new int[2];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

        }  
    }
}
