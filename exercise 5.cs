using System;

namespace exercise_5
{
    class Program
    {
        static void check(double x,double height,double weigth)
        {
            double s;
            if (x < 19.0)
            {
                s = 19.0 * height*height;
                weigth = s - weigth;
                Console.WriteLine($"Вам нужно поправиться на {weigth} киллограм");
            }
            else
                if ((x > 19.0) && (x < 24.0))
            {
                Console.WriteLine("Ваш вес в норме ");
            }
            else
            {
                s = 24.0 * height * height;
                weigth = (s - weigth) * (-1);
                Console.WriteLine($"Вам нужно похудеть на {weigth} киллограм ");
            }
        }
        static double index(double height, double weight)
        {
           double l;
            l = weight / (height * height);
            return l;
        }
        
        static void Main(string[] args)
        {
            double height, weight;
            double l;
            Console.WriteLine("Введите ваш рост в метрах");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес ");
            weight = Convert.ToDouble(Console.ReadLine());
            l = index(height, weight);
            Console.WriteLine($"Ваш индекс массы равен {l}");
            check(l, height, weight);



        }
    }
}
