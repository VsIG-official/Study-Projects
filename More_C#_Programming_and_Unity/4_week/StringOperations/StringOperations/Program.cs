using System;

namespace StringOperations
{
    /// <summary>
    /// String Operations lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates IndexOf and Substring methods
        /// </summary>
        static void Main()
        {
            // read in csv string
            Console.Write("Enter name and percent (name,percent): ");
            string csvString = Console.ReadLine();

            // find comma location
            int commaLocation = csvString.IndexOf(',');
            //Console.WriteLine("Comma location is: " + commaLocation);

            // extract name and percent
            string name = csvString.Substring(0, commaLocation);
            float percent = float.Parse(csvString.Substring(commaLocation + 1));

            // print name and percent
            Console.WriteLine("Name: " + name);
            Console.WriteLine("percent: " + percent);

            Console.WriteLine();
        }
    }
}
