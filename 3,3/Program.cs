using System;

namespace Uppgift_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int timpris = 80;
            int maxDagskostnad = 950;

           
            Console.Write("Hur många timmar vill du hyra bilen? ");
            int timmar = int.Parse(Console.ReadLine());

           
            int kostnad = timmar * timpris;

           
            if (kostnad > maxDagskostnad)
            {
                kostnad = maxDagskostnad;
            }

           
            Console.WriteLine("Det kommer att kosta: " + kostnad + " kr");
        }
    }
}
