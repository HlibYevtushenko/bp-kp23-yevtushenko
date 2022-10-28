using System;
using System.ComponentModel.Design.Serialization;

namespace Art
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.WriteLine("Enter number 1 to 28: ");
                n = int.Parse(Console.ReadLine());
            } while (n > 28 | n < 1);
            int b_up = n;

            //Верхній трикутник
            for (int i_up = 0; i_up < n; i_up++)
            {
                for (int a_up = 0; 0 < (b_up * 2) - a_up; a_up++)
                {
                    Console.Write(" ");
                }
                b_up -= 1;
                Console.Write("|<>");
                int j_up = 4 * i_up;
                for (int c_up = 0; c_up < j_up; c_up++)
                {
                    Console.Write(".");
                }
                Console.Write("<>|\n");
            }

            //Нижній трикутник
            for (int i_down = n; i_down > i_down - n; n--)
            {
                int x = i_down - n;
                for (int a_down = -2; a_down < (x*4) - a_down; a_down++)
                {
                    Console.Write(" ");
                }
                Console.Write("|<>");
                int j_down = 4 * (n-1);
                for (int c_down = 0; c_down < j_down; c_down++)
                {
                    Console.Write(".");
                }
                Console.Write("<>|\n");
            }
        }
    }
}