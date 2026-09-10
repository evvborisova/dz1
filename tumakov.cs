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
            Console.WriteLine("задание 4");
            Console.Write("введите коэффициент a ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите коэффициент b ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите коэффициент c ");
            int C = Convert.ToInt32(Console.ReadLine());

            int D = B * B - 4 * A * C;
            if (D > 0)
            {
                int x1 = ((-B) + D) / (2 * A);
                int x2 = ((-B) - D) / (2 * A);
                Console.WriteLine($"корни уравнения {x1},{x2} ");

            }
            else if (D == 0)
            {
                int x = (-B) / (2 * A);
                Console.WriteLine($"корень уравнения {x}");
            }
            else
            {
                Console.WriteLine("нет корней");
            }
        }
    }
}
