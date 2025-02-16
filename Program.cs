using _1400.Chapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1400
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chapter_3 chapter_3 = new Chapter_3();

            {
                Console.Write("Enter the day of the year (k): ");
                int k = int.Parse(Console.ReadLine());
                chapter_3.Chapter_3_10(k);
            }

            chapter_3.Chapter_3_09(4200);

            chapter_3.Chapter_3_08(01646);

            chapter_3.Chapter_3_07(75);

            chapter_3.Chapter_3_06(13);

            chapter_3.Chapter_3_05();

            chapter_3.Chapter_3_04(4, 9);

            chapter_3.Chapter_3_03();

            chapter_3.Chapter_3_02();

            chapter_3.Chapter_3_01();

            Console.ReadLine();

            Chapter_1 chapter_1 = new Chapter_1();

            chapter_1.Chapter_1_10();

            Chapter_2 chapter_2 = new Chapter_2();

            chapter_2.Chapter_2_10();

            Console.ReadLine();
        }
    }
}
