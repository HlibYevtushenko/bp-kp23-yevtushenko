using System;
using System.Runtime.CompilerServices;

namespace Program
{
    class ConsoleApp1
    {
        static void Main(string[] args)
        {
            int n;
            int res;

            do
            {
                Console.WriteLine("Enter the number 1 to 9: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n > 9 || n < 1);

            for (int i = 0; i < n; i++)
            {
                int a = 1;
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("   ");
                }
                for (int x = 0; x <= i; x++)
                {
                    
                    Console.Write("  {0:D}  ", a);
                    a = a * (i - x) / (x + 1);
                    if (a % 10 == a)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}