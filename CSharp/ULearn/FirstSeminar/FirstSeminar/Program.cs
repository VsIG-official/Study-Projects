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
            Second2Excercise();
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
    }
}
