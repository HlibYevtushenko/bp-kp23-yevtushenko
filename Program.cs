using System;
using System.Runtime.CompilerServices;

namespace Practise2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float res;
            char op;
            bool close = false;
            char x;
            /*Console.Write("Enter number a: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            Console.Write("Enter number b: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            Console.Write("Enter operation symbol: ");
            op = Convert.ToChar(Console.ReadLine());
            Console.Clear();*/
            
            try
            {
                while (close == false)
                {
                    Console.Write("Enter operation symbol or type X to close the programm: ");
                    op = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    if (op == 'x' || op == 'X')
                    {
                        Console.WriteLine("Are you sure you want to close app? Y/N");
                        x = Convert.ToChar(Console.ReadLine());
                        if (x == 'Y' || x == 'y')
                        {
                            break;
                        }
                        else if (x == 'N' || x == 'n')
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Please enter only Y or N");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                    }
                    Console.Write("Enter number a: ");
                    a = Convert.ToSingle(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Enter number b: ");
                    b = Convert.ToSingle(Console.ReadLine());
                    Console.Clear();



                    switch (op)
                    {
                        case '+':
                            res = a + b;
                            Console.WriteLine("Result is: " + res);
                            break;
                        case '-':
                            res = a - b;
                            Console.WriteLine("Result is: " + res);
                            break;
                        case '/':
                            res = a / b;
                            Console.WriteLine("Result is: " + res);
                            break;
                        case '*':
                            res = a * b;
                            Console.WriteLine("Result is: " + res);
                            break;
                        default:
                            Console.WriteLine("It's not an operation symbol.");
                            Thread.Sleep(2500);
                            Console.Clear();
                            Console.WriteLine("Let's try again");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                            
                    }
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("I think you did something wrong =(");
            }
            
        }
    }
}