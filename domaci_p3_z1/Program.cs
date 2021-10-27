using System;

namespace domaci_p3_z1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 50;
            int B = 100;

            for (int i = A; i <= B; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Broj {i} je paran broj");
                }
            }
        }
    }
}
