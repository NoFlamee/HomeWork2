using System;

namespace exercise_4
{
    class Program
    {
        static bool check(int i)
        {
            string login, password;
            bool fl = false;
            Console.WriteLine("Логин ");
            login = Console.ReadLine();
            Console.WriteLine("Пароль ");
            password = Console.ReadLine();
            if ((login == "root") && (password == "GeekBrains"))
                fl = true;
            else
            {
                fl = false;
                Console.WriteLine($"Количество оставшихся попыток {i}");
            }
            return fl;
        }
        static void Main(string[] args)
        {
            int i = 2;
            bool authentication = false;
            do
            {
                Console.WriteLine("Введите логин и пароль");
                authentication = check(i);
                --i;
            }
            while ((authentication != true) && (i > -1));
        }
    }
}
