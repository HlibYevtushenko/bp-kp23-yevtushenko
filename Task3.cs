using System;


namespace Practise1
{
    class Task3
    {
        static void Main(string[] args)
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            Console.WriteLine("Enter value for x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter value for x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter value for y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter value for y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of the vector is: " + a);

        }
    }
}
