using System;

namespace tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("задание 1");
            Console.WriteLine("как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"привет, {name}!");
            //2
            Console.WriteLine("задание 2");
            Console.Write("введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            double res = (double)a / b;
            Console.WriteLine($"результат деления: {res}");
            //3
            Console.WriteLine("задание 3");
            Console.WriteLine("введите латинскую букву");
            char l = Console.ReadKey().KeyChar;
            char r = (char)(l + 1);
            Console.WriteLine($"следующая буква {r}");
            //4
            Console.Write("Введите число: ");
            int aAa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число: ");
            int bBb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число: ");
            int cCc = Convert.ToInt32(Console.ReadLine());

            int di = bBb * bBb - 4 * aAa * cCc;
            if (di > 0)
            {
                int x = ((-bBb) + di) / (2 * aAa);
                int y = ((-bBb) - di) / (2 * aAa);
                Console.WriteLine($"корни уравнения {x},{y} ");

            }
            else if (di == 0)
            {
                int x = (-bBb) / (2 * aAa);
                Console.WriteLine($"корень уравнения {x}");
            }
            else
            {
                Console.WriteLine("нет корней");
            }
        }
    }
}
