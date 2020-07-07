using System;

namespace Exercise12
{
    /// <summary>
    /// Exercise 12 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests the Matherator methods
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main()
        {
            Matherator math = new Matherator();

            // method with no return value, no parameters
            math.PrintOneToTen();
            Console.WriteLine();

            // method with no return value, with parameters
            math.PrintMToN(5, 7);
            Console.WriteLine();

            // method with return value, no parameters
            int tenthEvenNumber = math.GetTenthEvenNumber();
            Console.WriteLine("Tenth Even Number: " + tenthEvenNumber);
            Console.WriteLine();

            // method with return value, with parameters
            int nthEvenNumber = math.GetNthEvenNumber(4);
            Console.WriteLine("Nth Even Number: " + nthEvenNumber);
            Console.WriteLine();

            Console.WriteLine();

            Console.Read();
        }
    }
}
