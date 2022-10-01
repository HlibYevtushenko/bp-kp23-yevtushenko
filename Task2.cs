using System;


namespace Practise1
{
    class Task2
    {
        static void Main(string[] args)
        {
            float a = 0;
            float b = 0;
            float c = 0;
            Console.Write("Enter first side in cm: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            Console.Write("Enter second side in cm: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            Console.Write("Enter third side in cm: ");
            c = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            float p = (a + b + c) / 2;
            float S = Convert.ToSingle(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            Console.WriteLine(S);           
        }
    }
}
