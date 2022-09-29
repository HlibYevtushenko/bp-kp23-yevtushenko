using System;
using System.Runtime.InteropServices;

namespace Exercise
{
    class Program
    {

        static void Main()
        {
            /*Розробити алгоритм і програму, в якої підраховується кількість годин, хвилин і секунд
            в заданому кількості доби. */
            /*Console.Write("Enter amount of days: ");
            try
            {
                float d = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                float h = d * 24;
                float m = h * 60;
                float s = m * 60;
                Console.WriteLine("Hours: {0};\nMinutes: {1};\nSeconds: {2};", h, m, s);
            }
            catch (System.FormatException) {
                Console.WriteLine("Please, write something like this: 6,5\nEnd.");            
            
            }*/

            /*Розробити алгоритм і програму, в якій обчислюється площа трикутника по трьом сторонам.
            Обчислення проводиться по формулі Герона. */
            /*Console.Clear();
            Console.Write("Enter first side in cm: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            Console.Write("Enter second side in cm: ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            Console.Write("Enter third side in cm: ");
            float c = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            float P = a + b + c;
            float p = P / 2;
            float A = p - a;
            float B = p - b;
            float C = p - c;
            float S = Convert.ToSingle(Math.Sqrt(p*A*B*C));
            Console.WriteLine(S);*/


            //Розробити алгоритм і програму, в якої обчислюються площа і об’єм сфери.
            /*try
            {
                Console.Write("Enter radius of sphere: ");
                float r = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                float R = Convert.ToSingle(Math.Pow(r, 2));
                float pi = Convert.ToSingle(Math.PI);
                float S = R * 4 * pi;
                float V = S * r / 3;
                Console.WriteLine("Surface area of sphere: " + S + "\nVolume of sphere: " + V);
            } catch(System.FormatException)
            {
                Console.WriteLine("Please, write something like this: 6,5\nEnd.");
            }*/



            //Розробити алгоритм і програму рішення системи лінійних рівнянь:
            /*try
            {
                Console.Write("Enter a1: ");
                float a1 = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                Console.Write("Enter b1: ");
                float b1 = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                Console.Write("Enter c1: ");
                float c1 = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                Console.Write("Enter a2: ");
                float a2 = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                Console.Write("Enter b2: ");
                float b2 = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                Console.Write("Enter c2: ");
                float c2 = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                float c1b1 = c1 * b1;
                float c2b2 = c2 * b2;
                float a1b1 = a1 * b1;
                float a2b2 = a2 * b2;
                float A = c1b1 - c2b2;
                float B = a1b1 - a2b2;
                float x = A / B;
                Console.Write("Your x is: " + x);
            } catch (System.FormatException)
            {
                Console.WriteLine("Please, write something like this: 6,5\nEnd.");
            }*/


            //Розробити алгоритм і програму визначення об’ємів циліндра і конуса з радіусом підстави R=5см і заввишки H = 8см.
            /*
           
             double pi = Math.PI;
             double h = 8;
             double r = 5;
             double R = Math.Pow(r, 2);
             double Vc = R * h * pi;
             Console.WriteLine("Volume of cylinder is: " + Vc);
             double Vk = Vc / 3;
             Console.WriteLine("Volume of cone is: " + Vk);
            */

            //Розробити алгоритм і програму визначення спільного опору електричного ланцюга, якщо є три резистора R1, R2, R3.
            try
            {
                Console.Write("Enter value of R1: ");
                float r1 = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                Console.Write("Enter value of R2: ");
                float r2 = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                Console.Write("Enter value of R3: ");
                float r3 = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                float R_up = r1 * r2 * r3;
                float R23 = r2 * r3;
                float R13 = r1 * r3;
                float R12 = r1 * r2;
                float R_down = R12 + R13 + R23;
                float R = R_up / R_down;
                Console.WriteLine("The asnwer is: " + R);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please, write something like this: 6,5\nEnd.");
            }



        }
    }

}