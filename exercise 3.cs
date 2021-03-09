using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,s = 0;
            byte count = 0;

            a = Convert.ToInt32(Console.ReadLine());
            while (a!=0)
            {
                ++count;
                s += a;
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Всего введено чисел {count} ");
            Console.WriteLine($"Их сумма равна {s} ");
        }
    }
}
