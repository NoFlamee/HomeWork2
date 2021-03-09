using System;

namespace exercise_6
{
    class Program
    {
        static int amount(int a,int b)
        {
            if (b == (a-1))
                return 0;
            else
                return b + amount(a,b - 1);

        }
        static void Main(string[] args)
        {
            int a, b,sum;
            Console.WriteLine("Ведите число а ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите число b ");
            b = Convert.ToInt32(Console.ReadLine());
            sum = amount(a, b);
            Console.WriteLine(sum);
        }
    }
}
