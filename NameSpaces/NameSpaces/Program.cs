using System;
using NameSpaces.ProjectA.teamA;  //PATA = .ProjectA.teamA;
using NameSpaces.ProjectA.teamA;  //PATB = .ProjectA.teamB;


namespace NameSpaces
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA.print(); //PATA.ClassA.print();
            ClassA.print(); //PATB.ClassA.print();
        }
    }

    namespace ProjectA
    {
        namespace teamA
        {
            class ClassA
            {
                public static void print()
                {
                    Console.WriteLine("team A print method");
                }
            }
        }
    }

    namespace ProjectB
    {
        namespace teamB
        {
            class ClassA
            {
                public static void print()
                {
                    Console.WriteLine("team B print method");
                }
            }
        }
    }
}

