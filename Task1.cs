using System;

namespace Practise1
{
    class Task1
    {
        public const double P1 = 3.14;
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            Console.WriteLine("Enter number a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter number b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter number c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter number d: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                    {
                        Console.WriteLine("The largest number is A: " + a);
                    }

                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("The largest number is C: " + c);
                    }
                    else
                    {
                        Console.WriteLine("The largest number is D:" + d);
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        Console.WriteLine("The largest number is B: " + b);
                    }

                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("The largest number is C: " + c);
                    }
                    else
                    {
                        Console.WriteLine("The largest number is D:" + d);
                    }
                }
            }

        }

    }

}
