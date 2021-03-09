using System;

namespace HW2
{
    class Program
    {
        static double min(double a, double b, double c)
        {
            double min_number = 0;
            if (a<b && a<c)
            {
                min_number = a;
            }
            else
                if (b<c && b<a)
            {
                min_number = b;
            }
            else
                if (c<a && c<b)
            {
                min_number = c;
            }
            return min_number;
        }


        static void Main(string[] args)
        {
            double a, b,c;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Минимальное из чисел a,b,c равно");
            Console.WriteLine(min(a, b, c));
        }
    }
}