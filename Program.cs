using System;

namespace pyramidForloops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<=10; i++)
            {
                for(int j=0; j<=i-1;j++)
                {
                    Console.Write(" ");
                }
                for (int k = 4; k <= i; k++) ;
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
