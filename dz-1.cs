using System;

namespace latypova
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //1
            Console.WriteLine("задание 1");
            double e = Math.E;
            Console.WriteLine(e.ToString("F1"));
            //2
            Console.WriteLine("задаие 2");
            Console.WriteLine("50");
            Console.WriteLine("10");
            //3
            Console.WriteLine("задание 3");
            Random num = new Random();
            int a = num.Next();
            Console.WriteLine(a);
            int b = num.Next();
            Console.WriteLine(b);
            int c = num.Next();
            Console.WriteLine(c);
            int d = num.Next();
            Console.WriteLine(d);
            //4
            Console.WriteLine("задание 4");
            Console.WriteLine("введите любое число");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(g+10);
            //5
            Console.WriteLine("задание 5");
            Console.WriteLine("введите любое количество градусов");
            int h = Convert.ToInt32(Console.ReadLine());
            double hh = h;
            double y = Math.Cos(hh);
            Console.WriteLine(y); 
            //6
            Console.WriteLine("задание 6");
            Console.WriteLine("введите высоту равнобедренной трапеции");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите большое основание равнобедренной трапеции");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите малое основание трапеции");
            int r = Convert.ToInt32(Console.ReadLine());
            double k = (w - q) / 2;
            double l = r * r + k * k;
            double m = Math.Sqrt(l);
            Console.WriteLine($"периметр: {m + m + w + q}");
            //7
            Console.WriteLine("задание 7");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир\n\tТруд\n\t\tМай");
            //8
            Console.WriteLine("задание 8");
            Console.WriteLine("введите первую числовую переменную");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите вторую числовую переменную");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{u} {t}");
            //9
            Console.WriteLine("задание 9");
            Console.WriteLine("введите число");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"вы вывели число {i}");
            //10
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
            //11
            Console.WriteLine("задание 11");
            Console.WriteLine("введите первое число");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int p = Convert.ToInt32(Console.ReadLine());
            double sral = (o + p) / 2;
            double srgeo = Math.Sqrt(o * p);
            Console.WriteLine($"среднее арифметическое:{sral}");
            Console.WriteLine($"среднее геомерическое:{srgeo}");
            //12
            Console.WriteLine("задание 12");
            Console.WriteLine("введите координаты первой точки на оси x");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите координаты первой точки на оси y");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите координаты второй точки на оси x");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите координаты второй точки на оси y");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            double s = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine($"расстояние между точами: {s}");
            //13
            Console.WriteLine("задание 13");
            Console.WriteLine("введите значене a");
            int aa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите значене b");
            int ab = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите значене c");
            int ac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" a = {ab}, b = {ac}, c = {aa}");
            Console.WriteLine($"a = {ac}, b ={aa}, c = {ab}");
            //14
            Console.WriteLine("задание 14");
            Console.WriteLine("введите количество пройденных секунд");
            int j = Convert.ToInt32(Console.ReadLine());
            int hour = j / 3600;
            int min = (j % 3600) / 60;
            int sec = (j % 3600) % 60;
            Console.WriteLine($"количество полных часов пройденных с начала суток: {hour}");
            Console.WriteLine($"количество полных минут пройденных с начала очередного часа: {min}");
            Console.WriteLine($"количество полных часов пройденных с начала очередной минуты: {sec}");
            //15
            Console.WriteLine("задание 15");
            int q1 = 543;
            int w1 = 130;
            int qw = (q1 * w1) / (130 * 130);
            Console.WriteLine($"количество квадратов, которое можно отрезать от него со стороной 130 мм: {qw}");
            //16
            Console.WriteLine("задание 16");
            Console.WriteLine("введите трехзначное число");
            int ch = Convert.ToInt32(Console.ReadLine());
            int first = ch / 100;
            int second = (ch / 10) % 10;
            int last = ch % 10;
            Console.WriteLine($"{last}{first}{second}");
            //17
            Console.WriteLine("задание 17");
            Console.WriteLine("введите число больше 999");
            int tr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"число сотен: {tr / 100}, число тысяч: {tr / 1000}");
            //18
            Console.WriteLine("задание 18");
            Console.WriteLine("введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("введите ваше имя");
            string name1 = Console.ReadLine();
            Console.WriteLine($"{name1}, привет!");
            //19 
            Console.WriteLine("задание 19");
            Console.WriteLine("привет, консоль");
            Console.WriteLine("как вас зовут?");
            string user = Console.ReadLine();
            Console.WriteLine($"привет, {user}!");
            Console.WriteLine("ты знаешь что-то о тайной комнате?");
            Console.WriteLine("да");
            Console.WriteLine("расскажи о ней");
            Console.WriteLine("нет");
            Thread.Sleep(5000);
            Console.WriteLine("но могу показать");
            Random rand = new Random();
            ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor = colors[rand.Next(colors.Length)]; 
            Console.WriteLine("***"); 
            Console.ResetColor();
            //20
            Console.WriteLine(" задание 20");
            string random12 = $"{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}{new Random().Next(0, 9)}";
            int sum = 0;
            for (int v = 0; v < 12; v += 2)
            {
                sum += Convert.ToInt32(random12[v]) * 3 + Convert.ToInt32(random12[v + 1]);
            }
            Console.WriteLine($"контрольная цифра  {10 - sum % 10}");
            Console.WriteLine("введите цифры -> ");

            string ls = $"{Console.ReadLine()}{Console.ReadLine()}{Console.ReadLine()}{Console.ReadLine()}{Console.ReadLine()}{Console.ReadLine()}{Console.ReadLine()}{Console.ReadLine()}{Console.ReadLine()}{Console.ReadLine()}{Console.ReadLine()}{Console.ReadLine()}";
            sum = 0;
            for (int v = 0; l < 12; l += 2)
            {
                sum += Convert.ToInt32(ls[v]) * 3 + Convert.ToInt32(ls[v + 1]);
            }
            Console.WriteLine(10 - sum % 10);
        }


    }
}
