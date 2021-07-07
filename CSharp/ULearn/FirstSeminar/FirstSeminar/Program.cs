// Licensed to the VsIG under one or more agreements.
// The VsIG licenses this file to you under the MIT license.

using System;

namespace FirstSeminar
{
    internal class Program
    {
        private static void Main()
        {
            FirstExcercise();
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
    }
}
