using System;

namespace exercise_2
{
    class Program
    {
        static int count_digit(int a)
        {
           int count = 0;
            while (a > 0)
            {
                a = a / 10;
                ++count;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество чисел в числе = {count_digit(a)}"); 
        }
    }
}
