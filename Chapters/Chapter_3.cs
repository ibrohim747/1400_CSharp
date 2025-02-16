using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1400.Chapters
{
    internal class Chapter_3
    {
        public void Chapter_3_10(int k)
        {
            int nMonday = (k - 1) % 7;
            Console.WriteLine($"Part (a): January 1st is Monday. Day {k} is day of the week: {nMonday}");

            int nTuesday = (k) % 7;
            Console.WriteLine($"Part (b): January 1st is Tuesday. Day {k} is day of the week: {nTuesday}");
        }

        public void Chapter_3_09(int x)
        {
            int seconds_passed = x;
            int minutes_passed = seconds_passed / 60;
            int hour_passed = minutes_passed / 60;
            Console.WriteLine($"Passed Minutes = {minutes_passed}, and passed hours = {hour_passed}");
        }

        public void Chapter_3_08(int x)
        {
            decimal finding_seat = x - 1642;
            int number_of_rows = 20;
            decimal finding_rows = Math.Ceiling(finding_seat / number_of_rows);
            Console.WriteLine($"The finding row number = {finding_rows}");
        }

        public void Chapter_3_07(int x)
        {
            int floor_level = 5;
            int apartment_in_each_level = 15;
            decimal apartment_number = x;
            decimal required_apartment_level = Math.Ceiling(apartment_number / apartment_in_each_level);
            if (required_apartment_level > floor_level)
                Console.WriteLine("Incorrect apartment number");
            else;
                Console.WriteLine($"Required apartment number = {required_apartment_level}");
        }

        public void Chapter_3_06(int x)
        {
            int compartments = 9;
            int bunks_in_each_compartments = 4;
            decimal bunks_number = x;
            decimal required_compartments = Math.Ceiling(bunks_number / bunks_in_each_compartments);
            Console.WriteLine($"Requires compartments number = {required_compartments}");
        }

        public void Chapter_3_05()
        {
            int height = 543;
            int weight = 130;
            int square = 130;
            int by_hight = height / square;
            int by_wight = weight / square;
            int res = by_hight * by_wight;
            Console.WriteLine($"The number of squares intervening in the rectangule = {res}");
        }

        public void Chapter_3_04(int n, int k)
        {
            int apple_per_student = k / n;
            int remainding_applses = k % n;
            Console.WriteLine($"Apple per student {apple_per_student}, and the remainding apples = {remainding_applses}");

        }

        public void Chapter_3_03()
        {
            int past_days = 324;
            int past_weeks = past_days / 7;
            Console.WriteLine($"The past weeks: {past_weeks}");
        }

        public void Chapter_3_02()
        {
            int mass_in_kg = 201;
            int mass_in_ct = mass_in_kg / 100;
            Console.WriteLine($"Number of full centners in {mass_in_kg}kg: {mass_in_ct} centners");
        }

        public void Chapter_3_01()
        {
            int length_in_cm = 543;
            int length_in_m = length_in_cm / 100;
            Console.WriteLine("Number of full meters: " + length_in_m);
        }
    }
}
