using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1400
{
    public class Chapter_1
    {
        public void Chapter_1_10()
        {
            {
                Console.WriteLine("\n -------1.10--------- ");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine(name);
            }

            {
                Console.WriteLine("\n -------1.9--------- ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a + " - вот какое число Вы ввели");
            }

            {
                Console.WriteLine("\n -------1.8--------- ");
                string a = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Вы ввели число - " + a);
            }

            {
                Console.WriteLine("\n -------1.7--------- ");
                double e = Math.Round(2.71828, 1);
                Console.WriteLine(e);
            }

            {
                Console.WriteLine("\n -------1.6--------- ");
                float a = 3.1415926f;
                //Math.Round(число, количество знаков после запятой);
                double b = Math.Round(a, 3); //3.14
                double c = Math.Round(3.1415926, 2); //3.14
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }

            {
                Console.WriteLine("\n -------1.5--------- ");
                Console.WriteLine("1 \n2");
            }

            {
                Console.WriteLine("\n -------1.4--------- ");
                Console.Write("5 \n");
                Console.Write("10 \n");
                Console.Write("20 \n");
            }

            {
                Console.WriteLine("\n -------1.3--------- ");
                int a = 50, b = 10;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }

            {
                Console.WriteLine("\n -------1.2--------- ");
                int a = 47, b = 52, c = 150;
                Console.WriteLine("{0}  {1}  {2}", a, b, c);
            }

            {
                Console.WriteLine("\n -------1.1--------- ");
                int a = 31, b = 18, c = 19;
                Console.WriteLine(a + " " + b + " " + c);
            }
        }

        public void Chapter_1_20()
        {
            {
                Console.WriteLine("\n -------1.16--------- ");
                Console.WriteLine("Введите t ");
                int t = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите v ");
                int v = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите x ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите y ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{t} {v} {x}");
            }

            {
                Console.WriteLine("\n -------1.15--------- ");
                Console.WriteLine("Введите число 1 ");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 2 ");
                int a2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 3 ");
                int a3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} {1} {2}", a1, a2, a3);
            }

            {


                Console.WriteLine("\n -------1.14--------- ");
                Console.WriteLine("Введите число 1 ");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 2 ");
                int a2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 3 ");
                int a3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}   {1}   {2}", a1, a2, a3);
            }

            {
                Console.WriteLine("\n -------1.13--------- ");
                Console.WriteLine("Введите число");
                int a = Convert.ToInt32(Console.ReadLine());
                int bb = a + 1;
                int mm = a - 1;
                Console.WriteLine("Следующее за числом " + a + " число - " + bb);
                Console.WriteLine($"Для числа {a} предыдущее число - {mm}");
            }

            {
                Console.WriteLine("\n -------1.12--------- ");
                Console.WriteLine("Введите имя");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Привет, {0}!", name);
            }

            {
                Console.WriteLine("\n -------1.11--------- ");
                Console.WriteLine("Введите имя команды");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine(name + " чемпион");
            }
        }
    }
}
