using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1400
{
    internal class Chapter_2
    {
        public void Chapter_2_10()
        {
            {
                Console.WriteLine("\n -------2.10--------- ");
                Console.WriteLine("Введите первое число: ");
                int e1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int e2 = Convert.ToInt32(Console.ReadLine());
                int math_midle = (e1 + e2) / 2;
                int geom_midle = (int)Math.Sqrt(e1 + e2);
                Console.WriteLine("Среднее арифметическое значение чисел равна {0}, среднее геометрическое значение равна {1}", math_midle, geom_midle);
            }

            {
                Console.WriteLine("\n -------2.9--------- ");
            }

            {
                Console.WriteLine("\n -------2.8--------- ");
                Console.WriteLine("Введите радиус окружности ");
                int R = Convert.ToInt32(Console.ReadLine());
                int P = (int)Math.PI * (R * 2);
                int S = (int)Math.PI * (R * 2);
                Console.WriteLine("Периметр круга равна {0} и площадб круга равна {1}", P, S);
            }

            {
                Console.WriteLine("\n -------2.7--------- ");
                Console.WriteLine("Введите длину ребра куба ");
                int a = Convert.ToInt32(Console.ReadLine());
                int P = (int)Math.Pow(a, 2);
                int L = (int)Math.Pow(a, 3);
                Console.WriteLine($"Плошадь боковой поверхности куба равна - {P}");
                Console.WriteLine($"Объем куба равна - {L}");
            }

            {
                Console.WriteLine("\n -------2.6--------- ");
                const int EARTH_RADIUS = 6350;
                Console.WriteLine("Введите высоту от Земли ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(EARTH_RADIUS - a);
            }

            {
                Console.WriteLine("\n -------2.5--------- ");
                Console.WriteLine("Введите радиус окружности ");
                int R = Convert.ToInt32(Console.ReadLine());
                int D = R * 2;
                Console.WriteLine(D);
            }

            {
                Console.WriteLine("\n -------2.4--------- ");
                Console.WriteLine("Введите длину стороны квадрата ");
                int a = Convert.ToInt32(Console.ReadLine());
                int P = a * 4;
                Console.WriteLine(P);
            }

            {
                Console.WriteLine("\n -------2.3.A--------- ");
                Console.WriteLine("Введите a ");
                int a = Convert.ToInt32(Console.ReadLine());
                int ysin = (int)Math.Sin(3 * a);
                int topy = 2 * a + ysin;
                int y = (int)Math.Sqrt(topy / 3.56);
                Console.WriteLine(y);

                Console.WriteLine("\n -------2.3.B--------- ");
                Console.WriteLine("Введите x ");
                int x = Convert.ToInt32(Console.ReadLine());
                int topx = (int)Math.Sqrt(1 + x);
                int xy = (int)Math.Sin((3.2 + topx) / 5 * x);
                Console.WriteLine(xy);
            }

            {
                Console.WriteLine("\n -------2.2--------- ");
                Console.WriteLine("Введите a ");
                int a = Convert.ToInt32(Console.ReadLine());
                int y1 = a * a + 10;
                int y2 = (int)Math.Sqrt(a * a + 1);
                int y = y1 / y2;
                Console.WriteLine("Y = " + y);
            }

            {
                Console.WriteLine("\n -------2.1.A--------- ");
                Console.WriteLine("Введите Х ");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = 17 * (x * x) - 6 * x + 13;
                Console.WriteLine("Y = " + y);

                Console.WriteLine("\n -------2.1.B--------- ");
                Console.WriteLine("Введите a ");
                int a = Convert.ToInt32(Console.ReadLine());
                int y1 = 3 * (a * a) + 5 * a - 21;
                Console.WriteLine("Y = " + y1);
            }
        }

        public void Chapter_2_20()
        {
            {
                Console.WriteLine("\n -------2.13--------- ");
                Console.WriteLine("Введите A ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите B ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Х ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (a > 0)
                {
                    int res = a * x + b;
                    Console.WriteLine(res);
                }
                else { Console.WriteLine("Значение А должно быть больше 0"); }
            }
        }

        public void Chapter_2_30()
        {
            {
                Console.WriteLine("\n -------2.29--------- ");

                int[] p1 = { 1, 1 };
                int[] p2 = { 3, 2 };
                int[] p3 = { 2, 3 };

                // Вычисляем длину вектора
                double length1 = CalculateDistance(p1, p2);
                double length2 = CalculateDistance(p1, p3);
                double length3 = CalculateDistance(p2, p3);

                //Округлить до тысячных
                length1 = Math.Round(length1, 4); //3.141
                length2 = Math.Round(length1, 3); //3.14
                length3 = Math.Round(length1, 3); //3.14

                // Выводим результат
                Console.WriteLine("Длина вектора #1: " + length1);
                Console.WriteLine("Длина вектора #2: " + length2);
                Console.WriteLine("Длина вектора #3: " + length3);

                Console.WriteLine("Периметр равна " + (length1 + length2 + length3));


                double CalculateDistance(int[] point1, int[] point2)
                {
                    // Разность координат по x и по y
                    uint dx = (uint)Math.Abs(point1[0] - point2[0]);
                    uint dy = (uint)Math.Abs(point1[1] - point2[1]);

                    // Вычисление длины вектора
                    return Math.Sqrt(dx * dx + dy * dy);
                }
            }

            {
                Console.WriteLine("\n -------2.27--------- ");
                {
                    // Ввод значений для основания и высоты
                    Console.Write("Введите длину большего основания (a): ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите длину меньшего основания (b): ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите высоту (h): ");
                    double h = Convert.ToDouble(Console.ReadLine());

                    // Вычисляем периметр
                    double perimeter = CalculatePerimeter(a, b, h);

                    // Выводим результат
                    Console.WriteLine("Периметр трапеции: " + perimeter);
                }

                double CalculatePerimeter(double a, double b, double h)
                {
                    // Вычисление боковой стороны
                    double c = Math.Sqrt(Math.Pow((a - b) / 2, 2) + Math.Pow(h, 2));

                    // Вычисление периметра
                    return a + b + 2 * c;
                }
            }

            {
                Console.WriteLine("\n -------2.26.A--------- ");
                int[] p1 = { 1, 1 };
                int[] p2 = { 3, 2 };

                uint corx = (uint)Math.Abs(p1[0] - p2[0]);
                uint cory = (uint)Math.Abs(p1[1] - p2[1]);

                float res = (float)Math.Sqrt(cory * cory + corx * corx);

                Console.WriteLine(res);
            }

            {
                Console.WriteLine("\n -------2.26.B--------- ");
                int[] p1 = { 1, 1 };

                // Координаты второй точки
                int[] p2 = { 3, 2 };

                // Вычисляем длину вектора
                double length = CalculateDistance(p1, p2);

                // Выводим результат
                Console.WriteLine("Длина вектора: " + length);

                double CalculateDistance(int[] point1, int[] point2)
                {
                    // Разность координат по x и по y
                    int dx = point2[0] - point1[0];
                    int dy = point2[1] - point1[1];

                    // Вычисление длины вектора
                    return Math.Sqrt(dx * dx + dy * dy);
                }
            }
        }
    }
}
