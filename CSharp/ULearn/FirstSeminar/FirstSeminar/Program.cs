// Licensed to the VsIG under one or more agreements.
// The VsIG licenses this file to you under the MIT license.

using System;
using System.Text;

namespace FirstSeminar
{
    internal class Program
    {
        private static void Main()
        {
            // FirstExcercise();
            // Second1Excercise();
            // Second2Excercise();
            for (int i = 0; i <= 24; i++)
            {
                ThirdExcercise(i);
            }
        }

        private static void FirstExcercise()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a += b; // a = 3, b = 2
            Console.WriteLine(a);
            Console.WriteLine(b);

            b = a - b; // a = 3, b = 1
            Console.WriteLine(a);
            Console.WriteLine(b);

            a -= b; // a = 2, b = 1
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        private static void Second1Excercise()
        {
            int a = 123;
            string aStr = a.ToString();
            StringBuilder bStr = new();

            for (int i = 2; i >= 0; i--)
            {
                bStr.Append(aStr[i]);
            }

            int b = int.Parse(bStr.ToString());

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        private static void Second2Excercise()
        {
            string aStr = "123";
            StringBuilder bStr = new();

            for (int i = 2; i >= 0; i--)
            {
                bStr.Append(aStr[i]);
            }

            Console.WriteLine(aStr);
            Console.WriteLine(bStr);
        }

        private static void ThirdExcercise(int time)
        {
            int totalDegrees = 360;
            int hours = 12;
            int degreesPerHour = totalDegrees / hours;

            int oldTime = time;
            int degrees = 0;

            if (time > 12)
            {
                time -= 12;
            }
            if (time != 12)
            {
                degrees = degreesPerHour * time;
            }
            if (degrees > 180)
            {
                degrees = 360 - degrees;
            }

            Console.WriteLine($"{oldTime}: {degrees}");
        }
    }
}
