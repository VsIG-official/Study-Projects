using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment4
{
    // Don't change ANY of the code in this file; if you
    // do, you'll break the automated grader!

    /// <summary>
    /// Programming Assignment 4
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests the Digitizer class
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            Digitizer digitizer = new Digitizer();

            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // convert word to digit and print
                Console.WriteLine(digitizer.ConvertWordToDigit(input));

                input = Console.ReadLine();
            }
        }
    }
}
